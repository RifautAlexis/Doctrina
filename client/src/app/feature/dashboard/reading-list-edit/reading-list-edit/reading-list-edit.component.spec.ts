import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReadingListEditComponent } from './reading-list-edit.component';

describe('EditReadingListComponent', () => {
  let component: ReadingListEditComponent;
  let fixture: ComponentFixture<ReadingListEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReadingListEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReadingListEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
