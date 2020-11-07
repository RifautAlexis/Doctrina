import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './pages/home/home.component';
import { SharedModule } from '@shared/shared.module';

import { ArticlesOverviewModule } from '../../components/articles-overview/articles-overview.module';
import { LoadingIndicatorModule } from '../../components/loading-indicator/loading-indicator.module';

@NgModule({
  declarations: [HomeComponent],
  imports: [
    CommonModule,
    HomeRoutingModule,
    SharedModule,
    ArticlesOverviewModule,
    LoadingIndicatorModule
  ]
})
export class HomeModule { }
