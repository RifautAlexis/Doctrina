import { IArticle } from '@shared/models/article.model';
import { IResponse } from './response';

export interface IArticleResponse extends IResponse {
    data: IArticle;
}