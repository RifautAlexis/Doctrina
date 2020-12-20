import { Component, EventEmitter, Input, Output } from '@angular/core';
import { ReadingList } from '@shared/models/reading-list.model';

@Component({
  selector: 'reading-lists-overview',
  templateUrl: './reading-lists-overview.component.html',
  styleUrls: ['./reading-lists-overview.component.scss']
})
export class ReadingListsOverviewComponent {
  @Input() readingLists: ReadingList[];
  @Input() isAdmin: boolean = false;

  @Output() onDeleteReadingList = new EventEmitter<string>();

  deleteReadingList(readingListId: string) {
      this.onDeleteReadingList.emit(readingListId);
  }

}
