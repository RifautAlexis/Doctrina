import * as mongoose from "mongoose";

export const articleSchema = new mongoose.Schema(
    {
        articleId: {
            type: String,
            required: true,
            unique: true
        },
        authorId: {
            type: [String],
            required: false
        },
        content: {
            type: String,
            required: true
        },
        tagIds: {
            type: [String],
            required: true
        },
        createdAt: {
            type: Date,
            required: true
        }
    }
)