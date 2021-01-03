import { GetArticleByIdRequest } from "../../contract/requests/article/get-article-by-id-request";
import { Handler } from "../handler";
import { ArticleResponse } from "../../../../../libs/responses/index";
import { User } from "../../../../../libs/models/index";

export class GetArticleByIdHandler implements Handler<GetArticleByIdRequest, ArticleResponse> {

    async Handle(request: GetArticleByIdRequest): Promise<ArticleResponse> {
        request;
        return {
            data: {
                id: "1",
                title: "title01",
                content: "content01",
                description: "description01",
                author: {} as User,
                tags: [],
                createdAt: {} as Date,
            }
        } as ArticleResponse;
    }
}
