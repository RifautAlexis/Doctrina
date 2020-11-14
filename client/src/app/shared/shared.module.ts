import { NgModule } from '@angular/core';
import { MaterialUiModule } from './material-ui/material-ui.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { ArticleValidator } from './validators/article.validator';

@NgModule({
  declarations: [
  ],
  entryComponents: [
  ],
  imports: [
    CommonModule,
    MaterialUiModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports: [
    CommonModule,
    MaterialUiModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [
    ArticleValidator,
  ]
})

export class SharedModule { }