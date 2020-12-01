import { NgModule } from '@angular/core';
import { SharedModule } from '../../shared/shared.module';

import { ArticlesOverviewComponent } from './articles-overview.component';
import { DisplayTagsModule } from '../display-tags/display-tags.module';

@NgModule({
  declarations: [ArticlesOverviewComponent],
  imports: [
    SharedModule,
    DisplayTagsModule
  ],
  exports: [ArticlesOverviewComponent]
})
export class ArticlesOverviewModule { }
