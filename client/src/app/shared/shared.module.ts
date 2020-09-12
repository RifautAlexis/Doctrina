import { NgModule } from '@angular/core';
import { MaterialUiModule } from './material-ui/material-ui.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { LoadingIndicatorComponent } from './components/loading-indicator/loading-indicator.component';

@NgModule({
  declarations: [
    LoadingIndicatorComponent
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
    ReactiveFormsModule,
    LoadingIndicatorComponent
  ],
  providers: [
  ]
})

export class SharedModule { }