import { environment } from '../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ArticlesResponse } from '@shared/responses/articles.response';
import { ArticleResponse } from '@shared/responses/article.response';
import { BooleanResponse } from '@shared/responses/boolean.response';
import { IdResponse } from '@shared/responses/id.response';
import { ArticleCreate } from '@shared/models/article-create.model';
import { map } from 'rxjs/operators';
import { Article } from '@shared/models/article.model';
import { ArticleEdit } from '@shared/models/article-edit.model';

@Injectable({
  providedIn: 'root'
})
export class ArticleService {

  constructor(private http: HttpClient) { }

  getArticles(): Observable<Article[]> {
    return this.http.get<ArticlesResponse>(environment.apiUrl + 'article')
      .pipe(
        map((response: ArticlesResponse) => {
          return response.data;
        })
      );
  }

  getArticle(articleId: string): Observable<Article> {
    return this.http.get<ArticleResponse>(environment.apiUrl + 'article/' + articleId)
    .pipe(
      map((response: ArticleResponse) => {
        return response.data;
      })
    );
  }

  isUniqueTitle(title: string, articleId?: string): Observable<boolean> {
    return this.http.post<BooleanResponse>(environment.apiUrl + 'article/isUniqueTitle', {
      "title": title,
      "articleId": articleId
    })
      .pipe(
        map((response: BooleanResponse) => {
          return response.data;
        })
      );
  }

  createArticle(articleToAdd: ArticleCreate): Observable<number> {
    return this.http.post<IdResponse>(environment.apiUrl + 'article', articleToAdd)
      .pipe(
        map((response: IdResponse) => {
          return response.data;
        })
      );
  }

  editArticle(articleToEdit: ArticleEdit): Observable<number> {
    return this.http.put<IdResponse>(environment.apiUrl + 'article/' + articleToEdit.id, articleToEdit)
      .pipe(
        map((response: IdResponse) => {
          return response.data;
        })
      );
  }

  delete(articleId: string): Observable<boolean> {
    return this.http.delete<BooleanResponse>(environment.apiUrl + 'article/' + articleId)
    .pipe(
      map((response: BooleanResponse) => {
        return response.data;
      })
    );
  }

}