import { EditArticleDTO } from "../../DTOs";

export interface EditArticleRequest extends IRequest{
    articleToEdit: EditArticleDTO
}