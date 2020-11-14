import { COMMA, ENTER } from '@angular/cdk/keycodes';
import { Component, ElementRef, EventEmitter, Input, OnInit, Output, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatAutocomplete, MatAutocompleteSelectedEvent } from '@angular/material/autocomplete';
import { Router } from '@angular/router';
import { TagService } from '@core/services/tag.service';
import { IArticleCreate } from '@shared/models/article-create.model';
import { IArticleEdit } from '@shared/models/article-edit.model';
import { IArticle } from '@shared/models/article.model';
import { ITag } from '@shared/models/tag.model';
import { ITagsResponse } from '@shared/responses/tags.response';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ArticleValidator } from '@shared/validators/article.validator';

@Component({
  selector: 'add-edit-article',
  templateUrl: './add-edit-article.component.html'
})

export class AddEditArticleComponent implements OnInit {

  @Input() articleToEdit: IArticle;
  @Output() articleToAddEvent = new EventEmitter<IArticleCreate>();
  @Output() articleToEditEvent = new EventEmitter<IArticleEdit>();

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
    private router: Router,
    private articleValidator: ArticleValidator,
    private tagService: TagService
  ) {
    this.filteredTags = this.tagCtrl.valueChanges.pipe(
      map((tag: ITag) => tag ? this._filter(tag) : this.tags.slice()));
  }

  ngOnInit(): void {
    this.tagService.getTags().subscribe((response: ITagsResponse) => {
      this.tags = response.data;
    });
    this.buildArticleForm();
  }

  submit() {
    if (this.articleForm.invalid) return;

    const controls = this.articleForm.controls;
    const title: string = controls.title.value;
    const description: string = controls.description.value;
    const content: string = controls.content.value;
    const tagIds: number[] = this.tagsSelected.map((tag: ITag) => tag.id);

    if (this.articleToEdit !== null) {
      const article: IArticleEdit = {
        id: this.articleToEdit.id,
        title: title,
        description: description,
        content: content,
        tagIds: tagIds,
      }
      this.articleToEditEvent.emit(article);
      return;
    }

    const article: IArticleCreate = {
      title: title,
      description: description,
      content: content,
      tagIds: tagIds,
    }
    this.articleToAddEvent.emit(article);
  }

  private buildArticleForm(): void {
    this.articleForm = this.formBuilder.group({
      title: [this.articleToEdit === null ? "" : this.articleToEdit.title,
        [Validators.required],
        [
          this.articleValidator.IsUniqueTitleValidator(this.articleToEdit?.id)
        ]
      ],
      content: [this.articleToEdit === null ? "" : this.articleToEdit.content,
        Validators.required],
      description: [this.articleToEdit === null ? "" : this.articleToEdit.description,
        Validators.required],
      tags: [this.articleToEdit === null ? "" : this.articleToEdit.tags,
        Validators.required]
    });
  }

  remove(tag: ITag): void {
    const index = this.tagsSelected.indexOf(tag);

    if (index >= 0) {
      this.tagsSelected.splice(index, 1);
    }
  }

  selected(event: MatAutocompleteSelectedEvent): void {
    const tagSelected: string = event.option.viewValue.toLowerCase();
    this.tagsSelected.push(this.tags.find(tag => tag.name.toLowerCase() == tagSelected));
    this.filteredTags = this.filteredTags
      .pipe(
        map((tagsFiltered: ITag[]) => tagsFiltered.filter((tag: ITag) => tag.name.toLowerCase() !== tagSelected))
      )
    this.tagInput.nativeElement.value = '';
    this.tagCtrl.setValue(null);
  }

  private _filter(value: ITag | string): ITag[] {
    let filterValue: string;
    typeof value !== "string" ? filterValue = value.name.toLowerCase() : filterValue = value.toLowerCase();
    return this.tags.filter(tag => tag.name.toLowerCase().includes(filterValue));
  }
}