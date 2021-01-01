import { BaseEntity } from "./base-entity";

export interface ReadingList extends BaseEntity {
    name: string;
    description: string;
    articleIds: string[];
}