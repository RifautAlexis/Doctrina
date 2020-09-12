import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ArticleBloc } from '@core/blocs/article.bloc';
import { ArticleService } from '@core/services/article.service';
import { IArticle } from '@shared/models/article.model';
import { IArticleResponse } from '@shared/responses/article.response';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-article',
  templateUrl: './article.component.html',
  styleUrls: ['./article.component.scss']
})
export class ArticleComponent implements OnInit {

  private articleId: number;
  public article: IArticle;
  get article$(): Observable<IArticle> {
    return this.articleBloc.article$;
  }

  constructor(
    private activatedRoute: ActivatedRoute,
    private articleBloc: ArticleBloc
  ) { }

  ngOnInit(): void {
    this.articleId = parseInt(this.activatedRoute.snapshot.paramMap.get("id"));
    this.articleBloc.getById(this.articleId);
  }

  ngOnDestroy() {
    this.articleBloc.dispose();
  }

}
