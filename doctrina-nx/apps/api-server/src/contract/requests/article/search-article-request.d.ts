import { IRequest } from "../request";

export interface SearchArticleRequest extends IRequest {
    toSearch: string;
}