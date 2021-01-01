import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ReadingListService } from '@core/services/reading-list.service';
import { ReadingListEdit } from '@shared/models/reading-list-edit.model';
import { ReadingList } from '@shared/models/reading-list.model';
import { Observable } from 'rxjs';

@Component({
  selector: 'edit-reading-list',
  templateUrl: './reading-list-edit.component.html',
  styleUrls: ['./reading-list-edit.component.scss']
})
export class ReadingListEditComponent implements OnInit {

  readingList$: Observable<ReadingList>;
  readingListId: string;

  constructor(
    private readonly readingListService: ReadingListService,
    private readonly activatedRoute: ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.readingListId = this.activatedRoute.snapshot.paramMap.get("id");
    this.readingList$ = this.readingListService.getReadingList(this.readingListId);
  }

  editArticle(readingListToEdit: ReadingListEdit) {
    this.readingListService.editReadingList(readingListToEdit).subscribe((readingListId: number) => {
      readingListId;
      // Snackbar
    })
  }

}
