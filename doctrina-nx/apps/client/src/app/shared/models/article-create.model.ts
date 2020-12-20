export interface ArticleCreate {
    title: string;
    content: string;
    description: string;
    tagIds: number[];
}