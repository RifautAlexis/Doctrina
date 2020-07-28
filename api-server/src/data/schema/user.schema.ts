import * as mongoose from "mongoose";

export const userSchema = new mongoose.Schema(
    {
        userId: {
            type: String,
            required: true,
            unique: true
        },
        articleIds: {
            type: [String],
            required: false
        }
    }
)