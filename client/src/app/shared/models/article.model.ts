import { Tag } from "./tag.model";
import { User } from './user.model';

export interface Article {
    id: string
    title: string;
    content: string;
    description: string;
    author: User;
    tags: Tag[];
    createdAt: Date;
    updatedAt: Date;
}