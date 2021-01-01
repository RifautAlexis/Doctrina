import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Article } from '@shared/models/article.model';

@Component({
    selector: 'articles-overview',
    templateUrl: 'articles-overview.component.html',
    styleUrls: ['./articles-overview.component.scss']
})

export class ArticlesOverviewComponent {
    @Input() articles: Article[];
    @Input() isAdmin: boolean = false;

    @Output() deleteArticleIdEvent = new EventEmitter<string>();

    deleteArticle(articleId: string) {
        this.deleteArticleIdEvent.emit(articleId);
    }
}