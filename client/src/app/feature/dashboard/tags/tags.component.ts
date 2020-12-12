import { Component, OnInit } from '@angular/core';
import { TagService } from '@core/services/tag.service';
import { Tag } from '@shared/models/tag.model';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-tags',
  templateUrl: './tags.component.html',
  styleUrls: ['./tags.component.scss']
})
export class TagsComponent implements OnInit {

  tags$: Observable<Tag[]>;

  constructor(
    private tagService: TagService
  ) { }

  ngOnInit(): void {
    this.tags$ = this.tagService.getTags();
  }

}
