import { ErrorHandler, Injectable } from "@angular/core";

@Injectable()
export class GlobalErrorHandler implements ErrorHandler {
    constructor(/*private readonly errorSnackbarService: ErrorSnackbarService*/) { }

    handleError(error: Error): void {
        console.error("Error was catched in Global Handler", error);
    }
}
