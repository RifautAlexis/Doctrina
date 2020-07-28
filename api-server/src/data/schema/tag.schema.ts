import * as mongoose from "mongoose";

export const tagSchema = new mongoose.Schema(
    {
        tagId: {
            type: String,
            required: true,
            unique: true
        },
        name: {
            type: String,
            required: true,
            unique: true
        }
    }
)