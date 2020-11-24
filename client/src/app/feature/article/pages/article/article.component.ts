import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ArticleService } from '@core/services/article.service';
import { Status } from '@shared/enum';
import { IArticle } from '@shared/models/article.model';
import { IArticleResponse } from '@shared/responses/article.response';
import { Observable, of } from 'rxjs';

@Component({
  selector: 'app-article',
  templateUrl: './article.component.html',
  styleUrls: ['./article.component.scss']
})
export class ArticleComponent implements OnInit {

  private articleId: number;
  response$: Observable<IArticleResponse> = of({status: Status.PENDING, data: {} as IArticle});
  Status = Status;

  constructor(
    private activatedRoute: ActivatedRoute,
    private articleService: ArticleService
  ) { }

  ngOnInit(): void {
    this.articleId = parseInt(this.activatedRoute.snapshot.paramMap.get("id"));
    this.response$ = this.articleService.getArticle(this.articleId);
  }

}
