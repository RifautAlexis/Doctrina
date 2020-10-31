import { Status } from '../enum'

export interface IResponse {
    status: Status,
    error?: string,
}