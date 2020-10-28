import { IUser } from "./user.model";

export interface IAuthentication {
    user: IUser;
    token: string;
}