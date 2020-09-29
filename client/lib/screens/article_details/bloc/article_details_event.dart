part of 'article_details_bloc.dart';

abstract class ArticleDetailsEvent extends Equatable {
  const ArticleDetailsEvent();

  @override
  List<Object> get props => [];
}

class ArticleDetailsFetched extends ArticleDetailsEvent {
  final int articleId;
  const ArticleDetailsFetched(this.articleId);

  @override
  List<Object> get props => [articleId];

  @override
  String toString() => 'TodoDeleted { todo: $articleId }';
}
