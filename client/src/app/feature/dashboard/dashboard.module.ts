import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '@shared/shared.module';

import { DashboardRoutingModule } from './dashboard-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ArticlesComponent } from './articles/articles.component';
import { ArticleEditComponent } from './article-edit/article-edit.component';
import { WriteArticleComponent } from './write-article/write-article.component';
import { QuillModule } from 'ngx-quill';
// import { SnackbarModule } from 'src/app/components/snackbar/snackbar.module';
import { TagsComponent } from './tags/tags.component';
import { ReadingListComponent } from './reading-list/reading-list/reading-list.component';
import { ReadingListEditComponent } from './reading-list-edit/reading-list-edit/reading-list-edit.component';
import { ReadingListAddComponent } from './reading-list-add/reading-list-add.component';

@NgModule({
  declarations: [
    DashboardComponent,
    ArticlesComponent,
    ArticleEditComponent,
    WriteArticleComponent,
    TagsComponent,
    ReadingListComponent,
    ReadingListEditComponent,
    ReadingListAddComponent
  ],
  imports: [
    CommonModule,
    DashboardRoutingModule,
    SharedModule,
    QuillModule.forRoot(),
    // SnackbarModule,
  ],
  providers: [
  ]
})
export class DashboardModule { }
