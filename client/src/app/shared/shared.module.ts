import { NgModule } from '@angular/core';
import { MaterialUiModule } from './material-ui/material-ui.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Snackbar } from './components/snackbar.component';

@NgModule({
  declarations: [
  ],
  entryComponents: [
  ],
  imports: [
    MaterialUiModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports: [
    MaterialUiModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [
  ]
})

export class SharedModule { }