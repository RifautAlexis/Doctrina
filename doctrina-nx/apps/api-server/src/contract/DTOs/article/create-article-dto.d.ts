export interface CreateArticleDTO {
    title: string;
    content: string;
    description: string;
    tagIds: string[];
    readingListIds: string[];
}