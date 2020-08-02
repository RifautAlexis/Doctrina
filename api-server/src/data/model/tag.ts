import { Model, Schema, Document, model } from 'mongoose';
import { TAG_MODEL, TAG_COLLECTION } from '../data.constants';

export const TagSchema = new Schema(
    {
        name: {
            type: String,
            required: true,
            unique: true
        }
    },
    {
        id: true,
        timestamps: true,
        toJSON: { getters: true, virtuals: true },
        toObject: { getters: true, virtuals: true }
    }
)

export interface ITagDocument extends Document {
    name: String;
};

export const tagModel: Model<ITagDocument> = model<ITagDocument>(
    TAG_MODEL,
    TagSchema,
    TAG_COLLECTION
);