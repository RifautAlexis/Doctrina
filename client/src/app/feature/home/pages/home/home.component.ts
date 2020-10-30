import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SearchArticleBloc } from '@core/blocs/search-article.bloc';
import { ArticleService } from '@core/services/article.service';
import { Status } from '@shared/enum';
import { IArticle } from '@shared/models/article.model';
import { IArticlesResponse } from '@shared/responses/articles.response';
import { BehaviorSubject, Observable } from 'rxjs';
import { map, tap } from 'rxjs/operators';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  private _articlesFetcher$ = new BehaviorSubject<IArticle[]>([]);
  get articles$(): Observable<IArticle[]> {
    return this._articlesFetcher$.asObservable();
  }

  private _articlesStatus$ = new BehaviorSubject<Status>(Status.PENDING);
  get articlesStatus$(): Observable<Status> {
    return this._articlesStatus$.asObservable();
  }

  isPending: boolean;
  hasError: boolean;
  hasResult: boolean;

  status = Status;

  constructor(
    private articleService: ArticleService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.getArticles();
  }

  ngOnDestroy() {
    this._articlesFetcher$.unsubscribe();
  }

  getArticles() {
    this._articlesStatus$.next(Status.PENDING);
    
    this.articleService.getArticles()
      .subscribe((response: IArticlesResponse) => {
        this._articlesFetcher$.next(response.articles);
        this._articlesStatus$.next(Status.SUCCESSFUL);
      }
    );
  }

  goToArticle(articleId: number) {
    this.router.navigate(['article/', articleId]);
  }

}
