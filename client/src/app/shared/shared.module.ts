import { NgModule } from '@angular/core';
import { MaterialUiModule } from './material-ui/material-ui.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [
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
  ],
  providers: [
  ]
})

export class SharedModule { }