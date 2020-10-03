import 'dart:async';

import 'package:bloc/bloc.dart';
import 'package:client/datas/models/tag.dart';
import 'package:client/services/tag_service.dart';
import 'package:equatable/equatable.dart';
import 'package:meta/meta.dart';
import 'package:rxdart/rxdart.dart';

part 'list_tags_event.dart';
part 'list_tags_state.dart';

class ListTagsBloc extends Bloc<ListTagsEvent, ListTagsState> {
  final TagService tagService;

  ListTagsBloc({@required this.tagService})
      : super(ListTagsInitial());

  @override
  Stream<Transition<ListTagsEvent, ListTagsState>> transformEvents(
    Stream<ListTagsEvent> events,
    TransitionFunction<ListTagsEvent, ListTagsState> transitionFn,
  ) {
    return super.transformEvents(
      events.debounceTime(const Duration(milliseconds: 500)),
      transitionFn,
    );
  }

  @override
  Stream<ListTagsState> mapEventToState(ListTagsEvent event) async* {
    final currentState = state;
    print(event);

    if (event is TagsFetched) {
      try {
        if (currentState is ListTagsInitial) {
          print("=> ListTagsInitial");
          final tags = await _fetchTags();
          yield ListTagsSuccess(tags: tags);
          return;
        }
        if (currentState is ListTagsSuccess) {
          print("=> ListTagsSuccess");
          final tags = await _fetchTags();
          yield tags.isEmpty
              ? {ListTagsInitial(), print("!!!!! tags empty !!!!!")}
              : ListTagsSuccess(tags: currentState.tags + tags);
        }
      } catch (_) {
        yield ListTagsFailure();
      }
    }
  }

  Future<List<Tag>> _fetchTags() async {
    final tagsResponse = await tagService.getTags();
    return tagsResponse.tags;
  }
}
