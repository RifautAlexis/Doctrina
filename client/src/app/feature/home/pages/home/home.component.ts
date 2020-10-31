import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SearchArticleBloc } from '@core/blocs/search-article.bloc';
import { ArticleService } from '@core/services/article.service';
import { Status } from '@shared/enum';
import { IArticle } from '@shared/models/article.model';
import { IArticlesResponse } from '@shared/responses/articles.response';
import { BehaviorSubject, Observable, of } from 'rxjs';
import { map, tap } from 'rxjs/operators';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  response$: Observable<IArticlesResponse> = of({status: Status.PENDING, data: []});
  Status = Status;

  constructor(
    private articleService: ArticleService
  ) { }

  ngOnInit(): void {
    this.response$ = this.articleService.getArticles();
  }

}
