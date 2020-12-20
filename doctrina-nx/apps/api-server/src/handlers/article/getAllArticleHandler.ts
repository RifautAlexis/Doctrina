import { GetAllArticleRequest } from "../../requests/article/getAllArticleRequest";
import { ArticlesResponse } from "../../responses/article/articlesResponse";
import { Handler } from "../handler";
import container from "../handlerContainer";

export class GetAllArticleHandler implements Handler<GetAllArticleRequest, ArticlesResponse> {

    async Handle(request: GetAllArticleRequest): Promise<ArticlesResponse> {
        return {data: ["Coucou", "toi"]};
    }   
}
