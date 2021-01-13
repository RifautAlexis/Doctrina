import {
  Param,
  Get,
  JsonController,
  Post,
  Put,
  Delete,
} from 'routing-controllers';
import executor from '../handlers/executor';
import {
  ArticleResponse,
  ArticlesResponse,
  BooleanResponse,
  IdResponse,
} from '../../../../libs/responses';
import {
  CreateArticleRequest,
  DeleteArticleRequest,
  EditArticleRequest,
  GetAllArticleRequest,
  GetArticleByIdRequest,
  IsUniqueTitleRequest,
  SearchArticleRequest,
} from '../contract/requests';

@JsonController()
export class ArticleController {
  @Get('/search')
  async search(request: SearchArticleRequest) {
    return await executor.Execute<SearchArticleRequest, ArticlesResponse>(
      nameof<SearchArticleRequest>(),
      request
    );
  }

  @Get('/:id')
  async getById(@Param('id') request: GetArticleByIdRequest) {
    return await executor.Execute<GetArticleByIdRequest, ArticleResponse>(
      nameof<GetArticleByIdRequest>(),
      request
    );
  }

  @Get('/')
  async get() {
    return 'CI worked 17!';
  }

  // @Get("/")
  // async get(request: GetAllArticleRequest) {
  //    return await executor.Execute<GetAllArticleRequest, ArticlesResponse>(nameof<GetAllArticleRequest>(), request);
  // }

  @Post('/isUniqueTitle')
  async IsUniqueTitleRequest(request: IsUniqueTitleRequest) {
    return await executor.Execute<IsUniqueTitleRequest, BooleanResponse>(
      nameof<IsUniqueTitleRequest>(),
      request
    );
  }

  @Post('/')
  async Create(request: CreateArticleRequest) {
    return await executor.Execute<CreateArticleRequest, IdResponse>(
      nameof<CreateArticleRequest>(),
      request
    );
  }

  @Put('/:id')
  async Edit(request: EditArticleRequest) {
    return await executor.Execute<EditArticleRequest, IdResponse>(
      nameof<EditArticleRequest>(),
      request
    );
  }

  @Delete('/:id')
  async Delete(request: DeleteArticleRequest) {
    return await executor.Execute<DeleteArticleRequest, BooleanResponse>(
      nameof<DeleteArticleRequest>(),
      request
    );
  }
}
