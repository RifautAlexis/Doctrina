import { NgModule } from '@angular/core';

import { LoadingIndicatorComponent } from './loading-indicator.component';
import { MaterialUiModule } from '@shared/material-ui/material-ui.module';

@NgModule({
  declarations: [
    LoadingIndicatorComponent
  ],
  imports: [
    MaterialUiModule
  ],
  exports: [LoadingIndicatorComponent]
})
export class LoadingIndicatorModule { }
