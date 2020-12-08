import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ArticleService } from '@core/services/article.service';
import { Status } from '@shared/enum';
import { ArticleEdit } from '@shared/models/article-edit.model';
import { Article } from '@shared/models/article.model';
import { ArticleResponse } from '@shared/responses/article.response';
import { IdResponse } from '@shared/responses/id.response';
import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-edit-article',
  templateUrl: './edit-article.component.html',
  styleUrls: ['./edit-article.component.scss']
})
export class EditArticleComponent implements OnInit {

  article$: Observable<Article>;
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

  editArticle(articleToEdit: ArticleEdit) {
    this.articleService.editArticle(articleToEdit).subscribe((articleId: number) => {
      // Snackbar
    })
  }

  onChangeContent($event: string) {
    this.contentPreview = $event;
  }
}
