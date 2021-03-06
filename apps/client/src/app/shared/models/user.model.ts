import { Role } from "../enum";

export interface User {
    id: number;
    username: string;
    email: string;
    role: Role;
}