import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { ArticleService } from '@core/services/article.service';
import { Observable, of } from 'rxjs';

import { COMMA, ENTER } from '@angular/cdk/keycodes';
import { ElementRef, ViewChild } from '@angular/core';
import { MatAutocomplete } from '@angular/material/autocomplete';
import { ITag } from '@shared/models/tag.model';
import { Router } from '@angular/router';
import { IArticleEdit } from '@shared/models/article-edit.model';
import { IIdResponse } from '@shared/responses/id.response';
import { IArticleForm } from '@shared/models/article-form.model';

@Component({
  selector: 'app-write-article',
  templateUrl: './write-article.component.html',
  styleUrls: ['./write-article.component.scss']
})
export class WriteArticleComponent implements OnInit {

  contentPreview: string;
  article: IArticleForm;

  public articleForm: FormGroup
  
  tags: ITag[] = [];
  separatorKeysCodes: number[] = [ENTER, COMMA];
  tagCtrl = new FormControl();
  filteredTags: Observable<ITag[]>;
  tagsSelected: ITag[] = [];

  @ViewChild('tagInput') tagInput: ElementRef<HTMLInputElement>;
  @ViewChild('auto') matAutocomplete: MatAutocomplete;

  constructor(
    public formBuilder: FormBuilder,
    // private router: Router,
    private articleService: ArticleService
  ) { }

  ngOnInit(): void { }

  createArticle(articleToAdd: IArticleEdit){
    this.articleService.createArticle(articleToAdd).subscribe((response: IIdResponse) => {
      // Snackbar
    })
  }

  onChangeContent($event: string) {
    this.contentPreview = $event;
  }
}
