import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ArticleService } from '@core/services/article.service';
import { Status } from '@shared/enum';
import { Article } from '@shared/models/article.model';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-article',
  templateUrl: './article.component.html',
  styleUrls: ['./article.component.scss']
})
export class ArticleComponent implements OnInit {

  private articleId: string;
  article$: Observable<Article>;
  Status = Status;

  constructor(
    private activatedRoute: ActivatedRoute,
    private articleService: ArticleService
  ) { }

  ngOnInit(): void {
    this.articleId = this.activatedRoute.snapshot.paramMap.get("id");
    this.article$ = this.articleService.getArticle(this.articleId);
  }

}
