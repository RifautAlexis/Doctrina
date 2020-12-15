import { NgModule } from '@angular/core';

import { AddEditArticleComponent } from './add-edit-article.component';
import { ContentEditorComponent } from './content-editor/content-editor.component';
import { QuillModule } from 'ngx-quill';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MaterialUiModule } from '@shared/material-ui/material-ui.module';
import { CommonModule } from '@angular/common';

@NgModule({
    imports: [
        QuillModule,
        MaterialUiModule,
        FormsModule,
        ReactiveFormsModule,
        CommonModule
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
