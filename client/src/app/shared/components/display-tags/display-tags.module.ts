import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MaterialUiModule } from '@shared/material-ui/material-ui.module';
import { DisplayTagsComponent } from './display-tags.component';

@NgModule({
    imports: [
        MaterialUiModule,
        CommonModule
    ],
    exports: [
        DisplayTagsComponent
    ],
    declarations: [
        DisplayTagsComponent
    ],
    providers: [],
})
export class DisplayTagsModule { }
