part of 'list_tags_bloc.dart';

@immutable
abstract class ListTagsState extends Equatable {
  const ListTagsState();

  @override
  List<Object> get props => [];
}

class ListTagsInitial extends ListTagsState {}

class ListTagsFailure extends ListTagsState {}

class ListArticlesLoadInProgress extends ListTagsState {}

class ListTagsSuccess extends ListTagsState {
  final List<Tag> tags;

  const ListTagsSuccess({this.tags});

  @override
  List<Object> get props => [tags];

  @override
  String toString() => 'ListTagLoadSuccess { tags: $tags }';
}