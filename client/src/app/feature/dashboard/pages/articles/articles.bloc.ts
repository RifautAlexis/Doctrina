import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject } from 'rxjs';
import { IArticle } from '@shared/models/article.model';
import { ArticleService } from '@core/services/article.service';
import { IArticlesResponse } from '@shared/responses/articles.response';

@Injectable({
    providedIn: 'root'
})
export class ArticlesBloc {

    private _articlesFetcher$ = new BehaviorSubject<IArticle[]>([]);
    get articles$(): Observable<IArticle[]> {
        return this._articlesFetcher$.asObservable();
    }

    constructor(private articleService: ArticleService) { }

    getAll(): void {
        this.articleService.getAll()
            .subscribe((response: IArticlesResponse) =>
                this._articlesFetcher$.next(response.articles as IArticle[])
            );
    }

    dispose() {
        this._articlesFetcher$.complete();
    }
}