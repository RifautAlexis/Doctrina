import { Injectable } from "@angular/core";
import { AbstractControl, AsyncValidatorFn, ValidationErrors } from "@angular/forms";
import { ReadingListService } from "@core/services/reading-list.service";
import { Observable, of } from "rxjs";
import { catchError, map } from "rxjs/operators";

@Injectable()
export class ReadingListValidator {

    constructor(private readingListService: ReadingListService){}

    IsUniqueNameValidator(readingListId?: string): AsyncValidatorFn {
        return (control: AbstractControl): Promise<ValidationErrors | null> | Observable<ValidationErrors | null> => {
            if (control.value !== null && control.value !== "") {
                return this.readingListService.isUniqueName(control.value, readingListId).pipe(
                    map((isUnique: boolean) => (!isUnique ? { isUniqueName: true } : null)),
                    catchError(() => of(null))
                );
            }
            return null;
        };
    }
}