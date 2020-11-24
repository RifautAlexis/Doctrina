import { NgModule } from '@angular/core';

import { AddEditArticleComponent } from './add-edit-article.component';

import { SharedModule } from '../../shared/shared.module';
import { ContentEditorComponent } from './content-editor/content-editor.component';
import { QuillModule } from 'ngx-quill';

@NgModule({
    imports: [
        SharedModule,
        QuillModule
    ],
    exports: [
        AddEditArticleComponent
    ],
    declarations: [
        AddEditArticleComponent,
        ContentEditorComponent
    ],
    providers: [],
})
export class AddEditArticleModule { }
