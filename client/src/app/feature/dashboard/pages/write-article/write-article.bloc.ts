import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject } from 'rxjs';
import { IArticle } from '@shared/models/article.model';
import { ArticleService } from '@core/services/article.service';
import { IArticlesResponse } from '@shared/responses/articles.response';
import { IArticleCreate } from '@shared/models/article-create.model';

@Injectable({
    providedIn: 'root'
})
export class WriteArticleBloc {

    constructor(private articleService: ArticleService) { }

    createArticle(articleCreate: IArticleCreate): Observable<number> {
        console.log("BLOC");
        return this.articleService.createArticle(articleCreate);
    }
}