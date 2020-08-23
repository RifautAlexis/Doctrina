import { IUser } from "../models/user.model";

export interface IAuthentication {
    user: IUser;
    token: string;
}