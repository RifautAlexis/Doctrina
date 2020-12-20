import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReadingListAddComponent } from './reading-list-add.component';

describe('ReadingListAddComponent', () => {
  let component: ReadingListAddComponent;
  let fixture: ComponentFixture<ReadingListAddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReadingListAddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReadingListAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
