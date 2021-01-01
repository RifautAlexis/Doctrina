import { IResponse } from "./response";

export interface BooleanResponse extends IResponse {
    data: boolean;
}