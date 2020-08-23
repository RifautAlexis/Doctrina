import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeModule } from '@feature/home/home.module';
import { ArticleModule } from '@feature/article/article.module';
import { ArchiveModule } from '@feature/archive/archive.module';
import { AdminModule } from '@feature/admin/admin.module';

const routes: Routes = [
  { path: '', pathMatch: 'full', loadChildren: () => HomeModule },
  { path: 'admin', loadChildren: () => AdminModule },
  { path: 'archive', loadChildren: () => ArchiveModule },
  { path: ':title', loadChildren: () => ArticleModule },
  { path: '**', redirectTo: 'home' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
