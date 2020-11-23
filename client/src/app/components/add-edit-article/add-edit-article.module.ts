import { NgModule } from '@angular/core';

import { AddEditArticleComponent } from './add-edit-article.component';

import { SharedModule } from '@shared/shared.module';
import { ContentEditorModule } from './components/content-editor/content-editor.module';
import { QuillModule } from 'ngx-quill';

@NgModule({
    imports: [
        SharedModule,
        ContentEditorModule,
        QuillModule
    ],
    exports: [
        AddEditArticleComponent
    ],
    declarations: [
        AddEditArticleComponent
    ],
    providers: [],
})
export class AddEditArticleModule { }
