import { Component, OnInit } from '@angular/core';
import { ReadingListService } from '@core/services/reading-list.service';
import { ReadingList } from '@shared/models/reading-list.model';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-reading-lists',
  templateUrl: './reading-lists.component.html',
  styleUrls: ['./reading-lists.component.scss']
})
export class ReadingListsComponent implements OnInit {

  readingLists$: Observable<ReadingList[]>

  constructor(
    private readonly readingListService: ReadingListService
  ) { }

  ngOnInit(): void {
    this.readingLists$ = this.readingListService.getReadingLists();
  }

}
