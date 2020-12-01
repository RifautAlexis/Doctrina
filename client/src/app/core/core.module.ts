import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderLayoutComponent } from './layouts/header/header-layout.component';
import { SharedModule } from '@shared/shared.module';
import { AuthenticationService } from "./authentication/authentication.service";
import { ArticleService } from "./services/article.service";
import { TagService } from "./services/tag.service";
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtInterceptor } from './authentication/jwt.interceptor';
import { ErrorInterceptor } from './interceptors/error.interceptor';
// import { Snackbar } from '../components/snackbar/snackbar.component';
import { StyleManagerService } from "./services/style-manager.service";

@NgModule({
  declarations: [
    HeaderLayoutComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    RouterModule,
    HttpClientModule,
    // Snackbar
  ],
  providers: [
    AuthenticationService,
    ArticleService,
    TagService,
    StyleManagerService,
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
  ],
  exports: [
    HeaderLayoutComponent
  ]
})
export class CoreModule { }
