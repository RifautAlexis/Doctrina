import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReadingListsOverviewComponent } from './reading-lists-overview.component';

describe('ReadingListOverviewComponent', () => {
  let component: ReadingListsOverviewComponent;
  let fixture: ComponentFixture<ReadingListsOverviewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReadingListsOverviewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReadingListsOverviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
