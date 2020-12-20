import { GetArticleByIdRequest } from "../../requests/article/getArticleByIdRequest";
import { ArticleResponse } from "../../responses/article/articleResponse";
import { Handler } from "../handler";

export class GetArticleByIdHandler implements Handler<GetArticleByIdRequest, ArticleResponse> {

    async Handle(request: GetArticleByIdRequest): Promise<ArticleResponse> {
        request;
        return {data: "Coucou"};
    }   
}
