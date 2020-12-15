import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReadingList } from '@shared/models/reading-list.model';
import { Observable } from 'rxjs';
import { ReadingListsResponse } from '@shared/responses/reading-lists.response';
import { ReadingListResponse } from '@shared/responses/reading-list.response';
import { environment } from 'src/environments/environment';
import { map } from 'rxjs/operators';
import { BooleanResponse } from '@shared/responses/boolean.response';
import { IdResponse } from '@shared/responses/id.response';
import { ReadingListCreate } from '@shared/models/reading-list-create.model';
import { ReadingListEdit } from '@shared/models/reading-list-edit.model';

@Injectable({
  providedIn: 'root'
})
export class ReadingListService {

  constructor(private http: HttpClient) { }

  getReadingLists(): Observable<ReadingList[]> {
    return this.http.get<ReadingListsResponse>(environment.apiUrl + 'readingList')
      .pipe(
        map((response: ReadingListsResponse) => {
          return response.data;
        })
      );
  }

  getReadingList(readingListId: string): Observable<ReadingList> {
    return this.http.get<ReadingListResponse>(environment.apiUrl + 'readingList/' + readingListId)
    .pipe(
      map((response: ReadingListResponse) => {
        return response.data;
      })
    );
  }

  isUniqueName(name: string, readingListId?: string): Observable<boolean> {
    return this.http.post<BooleanResponse>(environment.apiUrl + 'readingList/isUniqueName', {
      "name": name,
      "readingListId": readingListId
    })
      .pipe(
        map((response: BooleanResponse) => {
          return response.data;
        })
      );
  }

  createReadingList(readingListIdToAdd: ReadingListCreate): Observable<number> {
    return this.http.post<IdResponse>(environment.apiUrl + 'readingList', readingListIdToAdd)
      .pipe(
        map((response: IdResponse) => {
          return response.data;
        })
      );
  }

  editReadingList(readingListToEdit: ReadingListEdit): Observable<number> {
    return this.http.put<IdResponse>(environment.apiUrl + 'readingList/' + readingListToEdit.id, readingListToEdit)
      .pipe(
        map((response: IdResponse) => {
          return response.data;
        })
      );
  }

  delete(readingListId: string): Observable<boolean> {
    return this.http.delete<BooleanResponse>(environment.apiUrl + 'readingList/' + readingListId)
    .pipe(
      map((response: BooleanResponse) => {
        return response.data;
      })
    );
  }
}
