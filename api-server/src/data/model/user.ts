import { Model, Schema, Document, model } from 'mongoose';
import { USER_MODEL, USER_COLLECTION } from '../data.constants';

export const UserSchema = new Schema(
    {
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
    articleIds: String;
};

export const userModel: Model<IUserDocument> = model<IUserDocument>(
    USER_MODEL,
    UserSchema,
    USER_COLLECTION
);