import { NgModule } from '@angular/core';

import { ContentEditorComponent } from './content-editor.component';
import { QuillModule } from 'ngx-quill';

@NgModule({
    declarations: [
        ContentEditorComponent
    ],
    imports: [
        QuillModule.forRoot(),
    ],
    exports: [
        ContentEditorComponent
    ],
    providers: [],
})
export class ContentEditorModule { }
