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

@Injectable({
  providedIn: 'root'
})
export class ArticleService {

  constructor(private http: HttpClient) { }

  getArticles(): Observable<IArticlesResponse> {
    return this.http.get<IArticlesResponse>(environment.apiUrl + 'article');
  }

  getArticle(articleId: number): Observable<IArticle> {
    return this.http.get<IArticleResponse>(environment.apiUrl + 'article/' + articleId)
    .pipe(
      map((response: IArticleResponse) => response.article)
    );
  }

  isUniqueTitle(title: string): Observable<boolean> {
    return this.http.post<IBooleanResponse>(environment.apiUrl + 'article/isUniqueTitle', JSON.stringify(title), { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) })
      .pipe(
        map((response: IBooleanResponse) => response.response)
      );
  }

  createArticle(newArticle: IArticleCreate): Observable<number> {
    return this.http.post<IIdResponse>(environment.apiUrl + 'article/createArticle', newArticle)
      .pipe(
        map((response: IIdResponse) => response.id)
      );
  }

}