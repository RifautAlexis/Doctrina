import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ArticleService } from '@core/services/article.service';
import { Observable } from 'rxjs';

import { COMMA, ENTER } from '@angular/cdk/keycodes';
import { ElementRef, ViewChild } from '@angular/core';
import { MatAutocompleteSelectedEvent, MatAutocomplete } from '@angular/material/autocomplete';
import { MatChipInputEvent } from '@angular/material/chips';
import { filter, map, startWith } from 'rxjs/operators';
import { ITag } from '@shared/models/tag.model';
import { Router } from '@angular/router';
import { IsUniqueTitleValidator } from '@core/validators/title.validator';

@Component({
  selector: 'app-write-article',
  templateUrl: './write-article.component.html',
  styleUrls: ['./write-article.component.scss']
})
export class WriteArticleComponent implements OnInit {

  public articleForm: FormGroup

  markdown;
  tags: ITag[] = [];
  visible = true;
  selectable = true;
  removable = true;
  separatorKeysCodes: number[] = [ENTER, COMMA];
  tagCtrl = new FormControl();
  filteredTags: Observable<ITag[]>;
  tagsSelected: ITag[] = [];
  allTags: ITag[] = [
    { id: 1, name: "Javascript", createdAt: new Date(Date.now()), updatedAt: new Date(Date.now()) },
    { id: 2, name: "NodeJs", createdAt: new Date(Date.now()), updatedAt: new Date(Date.now()) },
    { id: 3, name: "ASP.NET Core", createdAt: new Date(Date.now()), updatedAt: new Date(Date.now()) },
    { id: 4, name: "Python", createdAt: new Date(Date.now()), updatedAt: new Date(Date.now()) },
    { id: 5, name: "C#", createdAt: new Date(Date.now()), updatedAt: new Date(Date.now()) }
  ];

  @ViewChild('tagInput') tagInput: ElementRef<HTMLInputElement>;
  @ViewChild('auto') matAutocomplete: MatAutocomplete;

  constructor(
    public formBuilder: FormBuilder,
    private router: Router,
    private isUniqueTitleValidator: IsUniqueTitleValidator
  ) {
    this.filteredTags = this.tagCtrl.valueChanges.pipe(
      startWith(null),
      map((tag: ITag) => tag ? this._filter(tag) : this.allTags.slice()));
  }

  ngOnInit(): void {
    this.buildArticleForm();
  }

  createArticle(): void {
    console.log("ENTERED");
    console.log(this.articleForm.invalid);
    console.log(this.articleForm.errors);
    if(this.articleForm.invalid) return;
    console.log("PASSED");

    const controls = this.articleForm.controls;
    const title: string = controls.title.value;
    const description: string = controls.description.value;
    const content: string = controls.content.value;
    const tagIds: number[] = this.tagsSelected.map((tag: ITag) => tag.id);

    // this.writeArticleBloc.createArticle({title, description, content, tagIds})
    //   .subscribe((articleId: number) => {console.log(articleId); this.router.navigate['article/' + articleId];});
  }

  private buildArticleForm(): void {
    this.articleForm = this.formBuilder.group({
      title: ["", 
        [Validators.required],
        [this.isUniqueTitleValidator.validate]
      ],
      content: ["", Validators.required],
      description: ["", Validators.required],
      tags: [""]
    });
  }

  add(event: MatChipInputEvent): void {
    const input = event.input;
    const value = event.value;
    
    if ((value || '').trim()) {
      const tagTyped: ITag = this.tags.find(tag => tag.name.toLowerCase() == value.trim().toLowerCase())
      if(tagTyped) this.tagsSelected.push(tagTyped);
    }

    if (input) {
      input.value = '';
    }

    this.tagCtrl.setValue(null);
  }

  remove(tag: ITag): void {
    const index = this.tagsSelected.indexOf(tag);

    if (index >= 0) {
      this.tagsSelected.splice(index, 1);
    }
  }

  selected(event: MatAutocompleteSelectedEvent): void {
    const tagSelected: string = event.option.viewValue.toLowerCase();
    this.tagsSelected.push(this.allTags.find(tag => tag.name.toLowerCase() == tagSelected));
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
    return this.allTags.filter(tag => tag.name.toLowerCase().indexOf(filterValue) === 0);
  }
}
