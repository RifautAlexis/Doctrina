import { Role } from "../enum";

export interface IUser {
    id: number;
    username: string;
    email: string;
    role: Role;
}