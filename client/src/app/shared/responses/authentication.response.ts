import { IUser } from "../models/user.model";

export interface IAuthenticationResponse {
    user: IUser;
    token: string;
}