import { USER_MODEL, ARTICLE_MODEL, TAG_MODEL, TAG_COLLECTION, ARTICLE_COLLECTION, USER_COLLECTION } from './data.constants';
import { TagSchema } from './model/tag';
import { ArticleSchema } from './model/article';
import { UserSchema } from './model/user';
import { Module } from '@nestjs/common';
import { MongooseModule } from '@nestjs/mongoose'
import { MongooseConfig } from './mongoose.config'

@Module({
    imports: [
        MongooseModule.forRootAsync({
            useClass: MongooseConfig
        }),
        MongooseModule.forFeature([
            {
                name: USER_MODEL,
                schema: UserSchema,
                collection: USER_COLLECTION
            },
            {
                name: ARTICLE_MODEL,
                schema: ArticleSchema,
                collection: ARTICLE_COLLECTION
            },
            {
                name: TAG_MODEL,
                schema: TagSchema,
                collection: TAG_COLLECTION
            },
        ])
    ],
    controllers: [],
    providers: [],
})
export class DataModule { }
