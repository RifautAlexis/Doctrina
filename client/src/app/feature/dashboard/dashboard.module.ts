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
import { ArticlesOverviewModule } from 'src/app/components/articles-overview/articles-overview.module';
import { LoadingIndicatorModule } from 'src/app/components/loading-indicator/loading-indicator.module';

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
    ArticlesOverviewModule,
    LoadingIndicatorModule
  ],
  providers: [
  ]
})
export class DashboardModule { }
