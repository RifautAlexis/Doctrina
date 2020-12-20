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
// import { Snackbar } from '../components/snackbar/snackbar.component';
import { StyleManagerService } from "./services/style-manager.service";
import { ErrorHandlerModule } from "./errors/error-handler.module";
import { ReadingListService } from './services/reading-list.service'

@NgModule({
  declarations: [
    HeaderLayoutComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    RouterModule,
    HttpClientModule,
    ErrorHandlerModule
    // Snackbar
  ],
  providers: [
    AuthenticationService,
    ArticleService,
    TagService,
    StyleManagerService,
    ReadingListService,
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
  ],
  exports: [
    HeaderLayoutComponent
  ]
})
export class CoreModule { }
