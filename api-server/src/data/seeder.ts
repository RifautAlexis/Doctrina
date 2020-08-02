import { connect, disconnect, Model, model } from 'mongoose';
import { USER_MODEL, USER_COLLECTION, ARTICLE_MODEL, ARTICLE_COLLECTION, TAG_MODEL, TAG_COLLECTION } from './data.constants';
import { TagSchema, tagModel } from './model/tag';
import { ArticleSchema, articleModel } from './model/article';
import { UserSchema, userModel } from './model/user';
import { tagsToSeed } from './data-seed';
import * as dotenv from "dotenv";

dotenv.config();
const uri: string = process.env.DATABASE_URI as string;

(async function () {
    connect(uri);

    await tagModel.collection.deleteMany({});
    await userModel.collection.deleteMany({});
    await articleModel.collection.deleteMany({});
    
    await Promise.all([
        tagModel.create(tagsToSeed)
    ])
    .then(([tags]) => {
        // const 
    });

    await disconnect();

    process.exit();
})();