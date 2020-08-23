import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FrameLayoutComponent } from './layouts/frame/frame-layout.component';
import { SharedModule } from '@shared/shared.module';
import { AuthenticationService } from "./services/authentication.service";
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtInterceptor } from './interceptors/jwt.interceptor';
import { ErrorInterceptor } from './interceptors/error.interceptor';

@NgModule({
  declarations: [FrameLayoutComponent],
  imports: [
    CommonModule,
    SharedModule,
    RouterModule,
  ],
  providers: [
    AuthenticationService,
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
  ],
  exports: [FrameLayoutComponent]
})
export class CoreModule { }
