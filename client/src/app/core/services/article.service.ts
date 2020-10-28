import { environment } from '../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IArticlesResponse } from '@shared/responses/articles.response';
import { IArticleResponse } from '@shared/responses/article.response';
import { IBooleanResponse } from '@shared/responses/boolean.response';
import { IIdResponse } from '@shared/responses/id.response';
import { IArticleCreate } from '@shared/models/article-create.model';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ArticleService {

  constructor(private http: HttpClient) { }

  search(toSearch: string = ''): Observable<IArticlesResponse> {
    return this.http.get<IArticlesResponse>(environment.apiUrl + 'article/search/' + toSearch);
  }

  getArticle(articleId: number): Observable<IArticleResponse> {
    return this.http.get<IArticleResponse>(environment.apiUrl + 'article/' + articleId);
  }

  getAll(): Observable<IArticlesResponse> {
    return this.http.get<IArticlesResponse>(environment.apiUrl + 'article');
  }

  createArticle(newArticle: IArticleCreate): Observable<number> {
    console.log("SERVICE");
    const test: Observable<any> = this.http.post<IIdResponse>(environment.apiUrl + 'article/createArticle', newArticle);
    test.subscribe((lol: any) => console.log(lol));
    return test;
  }

  isUniqueTitleValidator(title: string): Observable<boolean> {
    return this.http.post<IBooleanResponse>(environment.apiUrl + 'article/isUniqueTitle', JSON.stringify(title), { headers: new HttpHeaders({'Content-Type': 'application/json'})})
      .pipe(
        map((response: IBooleanResponse) => response.response)
      );
  }

}