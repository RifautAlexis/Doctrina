import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReadingListsOverviewComponent } from './reading-lists-overview/reading-lists-overview.component';
import { MaterialUiModule } from '../../material-ui/material-ui.module';
@NgModule({
  declarations: [ReadingListsOverviewComponent],
  imports: [
    MaterialUiModule,
    CommonModule
  ],
  exports: [
    ReadingListsOverviewComponent
  ]
})
export class ReadingListOverviewModule { }
