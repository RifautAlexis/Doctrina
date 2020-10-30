import { environment } from '../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ITagsResponse } from '@shared/responses/tags.response';
import { ITag } from '@shared/models/tag.model';
import { map } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
})
export class TagService {

    constructor(private http: HttpClient) { }

    getArticles(): Observable<ITag[]> {
        return this.http.get<ITagsResponse>(environment.apiUrl + 'tag')
            .pipe(
                map((response: ITagsResponse) => response.tags)
            );
    }

}