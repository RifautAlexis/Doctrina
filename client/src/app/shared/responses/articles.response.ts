import { IArticle } from '@shared/models/article.model';
import { IResponse } from '@shared/responses/response';

export interface IArticlesResponse extends IResponse {
    data: IArticle[],
}