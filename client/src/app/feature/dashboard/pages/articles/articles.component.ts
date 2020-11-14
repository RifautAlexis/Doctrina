import { Component, OnInit } from '@angular/core';
import { ArticleService } from '@core/services/article.service';
import { Status } from '@shared/enum';
import { IArticlesResponse } from '@shared/responses/articles.response';
import { IBooleanResponse } from '@shared/responses/boolean.response';
import { Observable, of } from 'rxjs';
import { Snackbar } from 'src/app/components/snackbar/custom-snackbar.component';

@Component({
  selector: 'app-articles',
  templateUrl: './articles.component.html',
  styleUrls: ['./articles.component.scss']
})
export class ArticlesComponent implements OnInit {
  response$: Observable<IArticlesResponse> = of({status: Status.PENDING, data: []});
  Status = Status;

  constructor(
    private articleService: ArticleService,
    // private snackbar: Snackbar
  ) { }

  ngOnInit(): void {
    this.response$ = this.articleService.getArticles();
  }

  deleteArticle(articleId: string) {
    this.articleService.delete(articleId).subscribe((response: IBooleanResponse) => {
      // if(response.data) this.snackbar.openSnackBarSuccess("Article has been successful deleted");
    });
  }
}
