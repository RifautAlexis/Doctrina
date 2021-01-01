import { User } from "./user.model";

export interface Authentication {
    user: User;
    token: string;
}