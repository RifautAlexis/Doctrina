import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { Snackbar } from './custom-snackbar.component';
import { MatSnackBarModule } from '@angular/material/snack-bar';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    MatSnackBarModule
  ],
  exports: [
    // Snackbar
  ]
})
export class SnackbarModule { }
