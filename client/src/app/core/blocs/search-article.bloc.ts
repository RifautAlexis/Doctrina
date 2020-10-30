import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject } from 'rxjs';
import { IArticle } from '@shared/models/article.model';
import { ArticleService } from '@core/services/article.service';
import { IArticlesResponse } from '@shared/responses/articles.response';

@Injectable({
    providedIn: 'root'
})
export class SearchArticleBloc {

    private _articlesFetcher$ = new BehaviorSubject<IArticle[]>([]);
    get articles$(): Observable<IArticle[]> {
        return this._articlesFetcher$.asObservable();
    }

    constructor(private articleService: ArticleService) { }

    dispose() {
        this._articlesFetcher$.complete();
    }

    search(toSearch?: string): void {
    //     this.articleService.search(toSearch)
    //         .subscribe((response: IArticlesResponse) => { this._articlesFetcher$.next(response.articles as IArticle[]) });
    }
}