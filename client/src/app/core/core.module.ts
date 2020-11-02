import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FrameLayoutComponent } from './layouts/frame/frame-layout.component';
import { DashboardLayoutComponent } from './layouts/dashboard/dashboard-layout.component';
import { SharedModule } from '@shared/shared.module';
import { AuthenticationService } from "./authentication/authentication.service";
import { ArticleService } from "./services/article.service";
import { TagService } from "./services/tag.service";
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtInterceptor } from './authentication/jwt.interceptor';
import { ErrorInterceptor } from './interceptors/error.interceptor';
import { IsUniqueTitleValidator } from './validators/title.validator';

@NgModule({
  declarations: [
    FrameLayoutComponent,
    DashboardLayoutComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    RouterModule,
    HttpClientModule
  ],
  providers: [
    AuthenticationService,
    ArticleService,
    TagService,
    IsUniqueTitleValidator,
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
  ],
  exports: [
    FrameLayoutComponent,
    DashboardLayoutComponent
  ]
})
export class CoreModule { }
