import { IResponse } from "../response";

export interface ArticlesResponse extends IResponse {
    data: string[];
}