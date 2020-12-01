import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ArticleService } from '@core/services/article.service';
import { Status } from '@shared/enum';
import { IArticleEdit } from '@shared/models/article-edit.model';
import { IArticle } from '@shared/models/article.model';
import { IArticleResponse } from '@shared/responses/article.response';
import { IIdResponse } from '@shared/responses/id.response';
import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-edit-article',
  templateUrl: './edit-article.component.html',
  styleUrls: ['./edit-article.component.scss']
})
export class EditArticleComponent implements OnInit {

  article$: Observable<IArticleResponse> = of({status: Status.PENDING, data: null});
  articleId: string;
  contentPreview: string;

  constructor(
    private articleService: ArticleService,
    private activatedRoute: ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.articleId = this.activatedRoute.snapshot.paramMap.get("id");
    this.article$ = this.articleService.getArticle(this.articleId);
  }

  editArticle(articleToEdit: IArticleEdit) {
    this.articleService.editArticle(articleToEdit).subscribe((response: IIdResponse) => {
      // Snackbar
    })
  }

  onChangeContent($event: string) {
    this.contentPreview = $event;
  }
}
