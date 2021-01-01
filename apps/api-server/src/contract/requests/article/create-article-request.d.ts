import { CreateArticleDTO } from "../../DTOs";

export interface CreateArticleRequest extends IRequest{
    newArticle: CreateArticleDTO;
}