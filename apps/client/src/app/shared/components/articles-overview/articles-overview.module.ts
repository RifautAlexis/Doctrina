import { NgModule } from '@angular/core';

import { ArticlesOverviewComponent } from './articles-overview.component';
import { DisplayTagsModule } from '../display-tags/display-tags.module';
import { MaterialUiModule } from '@shared/material-ui/material-ui.module';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [ArticlesOverviewComponent],
  imports: [
    CommonModule,
    DisplayTagsModule,
    MaterialUiModule,
    // FormsModule,
    // ReactiveFormsModule,
  ],
  exports: [ArticlesOverviewComponent]
})
export class ArticlesOverviewModule { }
