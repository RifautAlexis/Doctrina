import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IArticle } from '@shared/models/article.model';
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
    // return this.articleBloc.article$;
    return null;
  }

  constructor(
    private activatedRoute: ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.articleId = parseInt(this.activatedRoute.snapshot.paramMap.get("id"));
    // this.articleBloc.getById(this.articleId);
  }

  ngOnDestroy() {
    // this.articleBloc.dispose();
  }

}
