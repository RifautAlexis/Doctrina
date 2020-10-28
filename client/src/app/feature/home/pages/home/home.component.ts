import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SearchArticleBloc } from '@core/blocs/search-article.bloc';
import { IArticle } from '@shared/models/article.model';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  get articles$(): Observable<IArticle[]> {
    return this.searchArticleBloc.articles$;
  };

  constructor(
    private searchArticleBloc: SearchArticleBloc,
    private router: Router
  ) {  }

  ngOnInit(): void {
    this.searchArticleBloc.search();
  }

  ngOnDestroy() {
    this.searchArticleBloc.dispose();
  }

  goToArticle(articleId: number) {
    this.router.navigate(['article/', articleId]);
  }

}
