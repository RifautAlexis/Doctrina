import { GetAllArticleRequest } from "../../requests/article/getAllArticleRequest";
import { ArticlesResponse } from "../../responses/article/articlesResponse";
import { Handler } from "../handler";

export class GetAllArticleHandler implements Handler<GetAllArticleRequest, ArticlesResponse> {

    async Handle(request: GetAllArticleRequest): Promise<ArticlesResponse> {
        request;
        return {data: ["Coucou", "toi"]};
    }   
}
