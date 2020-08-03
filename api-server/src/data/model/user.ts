import { Model, Schema, Document, model } from 'mongoose';
import { USER_MODEL, USER_COLLECTION } from '../data.constants';
import { IArticleDocument } from './article';

export const UserSchema = new Schema(
    {
        username: {
            type: String,
            required: true
        },
        articleIds: {
            type: [String],
            required: false
        }
    },
    {
        id: true,
        timestamps: true,
        toJSON: { getters: true, virtuals: true },
        toObject: { getters: true, virtuals: true }
    }
)

export interface IUserDocument extends Document {
    articleIds: IArticleDocument['_id'];
};

export const userModel: Model<IUserDocument> = model<IUserDocument>(
    USER_MODEL,
    UserSchema,
    USER_COLLECTION
);