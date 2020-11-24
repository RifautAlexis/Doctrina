import { NgModule } from '@angular/core';

import { LoadingIndicatorComponent } from './loading-indicator.component';
import { SharedModule } from '../../shared/shared.module';

@NgModule({
  declarations: [
    LoadingIndicatorComponent
  ],
  imports: [
    SharedModule
  ],
  exports: [LoadingIndicatorComponent]
})
export class LoadingIndicatorModule { }
