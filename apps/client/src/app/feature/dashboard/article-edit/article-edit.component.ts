import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ArticleService } from '@core/services/article.service';
import { ArticleEdit } from '@shared/models/article-edit.model';
import { Article } from '@shared/models/article.model';
import { Observable } from 'rxjs';

@Component({
  selector: 'edit-article',
  templateUrl: './article-edit.component.html',
  styleUrls: ['./article-edit.component.scss']
})
export class ArticleEditComponent implements OnInit {

  article$: Observable<Article>;
  articleId: string;
  contentPreview: string;

  constructor(
    private readonly articleService: ArticleService,
    private readonly activatedRoute: ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.articleId = this.activatedRoute.snapshot.paramMap.get("id");
    this.article$ = this.articleService.getArticle(this.articleId);
  }

  editArticle(articleToEdit: ArticleEdit) {
    this.articleService.editArticle(articleToEdit).subscribe((articleId: number) => {
      articleId;
      // Snackbar
    })
  }

  onChangeContent($event: string) {
    this.contentPreview = $event;
  }
}
