import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { TagService } from '@core/services/tag.service';
import { ITag } from '@shared/models/tag.model';
import { Observable } from 'rxjs';

@Component({
    selector: 'display-tags',
    templateUrl: 'display-tags.component.html'
})

export class DisplayTagsComponent implements OnInit {
    @Input() tags: ITag[];
    @Output() onClick = new EventEmitter<string>();
    tags$: Observable<ITag[]>;

    constructor(private readonly tagService: TagService) { }

    ngOnInit() {
        // this.tags$ = this.tagService.getTags();
    }
}