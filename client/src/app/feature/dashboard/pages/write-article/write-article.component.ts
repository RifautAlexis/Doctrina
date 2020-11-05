import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ArticleService } from '@core/services/article.service';
import { Observable, of } from 'rxjs';

import { COMMA, ENTER } from '@angular/cdk/keycodes';
import { ElementRef, ViewChild } from '@angular/core';
import { MatAutocompleteSelectedEvent, MatAutocomplete } from '@angular/material/autocomplete';
import { map } from 'rxjs/operators';
import { ITag } from '@shared/models/tag.model';
import { Router } from '@angular/router';
import { IsUniqueTitleValidator } from '@core/validators/title.validator';
import { Status } from '@shared/enum';
import { ITagsResponse } from '@shared/responses/tags.response';
import { TagService } from '@core/services/tag.service';

@Component({
  selector: 'app-write-article',
  templateUrl: './write-article.component.html',
  styleUrls: ['./write-article.component.scss']
})
export class WriteArticleComponent implements OnInit {

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
    private isUniqueTitleValidator: IsUniqueTitleValidator,
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

  createArticle(): void {
    if(this.articleForm.invalid) return;

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
      tags: ["", Validators.required]
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
