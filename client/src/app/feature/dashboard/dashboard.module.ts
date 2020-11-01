import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '@shared/shared.module';

import { DashboardRoutingModule } from './dashboard-routing.module';
import { DashboardComponent } from '../dashboard/components/dashboard/dashboard.component';
import { MarkdownModule } from 'ngx-markdown';
import { ArticlesComponent } from './pages/articles/articles.component';
import { EditArticleComponent } from './pages/edit-article/edit-article.component';
import { WriteArticleComponent } from './pages/write-article/write-article.component';

import { ArticlesBloc } from './pages/articles/articles.bloc';
import { WriteArticleBloc } from './pages/write-article/write-article.bloc';

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
    MarkdownModule
  ],
  providers: [
    ArticlesBloc,
    WriteArticleBloc
  ]
})
export class DashboardModule { }
