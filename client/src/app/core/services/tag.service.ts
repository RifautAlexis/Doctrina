import { environment } from '../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { TagsResponse } from '@shared/responses/tags.response';
import { Tag } from '@shared/models/tag.model';
import { map } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
})
export class TagService {

    constructor(private http: HttpClient) { }

    getTags(): Observable<Tag[]> {
        return this.http.get<TagsResponse>(environment.apiUrl + 'tag')
            .pipe(
                map((response: TagsResponse) => {
                  return response.data;
                })
              );
    }

}