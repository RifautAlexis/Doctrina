import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { TagService } from '@core/services/tag.service';
import { Tag } from '@shared/models/tag.model';
import { Observable } from 'rxjs';

@Component({
    selector: 'display-tags',
    templateUrl: 'display-tags.component.html'
})

export class DisplayTagsComponent implements OnInit {
    @Input() tags: Tag[];
    @Output() onClick = new EventEmitter<string>();
    tags$: Observable<Tag[]>;

    constructor(private readonly tagService: TagService) { }

    ngOnInit() {
        // this.tags$ = this.tagService.getTags();
    }
}