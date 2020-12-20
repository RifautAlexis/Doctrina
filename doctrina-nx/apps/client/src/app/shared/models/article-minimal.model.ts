import { User } from './user.model';

export interface ArticleMinimal {
    id: string;
    title: string;
    description: string;
    authorName: User;
    createdAt: Date;
    updatedAt: Date;
}