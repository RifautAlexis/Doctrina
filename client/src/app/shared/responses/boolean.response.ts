import { IResponse } from "./response";

export interface IBooleanResponse extends IResponse {
    data: boolean;
}