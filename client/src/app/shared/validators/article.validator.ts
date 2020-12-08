import { Injectable } from "@angular/core";
import { AbstractControl, AsyncValidatorFn, ValidationErrors } from "@angular/forms";
import { ArticleService } from "@core/services/article.service";
import { Observable, of } from "rxjs";
import { catchError, map } from "rxjs/operators";

@Injectable()
export class ArticleValidator {

    constructor(private articleService: ArticleService){}

    IsUniqueTitleValidator(articleId?: string): AsyncValidatorFn {
        return (control: AbstractControl): Promise<ValidationErrors | null> | Observable<ValidationErrors | null> => {
            if (control.value !== null && control.value !== "") {
                return this.articleService.isUniqueTitle(control.value, articleId).pipe(
                    map((isUnique: boolean) => (!isUnique ? { isUniquetitle: true } : null)),
                    catchError(() => of(null))
                );
            }
            return null;
        };
    }
}