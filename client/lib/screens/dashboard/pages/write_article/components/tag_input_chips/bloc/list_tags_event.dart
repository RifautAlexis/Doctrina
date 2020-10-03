part of 'list_tags_bloc.dart';

abstract class ListTagsEvent extends Equatable {
  const ListTagsEvent();

  @override
  List<Object> get props => [];
}

class TagsFetched extends ListTagsEvent {}