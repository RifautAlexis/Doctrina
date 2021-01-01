import { IsUniqueTitleDTO } from "../../DTOs";
import { IRequest } from "../request";

export interface IsUniqueTitleRequest extends IRequest{
    titleToValidate: IsUniqueTitleDTO;
}