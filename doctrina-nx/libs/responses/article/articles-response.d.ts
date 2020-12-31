import { IResponse } from "../response";
import { Article } from "../../models/index";

export interface ArticlesResponse extends IResponse {
    data: Article[];
}