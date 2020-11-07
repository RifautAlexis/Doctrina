import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LoadingIndicatorComponent } from './loading-indicator.component';
import { SharedModule } from '@shared/shared.module';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';

@NgModule({
  declarations: [LoadingIndicatorComponent],
  imports: [
    CommonModule,
    MatProgressSpinnerModule
  ],
  exports: [LoadingIndicatorComponent]
})
export class LoadingIndicatorModule { }
