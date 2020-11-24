import { Component, Input, OnInit } from '@angular/core';
import { ITag } from '@shared/models/tag.model';

@Component({
    selector: 'display-tags',
    templateUrl: 'display-tags.component.html'
})

export class DisplayTagsComponent implements OnInit {
    @Input() tags: ITag[];

    constructor() { }

    ngOnInit() { }
}