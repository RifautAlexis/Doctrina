import { User, Tag } from ".";
import { BaseEntity } from "./base-entity";

export interface Article extends BaseEntity {
    title: string;
    content: string;
    description: string;
    author: User;
    tags: Tag[];
    createdAt: Date;
    updateAt?: Date;
}