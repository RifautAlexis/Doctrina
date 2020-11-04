import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '@shared/shared.module';

import { DashboardRoutingModule } from './dashboard-routing.module';
import { DashboardComponent } from '../dashboard/components/dashboard/dashboard.component';
import { MarkdownModule } from 'ngx-markdown';
import { ArticlesComponent } from './pages/articles/articles.component';
import { EditArticleComponent } from './pages/edit-article/edit-article.component';
import { WriteArticleComponent } from './pages/write-article/write-article.component';
import { QuillModule } from 'ngx-quill';

@NgModule({
  declarations: [
    DashboardComponent,
    ArticlesComponent,
    EditArticleComponent,
    WriteArticleComponent
  ],
  imports: [
    CommonModule,
    DashboardRoutingModule,
    SharedModule,
    MarkdownModule,
    QuillModule.forRoot(),
  ],
  providers: [
  ]
})
export class DashboardModule { }
