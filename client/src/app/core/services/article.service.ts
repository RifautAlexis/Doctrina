import { environment } from '../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IArticlesResponse } from '@shared/responses/articles.response';
import { IArticleResponse } from '@shared/responses/article.response';
import { IBooleanResponse } from '@shared/responses/boolean.response';
import { IIdResponse } from '@shared/responses/id.response';
import { IArticleCreate } from '@shared/models/article-create.model';
import { map, tap } from 'rxjs/operators';
import { IArticle } from '@shared/models/article.model';
import { Status } from '@shared/enum';
import { IArticleEdit } from '@shared/models/article-edit.model';

@Injectable({
  providedIn: 'root'
})
export class ArticleService {

  constructor(private http: HttpClient) { }

  getArticles(): Observable<IArticlesResponse> {
    return this.http.get<IArticlesResponse>(environment.apiUrl + 'article')
      .pipe(
        map((response: IArticlesResponse) => {
          return {status: Status.SUCCESSFUL, data: response.data};
        })
      );
  }

  getArticle(articleId: string): Observable<IArticleResponse> {
    return this.http.get<IArticleResponse>(environment.apiUrl + 'article/' + articleId)
    .pipe(
      map((response: IArticleResponse) => {
        return {status: Status.SUCCESSFUL, data: response.data};
      })
    );
  }

  isUniqueTitle(title: string, articleId?: string): Observable<IBooleanResponse> {
    return this.http.post<IBooleanResponse>(environment.apiUrl + 'article/isUniqueTitle', {
      "title": title,
      "articleId": articleId
    })
      .pipe(
        map((response: IBooleanResponse) => {
          return {status: Status.SUCCESSFUL, data: response.data};
        })
      );
  }

  createArticle(articleToAdd: IArticleCreate): Observable<IIdResponse> {
    return this.http.post<IIdResponse>(environment.apiUrl + 'article', articleToAdd)
      .pipe(
        map((response: IIdResponse) => {
          return {status: Status.SUCCESSFUL, data: response.data};
        })
      );
  }

  editArticle(articleToEdit: IArticleEdit): Observable<IIdResponse> {
    return this.http.put<IIdResponse>(environment.apiUrl + 'article/' + articleToEdit.id, articleToEdit)
      .pipe(
        map((response: IIdResponse) => {
          return {status: Status.SUCCESSFUL, data: response.data};
        })
      );
  }

  delete(articleId: string): Observable<IBooleanResponse> {
    return this.http.delete<IBooleanResponse>(environment.apiUrl + 'article/' + articleId)
    .pipe(
      map((response: IBooleanResponse) => {
        return {status: Status.SUCCESSFUL, data: response.data};
      })
    );
  }

}