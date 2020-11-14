import { Injectable } from "@angular/core";
import { FormGroup, AbstractControl, AsyncValidatorFn, ValidationErrors, AsyncValidator } from "@angular/forms";
import { ArticleService } from "@core/services/article.service";
import { IBooleanResponse } from "@shared/responses/boolean.response";
import { Observable, of } from "rxjs";
import { catchError, map } from "rxjs/operators";

@Injectable()
export class ArticleValidator {

    constructor(private articleService: ArticleService){}

    IsUniqueTitleValidator(articleId: number): AsyncValidatorFn {
        return (control: AbstractControl): Promise<ValidationErrors | null> | Observable<ValidationErrors | null> => {
            if (control.value !== null && control.value !== "") {
                return this.articleService.isUniqueTitle(control.value, articleId).pipe(
                    map((isUnique: IBooleanResponse) => (!isUnique.data ? { isUniquetitle: true } : null)),
                    catchError(() => of(null))
                );
            }
            return null;
        };
    }
}