import { NgModule } from '@angular/core';
import { MaterialUiModule } from './material-ui/material-ui.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { LoadingIndicatorComponent } from './components/loading-indicator/loading-indicator.component';
import { ArticleOverviewComponent } from './components/article-overview/article-overview.component';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [
    LoadingIndicatorComponent,
    ArticleOverviewComponent,
  ],
  entryComponents: [
  ],
  imports: [
    MaterialUiModule,
    FormsModule,
    ReactiveFormsModule,
    CommonModule
  ],
  exports: [
    MaterialUiModule,
    FormsModule,
    ReactiveFormsModule,
    LoadingIndicatorComponent,
    ArticleOverviewComponent,
  ],
  providers: [
  ]
})

export class SharedModule { }