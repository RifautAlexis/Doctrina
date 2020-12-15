import { Component, OnInit } from '@angular/core';
import { ArticleService } from '@core/services/article.service';
import { ReadingListService } from '@core/services/reading-list.service';
import { Article } from '@shared/models/article.model';
import { ReadingListForm } from '@shared/models/reading-list-form.model';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-reading-list-add',
  templateUrl: './reading-list-add.component.html',
  styleUrls: ['./reading-list-add.component.scss']
})
export class ReadingListAddComponent implements OnInit {

  articles$: Observable<Article[]>;

  constructor(
    private readonly readingListService: ReadingListService,
    private readonly articleService: ArticleService,
  ) { }

  ngOnInit(): void {
    this.articles$ = this.articleService.getArticles();
  }

  createReadingList(newReadingList: ReadingListForm) {
    this.readingListService.createReadingList({ ...newReadingList });
  }
}
