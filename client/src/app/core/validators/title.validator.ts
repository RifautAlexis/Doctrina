import { Injectable } from '@angular/core';
import { AbstractControl, AsyncValidator, ValidationErrors } from '@angular/forms';
import { ArticleService } from '@core/services/article.service';
import { IBooleanResponse } from '@shared/responses/boolean.response';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

@Injectable({ providedIn: 'root' })
export class IsUniqueTitleValidator implements AsyncValidator {

    constructor(private articleService: ArticleService) { }

    validate = (ctrl: AbstractControl): Observable<ValidationErrors | null> => {
        if (ctrl.value !== null && ctrl.value !== "") {
            return this.articleService.isUniqueTitle(ctrl.value).pipe(
                map((isUnique: IBooleanResponse) => (!isUnique.data ? { isUniquetitle: true } : null)),
                catchError(() => of(null))
            );
        }
        return null;
    }
}