import { environment } from '../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { TagsResponse } from '@shared/responses/tags.response';
import { Tag } from '@shared/models/tag.model';
import { map } from 'rxjs/operators';
import { BooleanResponse } from '@shared/responses/boolean.response';

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

    isUniqueName(name: string, tagId?: string): Observable<boolean> {
      return this.http.post<BooleanResponse>(environment.apiUrl + 'tag/isUniqueName', {
        "name": name,
        "tagId": tagId
      })
        .pipe(
          map((response: BooleanResponse) => {
            return response.data;
          })
        );
    }

}