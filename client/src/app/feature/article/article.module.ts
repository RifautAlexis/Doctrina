import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ArticleRoutingModule } from './article-routing.module';
import { SharedModule } from '@shared/shared.module';
import { ArticleComponent } from './article/article.component';
import { QuillModule } from 'ngx-quill';
import { ArticleDetailsComponent } from './article-details/article-details.component';
import { LoadingIndicatorModule } from '../../components/loading-indicator/loading-indicator.module';
import { DisplayTagsModule } from '../../components/display-tags/display-tags.module';

@NgModule({
  declarations: [
    ArticleComponent,
    ArticleDetailsComponent
  ],
  imports: [
    CommonModule,
    ArticleRoutingModule,
    SharedModule,
    QuillModule,
    LoadingIndicatorModule,
    DisplayTagsModule
  ]
})
export class ArticleModule { }
