import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
// import { ReadingListValidator } from '@shared/validators/reading-list.validator';
import { ReadingListForm } from '../../models/reading-list-form.model';
import { ArticleMinimal } from '@shared/models/article-minimal.model';
import { CdkDragDrop, moveItemInArray, transferArrayItem } from '@angular/cdk/drag-drop';
import { ReadingListEdit } from '@shared/models/reading-list-edit.model';

@Component({
  selector: 'add-edit-reading-list',
  templateUrl: './add-edit-reading-list.component.html',
  styleUrls: ['./add-edit-reading-list.component.scss']
})
export class AddEditReadingListComponent implements OnInit {

  @Input() readingListToEdit?: ReadingListEdit;
  @Input() articles?: ArticleMinimal[];
  @Output() onReadingListSubmited = new EventEmitter<ReadingListForm>();

  readingListForm: FormGroup
  // articlesInReadingList: ArticleMinimal[] = this.readingListToEdit?.articleIds ? this.readingListToEdit?.articleIds : [];

  constructor(
    public formBuilder: FormBuilder,
    // private readingListValidator: ReadingListValidator
  ) { }

  ngOnInit(): void {
    this.buildReadingListForm();
  }

  submit() {
    // if (this.readingListForm.invalid) return;

    // const controls = this.readingListForm.controls;
    // const name: string = controls.name.value;
    // const description: string = controls.description.value;
    // const articleIds: number[] = ;

    // const readingList: ReadingListForm = {
    //   name: name,
    //   description: description,
    //   articleIds: articleIds,
    // }

    // this.onReadingListSubmited.emit(readingList);
  }

  drop(event: CdkDragDrop<string[]>) {
    if (event.previousContainer === event.container) {
      moveItemInArray(event.container.data, event.previousIndex, event.currentIndex);
    } else {
      transferArrayItem(
        event.previousContainer.data,
        event.container.data,
        event.previousIndex,
        event.currentIndex
      );
    }
  }

  private buildReadingListForm(): void {
    this.readingListForm = this.formBuilder.group({
      title: [this.readingListToEdit === undefined ? "" : this.readingListToEdit.name,
      [Validators.required],
      [
        // this.readingListValidator.IsUniqueNameValidator(this.readingListToEdit?.id)
      ]
      ],
      content: [this.readingListToEdit === undefined ? "" : this.readingListToEdit.description,
      Validators.required],
      description: [this.readingListToEdit === undefined ? "" : this.readingListToEdit.articleIds,
      Validators.required]
    });
  }

}
