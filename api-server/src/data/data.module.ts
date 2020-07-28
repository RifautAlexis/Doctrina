import { tagSchema } from './schema/tag.schema';
import { articleSchema } from './schema/article.schema';
import { userSchema } from './schema/user.schema';
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
                name: 'User',
                schema: userSchema,
                collection: 'users'
            },
            {
                name: 'Article',
                schema: articleSchema,
                collection: 'articles'
            },
            {
                name: 'Tag',
                schema: tagSchema,
                collection: 'tags'
            },
        ])
    ],
    controllers: [],
    providers: [],
})
export class DataModule { }
