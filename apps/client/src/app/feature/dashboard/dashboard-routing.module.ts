import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { IsAdminGuard } from '@core/guards/is-admin.guard';
import { ArticlesComponent } from '@feature/dashboard/articles/articles.component';
import { WriteArticleComponent } from '@feature/dashboard/write-article/write-article.component';
import { ArticleEditComponent } from '@feature/dashboard/article-edit/article-edit.component';
import { ReadingListComponent } from './reading-list/reading-list/reading-list.component';
import { ReadingListEditComponent } from './reading-list-edit/reading-list-edit/reading-list-edit.component';

const routes: Routes = [
  {
    path: '', component: DashboardComponent, canActivate: [IsAdminGuard], children: [
      { path: 'articles', component: ArticlesComponent, canActivate: [IsAdminGuard] },
      { path: 'article/write', component: WriteArticleComponent, canActivate: [IsAdminGuard] },
      { path: 'article/edit/:id', component: ArticleEditComponent, canActivate: [IsAdminGuard] },
      { path: 'reading-lists', component: ReadingListComponent, canActivate: [IsAdminGuard] },
      { path: 'reading-list/edit/:id', component: ReadingListEditComponent, canActivate: [IsAdminGuard] },
      { path: '', redirectTo: 'articles', pathMatch: 'full' }
    ]
  }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DashboardRoutingModule { }
