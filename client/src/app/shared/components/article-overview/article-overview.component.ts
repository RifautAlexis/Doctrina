import { Component, Input, OnInit } from '@angular/core';
import { IArticle } from '../../models/article.model';

@Component({
    selector: 'article-overview',
    templateUrl: 'article-overview.component.html'
})

export class ArticleOverviewComponent implements OnInit {
    @Input() article: IArticle;

    constructor() { }

    ngOnInit() { }
}