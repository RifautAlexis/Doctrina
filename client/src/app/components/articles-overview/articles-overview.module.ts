import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ArticlesOverviewComponent } from './articles-overview.component';
import { MatCardModule } from '@angular/material/card';
import { MatChipsModule } from '@angular/material/chips';

@NgModule({
  declarations: [ArticlesOverviewComponent],
  imports: [
    CommonModule,
    MatCardModule,
    MatChipsModule
  ],
  exports: [ArticlesOverviewComponent]
})
export class ArticlesOverviewModule { }
