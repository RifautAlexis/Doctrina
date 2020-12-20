import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ReadingListsRoutingModule } from './reading-lists-routing.module';
import { ReadingListsComponent } from './reading-lists/reading-lists.component';
import { SharedModule } from '@shared/shared.module';

@NgModule({
  declarations: [ReadingListsComponent],
  imports: [
    CommonModule,
    SharedModule
  ]
})
export class ReadingListsModule { }
