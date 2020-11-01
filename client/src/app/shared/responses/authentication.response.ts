import { IAuthentication } from '@shared/models/authentication.model';
import { IUser } from "../models/user.model";
import { IResponse } from './response';

export interface IAuthenticationResponse extends IResponse {
    data: IAuthentication;
}