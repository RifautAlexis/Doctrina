import { Controller, Param, Body, Get, Post, Put, Delete, JsonController } from "routing-controllers";
import { GetAllArticleRequest } from "../requests/article/getAllArticleRequest";
import { GetArticleByIdRequest } from "../requests/article/getArticleByIdRequest";
import { ArticleResponse } from "../responses/article/articleResponse";
import { ArticlesResponse } from "../responses/article/articlesResponse";
import executor from "../handlers/executor";

@JsonController()
export class ArticleController {

   @Get("/articles")
   async get(request: GetAllArticleRequest) {
      return await executor.Execute<GetAllArticleRequest, ArticlesResponse>(nameof<GetAllArticleRequest>(), request);
   }

   @Get("/articles/:id")
   async getById(@Param("id") request: GetArticleByIdRequest) {
      return await executor.Execute<GetArticleByIdRequest, ArticleResponse>(nameof<GetArticleByIdRequest>(), request);
   }

   // @Post("/articles")
   // post(@Body() article: any) {
   //    return "Saving article...";
   // }

   // @Put("/articles/:id")
   // put(@Param("id") id: number, @Body() article: any) {
   //    return "Updating a article...";
   // }

   // @Delete("/articles/:id")
   // remove(@Param("id") id: number) {
   //    return "Removing article...";
   // }

}