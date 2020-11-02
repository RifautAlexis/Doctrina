import { Component, OnInit } from '@angular/core';
import { ArticleService } from '@core/services/article.service';
import { Status } from '@shared/enum';
import { IArticle } from '@shared/models/article.model';
import { IArticlesResponse } from '@shared/responses/articles.response';
import { Observable, of } from 'rxjs';

@Component({
  selector: 'app-articles',
  templateUrl: './articles.component.html',
  styleUrls: ['./articles.component.scss']
})
export class ArticlesComponent implements OnInit {
  response$: Observable<IArticlesResponse> = of({status: Status.PENDING, data: []});
  Status = Status;

  constructor(
    private articleService: ArticleService
  ) { }

  ngOnInit(): void {
    this.response$ = this.articleService.getArticles();
  }
}
