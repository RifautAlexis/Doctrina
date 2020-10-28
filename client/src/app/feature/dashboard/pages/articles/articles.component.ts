import { Component, OnInit } from '@angular/core';
import { IArticle } from '@shared/models/article.model';
import { Observable } from 'rxjs';
import { ArticlesBloc } from './articles.bloc';

@Component({
  selector: 'app-articles',
  templateUrl: './articles.component.html',
  styleUrls: ['./articles.component.scss']
})
export class ArticlesComponent implements OnInit {

  get articles$(): Observable<IArticle[]> {
    return this.articlesBloc.articles$;
  };

  constructor(
    private articlesBloc: ArticlesBloc
  ) {  }

  ngOnInit(): void {
    this.articlesBloc.getAll();
  }

  ngOnDestroy(): void {
    this.articlesBloc.dispose();
  }
}
