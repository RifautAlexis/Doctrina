import { ITag } from '../models/tag.model';
import { IResponse } from './response';

export interface ITagsResponse extends IResponse {
    data: ITag[];
}