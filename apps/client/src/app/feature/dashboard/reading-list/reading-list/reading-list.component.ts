import { Component, OnInit } from '@angular/core';
import { ReadingListService } from '@core/services/reading-list.service';
import { ReadingList } from '@shared/models/reading-list.model';
import { Observable } from 'rxjs';

@Component({
  selector: 'reading-list',
  templateUrl: './reading-list.component.html',
  styleUrls: ['./reading-list.component.scss']
})
export class ReadingListComponent implements OnInit {
  readingLists$: Observable<ReadingList[]>;

  constructor(
    private readonly readingListService: ReadingListService
  ) { }

  ngOnInit(): void {
    this.readingLists$ = this.readingListService.getReadingLists();
  }

  deleteReadingList(readingListId: string) {
    this.readingListService.delete(readingListId).subscribe((hasBeenDeleted: boolean) => {
      hasBeenDeleted;
      // if(response.data) this.snackbar.openSnackBarSuccess("Article has been successful deleted");
    });
  }

}
