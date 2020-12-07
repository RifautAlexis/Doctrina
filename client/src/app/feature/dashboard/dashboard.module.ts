import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '@shared/shared.module';

import { DashboardRoutingModule } from './dashboard-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ArticlesComponent } from './pages/articles/articles.component';
import { EditArticleComponent } from './pages/edit-article/edit-article.component';
import { WriteArticleComponent } from './pages/write-article/write-article.component';
import { QuillModule } from 'ngx-quill';
// import { SnackbarModule } from 'src/app/components/snackbar/snackbar.module';
import { AddEditArticleModule } from '../../components/add-edit-article/add-edit-article.module';
import { LoadingIndicatorModule } from '../../components/loading-indicator/loading-indicator.module';
import { ArticlesOverviewModule } from '../../components/articles-overview/articles-overview.module';
import { TagsComponent } from './pages/tags/tags.component';
import { DisplayTagsModule } from 'src/app/components/display-tags/display-tags.module';

@NgModule({
  declarations: [
    DashboardComponent,
    ArticlesComponent,
    EditArticleComponent,
    WriteArticleComponent,
    TagsComponent
  ],
  imports: [
    CommonModule,
    DashboardRoutingModule,
    SharedModule,
    QuillModule.forRoot(),
    // SnackbarModule,
    AddEditArticleModule,
    LoadingIndicatorModule,
    ArticlesOverviewModule,
    DisplayTagsModule
  ],
  providers: [
  ]
})
export class DashboardModule { }
