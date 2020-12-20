import Koa from "koa";
import bodyParser from "koa-bodyparser";
// import cors from "koa2-cors";
import logger from "koa-logger";
import { useKoaServer } from "routing-controllers";
import { config } from "./config";
import { ArticleController } from "./controllers/article.controller";
// import router from "./routes"
import "reflect-metadata"
import container from "./handlers/handlerContainer";
import { GetAllArticleRequest } from "./requests/article/getAllArticleRequest";
import { ArticlesResponse } from "./responses/article/articlesResponse";
import { GetAllArticleHandler } from "./handlers/article/getAllArticleHandler";
import { GetArticleByIdRequest } from "./requests/article/getArticleByIdRequest";
import { ArticleResponse } from "./responses/article/articleResponse";
import { GetArticleByIdHandler } from "./handlers/article/getArticleByIdHandler";

const app = new Koa();

const PORT = config.port;

// app.use(router.routes());

app.use(bodyParser());
// app.use(
//   cors({
//     origin: "*"
//   })
// );
app.use(logger());

let handler01 = new GetAllArticleHandler();
let handler02 = new GetArticleByIdHandler();
container.RegisterHandler<GetAllArticleRequest, ArticlesResponse>(nameof<GetAllArticleRequest>(), handler01);
container.RegisterHandler<GetArticleByIdRequest, ArticleResponse>(nameof<GetArticleByIdRequest>(), handler02);

useKoaServer(app, {
    controllers: [ArticleController], // and configure it the way you need (controllers, validation, etc.)
    // classTransformer: true,
});

const server = app
    .listen(PORT, async () => {
        console.log(`Server listening on localhost:${PORT}`);
    })
    .on("error", (err: any) => {
        console.error(err);
    });

export default server;