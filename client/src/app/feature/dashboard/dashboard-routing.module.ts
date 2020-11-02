import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from '../dashboard/components/dashboard/dashboard.component';
import { IsAdminGuard } from '@core/guards/is-admin.guard';
import { IsNotAdminGuard } from '@core/guards/is-not-admin.guard';
import { ArticlesComponent } from '@feature/dashboard/pages/articles/articles.component';
import { WriteArticleComponent } from '@feature/dashboard/pages/write-article/write-article.component';
import { EditArticleComponent } from '@feature/dashboard/pages/edit-article/edit-article.component';
import { DashboardLayoutComponent } from '@core/layouts/dashboard/dashboard-layout.component';

const routes: Routes = [
  {
    path: '', component: DashboardLayoutComponent, canActivate: [IsAdminGuard], children: [
      { path: 'articles', component: ArticlesComponent, canActivate: [IsAdminGuard] },
      { path: 'articles/write', component: WriteArticleComponent, canActivate: [IsAdminGuard] },
      { path: 'articles/:id', component: EditArticleComponent, canActivate: [IsAdminGuard] },
      { path: '', redirectTo: 'articles', pathMatch: 'full' }
    ]
  }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DashboardRoutingModule { }
