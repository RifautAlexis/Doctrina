import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ArticleRoutingModule } from './article-routing.module';
import { SharedModule } from '@shared/shared.module';
import { ArticleComponent } from './pages/article/article.component';


@NgModule({
  declarations: [ArticleComponent],
  imports: [
    CommonModule,
    ArticleRoutingModule,
    SharedModule
  ]
})
export class ArticleModule { }
