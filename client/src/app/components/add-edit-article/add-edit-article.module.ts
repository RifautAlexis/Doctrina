import { NgModule } from '@angular/core';

import { AddEditArticleComponent } from './add-edit-article.component';

import { QuillModule } from 'ngx-quill';
import { SharedModule } from '@shared/shared.module';

@NgModule({
    imports: [
        SharedModule,
        QuillModule.forRoot(),
    ],
    exports: [AddEditArticleComponent],
    declarations: [AddEditArticleComponent],
    providers: [],
})
export class AddEditArticleModule { }
