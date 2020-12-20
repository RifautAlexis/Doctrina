import { NgModule } from '@angular/core';
import { MaterialUiModule } from './material-ui/material-ui.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { ArticleValidator } from './validators/article.validator';
import { TagValidator } from './validators/tag.validator';
import { ReadingListValidator } from './validators/reading-list.validator';
import { AddEditArticleModule } from './components/add-edit-article/add-edit-article.module';
import { AddEditReadingListModule } from './components/add-edit-reading-list/add-edit-reading-list.module';
import { ArticlesOverviewModule } from './components/articles-overview/articles-overview.module';
import { DisplayTagsModule } from './components/display-tags/display-tags.module';
import { LoadingIndicatorModule } from './components/loading-indicator/loading-indicator.module';
import { ReadingListOverviewModule } from './components/reading-lists-overview/reading-lists-overview.module';
// import {  } from './components/tags-overview/tags-overview.module';

@NgModule({
  declarations: [
  ],
  entryComponents: [
  ],
  imports: [
    CommonModule,
    MaterialUiModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  exports: [
    CommonModule,
    MaterialUiModule,
    FormsModule,
    ReactiveFormsModule,
    AddEditArticleModule,
    AddEditReadingListModule,
    ArticlesOverviewModule,
    DisplayTagsModule,
    LoadingIndicatorModule,
    ReadingListOverviewModule
  ],
  providers: [
    ArticleValidator,
    TagValidator,
    ReadingListValidator
  ]
})

export class SharedModule { }