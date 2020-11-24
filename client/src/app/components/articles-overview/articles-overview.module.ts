import { NgModule } from '@angular/core';
import { SharedModule } from '../../shared/shared.module';

import { ArticlesOverviewComponent } from './articles-overview.component';

@NgModule({
  declarations: [ArticlesOverviewComponent],
  imports: [
    SharedModule
  ],
  exports: [ArticlesOverviewComponent]
})
export class ArticlesOverviewModule { }
