import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ArticleRoutingModule } from './article-routing.module';
import { SharedModule } from '@shared/shared.module';
import { ArticleComponent } from './article/article.component';
import { QuillModule } from 'ngx-quill';
import { ArticleDetailsComponent } from './article-details/article-details.component';

@NgModule({
  declarations: [
    ArticleComponent,
    ArticleDetailsComponent
  ],
  imports: [
    CommonModule,
    ArticleRoutingModule,
    SharedModule,
    QuillModule
  ]
})
export class ArticleModule { }
