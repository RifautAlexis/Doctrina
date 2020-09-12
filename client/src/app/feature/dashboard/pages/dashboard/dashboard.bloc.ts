import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject } from 'rxjs';
// import { IArticle } from '@shared/models/article.model';
// import { ArticleService } from '@core/services/article.service';
// import { IArticleResponse } from '@shared/responses/article.response';

@Injectable({
    providedIn: 'root'
})
export class DashboardBloc {

    // private _articleFetcher$ = new BehaviorSubject<IArticle>(null);
    // get article$(): Observable<IArticle> {
    //     return this._articleFetcher$.asObservable();
    // }

    constructor() {  }
    // constructor(private articleService: ArticleService) {  }

    // getById(articleId: number): void {
    //     this.articleService.getArticle(articleId)
    //         .subscribe((response: IArticleResponse) => {this._articleFetcher$.next(response.article as IArticle)});
    // }

    // dispose() {
    //     this._articleFetcher$.complete();
    // }
}