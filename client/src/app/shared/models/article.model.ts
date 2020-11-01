import { ITag } from "./tag.model";
import { IUser } from './user.model';

export interface IArticle {
    id: number
    title: string;
    content: string;
    description: string;
    author: IUser;
    tags: ITag[];
    createdAt: Date;
    updatedAt: Date;
}