import 'package:client/datas/models/tag.dart';
import 'package:client/services/tag_service.dart';
import 'package:flutter/material.dart';
import 'package:mobx/mobx.dart';

part 'tags_store.g.dart';

class TagsStore = _TagsStore with _$TagsStore;

abstract class _TagsStore with Store {
  _TagsStore({@required this.tagService});

  final TagService tagService;

  List<Tag> tags = [];

  @observable
  ObservableFuture<List<Tag>> fetchTagsFuture = emptyResponse;

  @computed
  bool get hasError =>
      fetchTagsFuture.status == FutureStatus.rejected;

  @computed
  bool get isLoading =>
      fetchTagsFuture.status == FutureStatus.pending;

  @computed
  bool get hasResults =>
      fetchTagsFuture != emptyResponse &&
      fetchTagsFuture.status == FutureStatus.fulfilled;

  static ObservableFuture<List<Tag>> emptyResponse =
      ObservableFuture.value([]);

  @action
  Future fetchTags() async {
    final tags = tagService.getTags();
    fetchTagsFuture = ObservableFuture(tags);

    this.tags = await tags;
  }
}
