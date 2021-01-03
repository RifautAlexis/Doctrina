import { GetAllArticleRequest } from "../../contract/requests/article/get-all-article-request";
import { Handler } from "../handler";
import { ArticlesResponse } from "../../../../../libs/responses/index";
import { Article, User } from "../../../../../libs/models/index";

export class GetAllArticleHandler implements Handler<GetAllArticleRequest, ArticlesResponse> {

    async Handle(request: GetAllArticleRequest): Promise<ArticlesResponse> {
        request;
        return {
            data: [
                {
                    id: "1",
                    title: "title01",
                    content: "content01",
                    description: "description01",
                    author: {} as User,
                    tags: [],
                    createdAt: {} as Date,
                } as Article,
                {
                    id: "2",
                    title: "title02",
                    content: "content02",
                    description: "description02",
                    author: {} as User,
                    tags: [],
                    createdAt: {} as Date,
                } as Article]
        };
    }
}
