import { IRequest } from "./request";

export interface DefaultKeyedRequest extends IRequest{
    id: number;
}