part of 'article_details_bloc.dart';

@immutable
abstract class ArticleDetailsState extends Equatable {
  const ArticleDetailsState();

  @override
  List<Object> get props => [];
}

class ArticleDetailsInitial extends ArticleDetailsState {}

class ArticleDetailsFailure extends ArticleDetailsState {}

class ArticleDetailsLoadInProgress extends ArticleDetailsState {}

class ArticleDetailsSuccess extends ArticleDetailsState {
  final Article article;

  const ArticleDetailsSuccess({this.article});

  @override
  List<Object> get props => [article];

  @override
  String toString() => 'ArticleDetailsLoadSuccess { article: $article }';
}