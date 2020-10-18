// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'tags_store.dart';

// **************************************************************************
// StoreGenerator
// **************************************************************************

// ignore_for_file: non_constant_identifier_names, unnecessary_brace_in_string_interps, unnecessary_lambdas, prefer_expression_function_bodies, lines_longer_than_80_chars, avoid_as, avoid_annotating_with_dynamic

mixin _$TagsStore on _TagsStore, Store {
  Computed<bool> _$hasErrorComputed;

  @override
  bool get hasError => (_$hasErrorComputed ??=
          Computed<bool>(() => super.hasError, name: '_TagsStore.hasError'))
      .value;
  Computed<bool> _$isLoadingComputed;

  @override
  bool get isLoading => (_$isLoadingComputed ??=
          Computed<bool>(() => super.isLoading, name: '_TagsStore.isLoading'))
      .value;
  Computed<bool> _$hasResultsComputed;

  @override
  bool get hasResults => (_$hasResultsComputed ??=
          Computed<bool>(() => super.hasResults, name: '_TagsStore.hasResults'))
      .value;

  final _$fetchTagsFutureAtom = Atom(name: '_TagsStore.fetchTagsFuture');

  @override
  ObservableFuture<List<Tag>> get fetchTagsFuture {
    _$fetchTagsFutureAtom.reportRead();
    return super.fetchTagsFuture;
  }

  @override
  set fetchTagsFuture(ObservableFuture<List<Tag>> value) {
    _$fetchTagsFutureAtom.reportWrite(value, super.fetchTagsFuture, () {
      super.fetchTagsFuture = value;
    });
  }

  final _$fetchTagsAsyncAction = AsyncAction('_TagsStore.fetchTags');

  @override
  Future<dynamic> fetchTags() {
    return _$fetchTagsAsyncAction.run(() => super.fetchTags());
  }

  @override
  String toString() {
    return '''
fetchTagsFuture: ${fetchTagsFuture},
hasError: ${hasError},
isLoading: ${isLoading},
hasResults: ${hasResults}
    ''';
  }
}
