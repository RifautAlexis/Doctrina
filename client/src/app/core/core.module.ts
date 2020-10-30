import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FrameLayoutComponent } from './layouts/frame/frame-layout.component';
import { DashboardLayoutComponent } from './layouts/dashboard/dashboard-layout.component';
import { SharedModule } from '@shared/shared.module';
import { AuthenticationService } from "./services/authentication.service";
import { ArticleService } from "./services/article.service";
import { TagService } from "./services/tag.service";
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtInterceptor } from './interceptors/jwt.interceptor';
import { ErrorInterceptor } from './interceptors/error.interceptor';
import { SearchArticleBloc } from './blocs/search-article.bloc';
import { ArticleBloc } from './blocs/article.bloc';
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
  ],
  providers: [
    AuthenticationService,
    ArticleService,
    TagService,
    SearchArticleBloc,
    ArticleBloc,
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
