import { NgModule } from '@angular/core';

import { SharedModule } from '../../shared/shared.module';
import { DisplayTagsComponent } from './display-tags.component';

@NgModule({
    imports: [
        SharedModule
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
