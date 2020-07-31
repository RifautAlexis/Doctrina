import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FrameLayoutComponent } from './layout/frame/frame-layout.component';
import { ShareModule } from '@share/share.module';

@NgModule({
  declarations: [FrameLayoutComponent],
  imports: [
    CommonModule,
    ShareModule,
    RouterModule,
  ],
  exports: [FrameLayoutComponent]
})
export class CoreModule { }
