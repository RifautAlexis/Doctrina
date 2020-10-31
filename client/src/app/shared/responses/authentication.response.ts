import { IUser } from "../models/user.model";
import { IResponse } from './response';

export interface IAuthenticationResponse extends IResponse {
    data: {
        user: IUser;
        token: string;
    };
}