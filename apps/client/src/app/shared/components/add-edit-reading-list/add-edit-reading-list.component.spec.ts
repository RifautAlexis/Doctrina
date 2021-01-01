import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEditReadingListComponent } from './add-edit-reading-list.component';

describe('AddEditReadingListComponent', () => {
  let component: AddEditReadingListComponent;
  let fixture: ComponentFixture<AddEditReadingListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddEditReadingListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddEditReadingListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
