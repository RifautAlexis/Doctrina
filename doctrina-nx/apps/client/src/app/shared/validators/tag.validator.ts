import { Injectable } from "@angular/core";
import { AbstractControl, AsyncValidatorFn, ValidationErrors } from "@angular/forms";
import { TagService } from "@core/services/tag.service";
import { Observable, of } from "rxjs";
import { catchError, map } from "rxjs/operators";

@Injectable()
export class TagValidator {

    constructor(private tagService: TagService){}

    IsUniqueNameValidator(tagId?: string): AsyncValidatorFn {
        return (control: AbstractControl): Promise<ValidationErrors | null> | Observable<ValidationErrors | null> => {
            if (control.value !== null && control.value !== "") {
                return this.tagService.isUniqueName(control.value, tagId).pipe(
                    map((isUnique: boolean) => (!isUnique ? { isUniqueName: true } : null)),
                    catchError(() => of(null))
                );
            }
            return null;
        };
    }
}