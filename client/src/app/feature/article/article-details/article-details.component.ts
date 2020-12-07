import { formatDate } from '@angular/common';
import { Component, Input, OnInit } from '@angular/core';
import { IArticle } from '@shared/models/article.model';

@Component({
    selector: 'article-details',
    templateUrl: 'article-details.component.html',
    styleUrls: ["article-details.component.scss"]
})

export class ArticleDetailsComponent implements OnInit {
    @Input() article: IArticle;

    isUpdated: boolean

    constructor() { }

    ngOnInit() {
        this.isUpdated = this.article.createdAt < this.article.updatedAt;
    }
}