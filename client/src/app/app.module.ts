import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CoreModule } from '@core/core.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ArchiveModule } from './feature/archive/archive.module';
import { ArticleModule } from './feature/article/article.module';
import { HomeModule } from './feature/home/home.module';
import { DashboardModule } from './feature/dashboard/dashboard.module';
import { LoginAdminModule } from './feature/login-admin/login-admin.module';
import { HttpClientModule } from '@angular/common/http';
import { MarkdownModule } from 'ngx-markdown';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CoreModule,
    BrowserAnimationsModule,
    MarkdownModule.forRoot(),
    ArchiveModule,
    ArticleModule,
    HomeModule,
    DashboardModule,
    LoginAdminModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
