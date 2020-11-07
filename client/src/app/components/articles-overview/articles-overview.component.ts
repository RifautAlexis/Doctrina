import { Component, Input, OnInit } from '@angular/core';
import { IArticle } from '../../shared/models/article.model';

@Component({
    selector: 'articles-overview',
    templateUrl: 'articles-overview.component.html',
    styleUrls: ['./articles-overview.component.scss']
})

export class ArticlesOverviewComponent implements OnInit {
    @Input() articles: IArticle[];

    constructor() { }

    ngOnInit() { }
}