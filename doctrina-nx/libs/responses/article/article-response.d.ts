import { IResponse } from "../response";
import { Article } from "../../models/index";

export interface ArticleResponse extends IResponse {
    data: Article;
}