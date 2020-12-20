import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InternalServerComponent } from './internal-server/internal-server.component';
import { InternalServerRoutingModule } from './internal-server-routing.module';

@NgModule({
  declarations: [InternalServerComponent],
  imports: [
    CommonModule,
    InternalServerRoutingModule
  ]
})
export class InternalServerModule { }
