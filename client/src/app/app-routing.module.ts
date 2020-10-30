import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeModule } from '@feature/home/home.module';
import { ArticleModule } from '@feature/article/article.module';
import { ArchiveModule } from '@feature/archive/archive.module';
import { DashboardModule } from '@feature/dashboard/dashboard.module';
import { LoginAdminModule } from '@feature/login-admin/login-admin.module';

const routes: Routes = [
  { path: '', pathMatch: 'full', loadChildren: () => HomeModule },
  { path: 'dashboard', loadChildren: () => DashboardModule },
  { path: 'admin', loadChildren: () => LoginAdminModule },
  { path: 'archive', loadChildren: () => ArchiveModule },
  { path: ':id', loadChildren: () => ArticleModule },
  { path: '**', redirectTo: 'home' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
