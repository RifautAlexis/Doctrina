import { COMMA, ENTER } from '@angular/cdk/keycodes';
import { Component, ElementRef, EventEmitter, Input, OnInit, Output, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatAutocomplete, MatAutocompleteSelectedEvent } from '@angular/material/autocomplete';
import { Router } from '@angular/router';
import { TagService } from '@core/services/tag.service';
import { ArticleForm } from '@shared/models/article-form.model';
import { Tag } from '@shared/models/tag.model';
import { TagsResponse } from '@shared/responses/tags.response';
import { Observable, of } from 'rxjs';
import { map, tap } from 'rxjs/operators';
import { ArticleValidator } from '@shared/validators/article.validator';
import { Article } from '@shared/models/article.model';

@Component({
  selector: 'add-edit-article',
  templateUrl: './add-edit-article.component.html'
})

export class AddEditArticleComponent implements OnInit {

  @Input() articleToEdit?: Article;
  @Output() onArticleChanged = new EventEmitter<ArticleForm>();
  @Output() onContentChanged = new EventEmitter<string>();

  content: string;

  public articleForm: FormGroup

  tags: Tag[];
  separatorKeysCodes: number[] = [ENTER, COMMA];
  tagCtrl = new FormControl();
  tagsFiltered: Observable<Tag[]>;
  tagsSelected: Tag[];

  @ViewChild('tagInput') tagInput: ElementRef<HTMLInputElement>;
  @ViewChild('auto') matAutocomplete: MatAutocomplete;

  constructor(
    public formBuilder: FormBuilder,
    private router: Router,
    private articleValidator: ArticleValidator,
    private tagService: TagService
  ) {
    this.tagCtrl.valueChanges.subscribe(
      (typed: string) => {
        this.tagsFiltered = of(typed ? this.whenSelected(typed) : this.tags.slice());
      }
    );
  }

  ngOnInit(): void {
    this.tagService.getTags().subscribe((tags: Tag[]) => {
      this.tags = tags;

      this.buildTagsToEdit();
    });

    this.buildArticleForm();
  }

  buildTagsToEdit() {
    this.tagsSelected = this.articleToEdit?.tags === undefined ? [] : this.articleToEdit?.tags;
    this.tagsFiltered = of(this.tags.filter(tag => !this.tagsSelected.map(tagsSelected => tagsSelected.id).includes(tag.id)));
  }

  onChangeContent($event: string) {
    this.onContentChanged.emit($event);
  }

  submit() {
    if (this.articleForm.invalid) return;

    const controls = this.articleForm.controls;
    const title: string = controls.title.value;
    const description: string = controls.description.value;
    const content: string = controls.content.value;
    const tagIds: number[] = this.tagsSelected.map((tag: Tag) => tag.id);

    const article: ArticleForm = {
      title: title,
      description: description,
      content: content,
      tagIds: tagIds,
    }

    this.onArticleChanged.emit(article);
  }

  private buildArticleForm(): void {
    this.articleForm = this.formBuilder.group({
      title: [this.articleToEdit === undefined ? "" : this.articleToEdit.title,
        [Validators.required],
        [
          this.articleValidator.IsUniqueTitleValidator(this.articleToEdit?.id)
        ]
      ],
      content: [this.articleToEdit === undefined ? "" : this.articleToEdit.content,
        Validators.required],
      description: [this.articleToEdit === undefined ? "" : this.articleToEdit.description,
        Validators.required],
      tags: [this.articleToEdit === undefined ? "" : this.articleToEdit.tags,
        Validators.required]
    });
  }

  remove(tag: Tag): void {
    const index = this.tagsSelected.indexOf(tag);

    if (index >= 0) {
      this.tagsSelected.splice(index, 1);
    }
  }

  selected(event: MatAutocompleteSelectedEvent): void {
    const tagSelected: string = event.option.viewValue.toLowerCase();

    if(!this.tagsSelected.map(tagsSelected => tagsSelected.name.toLowerCase()).includes(tagSelected)) {
      const tagFound: Tag = this.tags.find(tag => tag.name.toLowerCase() == tagSelected);
      this.tagsSelected.push(tagFound);
      this.tagsFiltered = of(this.tags.filter(tag => !this.tagsSelected.map(ts => ts.id).includes(tag.id)));
    }
    this.tagInput.nativeElement.value = '';
    this.tagCtrl.setValue(null);
  }

  private whenSelected(value: Tag | string): Tag[] {
    let filterValue: string;
    typeof value !== "string" ? filterValue = value.name.toLowerCase() : filterValue = value.toLowerCase();
    return this.tags.filter(tag => !this.tagsSelected.map(ts => ts.name.toLowerCase()).includes(tag.name.toLowerCase()) && tag.name.toLowerCase().includes(filterValue.toLowerCase()));
  }
}