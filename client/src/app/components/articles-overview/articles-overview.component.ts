import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IArticle } from '@shared/models/article.model';

@Component({
    selector: 'articles-overview',
    templateUrl: 'articles-overview.component.html',
    styleUrls: ['./articles-overview.component.scss']
})

export class ArticlesOverviewComponent implements OnInit {
    @Input() articles: IArticle[];
    @Input() isAdmin: boolean = false;

    @Output() deleteArticleIdEvent = new EventEmitter<string>();

    constructor() { }

    ngOnInit() { }

    deleteArticle(articleId: string) {
        this.deleteArticleIdEvent.emit(articleId);
    }
}