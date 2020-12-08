import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { IsNotAdminGuard } from '@core/guards/is-not-admin.guard';
import { LoginAdminComponent } from './login-admin/login-admin.component';

const routes: Routes = [
  { path: '', component: LoginAdminComponent, canActivate: [IsNotAdminGuard] },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LoginAdminRoutingModule { }
