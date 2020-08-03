import { connect, disconnect, Model, model } from 'mongoose';
import { USER_MODEL, USER_COLLECTION, ARTICLE_MODEL, ARTICLE_COLLECTION, TAG_MODEL, TAG_COLLECTION } from './data.constants';
import { TagSchema, tagModel, ITagDocument } from './model/tag';
import { ArticleSchema, articleModel, IArticleDocument } from './model/article';
import { UserSchema, userModel } from './model/user';
import { articlesToSeed, tagsToSeed, usersToSeed } from './data-seed';
import * as dotenv from "dotenv";

dotenv.config();
const uri: string = process.env.DATABASE_URI as string;

(async function () {
    connect(uri);

    await tagModel.collection.deleteMany({});
    await userModel.collection.deleteMany({});
    await articleModel.collection.deleteMany({});
    
    await Promise.all([
        tagModel.create(tagsToSeed),
        userModel.create(usersToSeed)
    ])
    .then(([tags, users]) => {
        const articlesToAdd: Array<IArticleDocument> = articlesToSeed.map(article => {
            article.authorIds = users[0]._id;
            const sampleTags: ITagDocument[] = tags
                .map(x => ({ x, r: Math.random() }))
                .sort((a, b) => a.r - b.r)
                .map(a => a.x)
                .slice(0, 3);
            article.tagIds = sampleTags.map(tag => tag._id); 
        });
        articleModel.create(articlesToAdd)
    });

    await disconnect();

    process.exit();
})();