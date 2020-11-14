import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '@shared/shared.module';

import { DashboardRoutingModule } from './dashboard-routing.module';
import { DashboardComponent } from '../dashboard/components/dashboard/dashboard.component';
import { ArticlesComponent } from './pages/articles/articles.component';
import { EditArticleComponent } from './pages/edit-article/edit-article.component';
import { WriteArticleComponent } from './pages/write-article/write-article.component';
import { QuillModule } from 'ngx-quill';
import { ArticlesOverviewModule } from 'src/app/components/articles-overview/articles-overview.module';
import { LoadingIndicatorModule } from 'src/app/components/loading-indicator/loading-indicator.module';
// import { SnackbarModule } from 'src/app/components/snackbar/snackbar.module';
import { AddEditArticleModule } from '../../components/add-edit-article/add-edit-article.module';

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
    QuillModule.forRoot(),
    ArticlesOverviewModule,
    LoadingIndicatorModule,
    // SnackbarModule,
    AddEditArticleModule
  ],
  providers: [
  ]
})
export class DashboardModule { }
