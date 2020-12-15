import { NgModule } from '@angular/core';
import { AddEditReadingListComponent } from './add-edit-reading-list.component'
import { MaterialUiModule } from '../../material-ui/material-ui.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [AddEditReadingListComponent],
  imports: [
    MaterialUiModule,
    FormsModule,
    ReactiveFormsModule,
    CommonModule
  ],
  exports: [
    AddEditReadingListComponent
  ]
})
export class AddEditReadingListModule { }
