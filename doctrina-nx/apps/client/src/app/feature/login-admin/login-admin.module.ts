import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '@shared/shared.module';

import { LoginAdminComponent } from './login-admin/login-admin.component';
import { LoginAdminRoutingModule } from './login-admin-routing.module';

@NgModule({
  declarations: [
    LoginAdminComponent,
  ],
  imports: [
    CommonModule,
    LoginAdminRoutingModule,
    SharedModule,
  ],
  providers: [
  ]
})
export class LoginAdminModule { }
