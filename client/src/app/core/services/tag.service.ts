import { environment } from '../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ITagsResponse } from '@shared/responses/tags.response';
import { ITag } from '@shared/models/tag.model';
import { map } from 'rxjs/operators';
import { Status } from '@shared/enum';

@Injectable({
    providedIn: 'root'
})
export class TagService {

    constructor(private http: HttpClient) { }

    getTags(): Observable<ITagsResponse> {
        return this.http.get<ITagsResponse>(environment.apiUrl + 'tag')
            .pipe(
                map((response: ITagsResponse) => {
                  return {status: Status.SUCCESSFUL, data: response.data}
                })
              );
    }

}