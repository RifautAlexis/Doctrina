import { Component, OnInit } from '@angular/core';
import { ArticleService } from '@core/services/article.service';
import { Status } from '@shared/enum';
import { Article } from '@shared/models/article.model';
import { Observable, of } from 'rxjs';
// import { Snackbar } from 'src/app/components/snackbar/custom-snackbar.component';

@Component({
  selector: 'app-articles',
  templateUrl: './articles.component.html',
  styleUrls: ['./articles.component.scss']
})
export class ArticlesComponent implements OnInit {
  articles$: Observable<Article[]>;
  Status = Status;

  constructor(
    private articleService: ArticleService,
    // private snackbar: Snackbar
  ) { }

  ngOnInit(): void {
    this.articles$ = this.articleService.getArticles();
  }

  deleteArticle(articleId: string) {
    this.articleService.delete(articleId).subscribe((hasBeenDeleted: boolean) => {
      // if(response.data) this.snackbar.openSnackBarSuccess("Article has been successful deleted");
    });
  }
}
