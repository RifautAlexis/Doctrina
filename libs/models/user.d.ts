import { BaseEntity } from "./base-entity";
import { Role } from "./role";

export interface User extends BaseEntity {
    username: string;
    email: string;
    role: Role;
}