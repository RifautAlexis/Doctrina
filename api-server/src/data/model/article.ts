import { Model, Schema, Document, model } from 'mongoose';
import { ARTICLE_MODEL, ARTICLE_COLLECTION } from '../data.constants';
import { ITagDocument } from './tag';
import { IUserDocument } from './user';

export const ArticleSchema = new Schema(
    {
        authorIds: {
            type: [String],
            required: true
        },
        title: {
            type: String,
            required: true,
            unique: true
        },
        content: {
            type: String,
            required: true
        },
        tagIds: {
            type: [String],
            required: true
        }
    },
    {
        id: true,
        timestamps: true,
        toJSON: { getters: true, virtuals: true },
        toObject: { getters: true, virtuals: true }
    }
);

export interface IArticleDocument extends Document {
    authorsId: IUserDocument['_id'];
    title: String;
    content: String;
    tagIds: ITagDocument['_id'];
    createdAt: Date;
    updatedAt: Date;
};

export const articleModel: Model<IArticleDocument> = model<IArticleDocument>(
    ARTICLE_MODEL,
    ArticleSchema,
    ARTICLE_COLLECTION
);

// const article: IArticleDocument | null = await articleModel.findById("id");
// const lol: string = article?._id;