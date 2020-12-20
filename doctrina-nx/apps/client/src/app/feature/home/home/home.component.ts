import { Component, OnInit } from '@angular/core';
import { ArticleService } from '@core/services/article.service';
import { Status } from '@shared/enum';
import { Article } from '@shared/models/article.model';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  articles$: Observable<Article[]>;
  Status = Status;

  constructor(
    private articleService: ArticleService
  ) { }

  ngOnInit(): void {
    this.articles$ = this.articleService.getArticles();
  }

}
