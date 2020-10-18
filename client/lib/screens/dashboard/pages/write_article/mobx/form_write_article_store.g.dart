// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'form_write_article_store.dart';

// **************************************************************************
// StoreGenerator
// **************************************************************************

// ignore_for_file: non_constant_identifier_names, unnecessary_brace_in_string_interps, unnecessary_lambdas, prefer_expression_function_bodies, lines_longer_than_80_chars, avoid_as, avoid_annotating_with_dynamic

mixin _$FormWriteArticleStore on _FormWriteArticleStore, Store {
  Computed<bool> _$hasNoContentComputed;

  @override
  bool get hasNoContent =>
      (_$hasNoContentComputed ??= Computed<bool>(() => super.hasNoContent,
              name: '_FormWriteArticleStore.hasNoContent'))
          .value;
  Computed<bool> _$canSubmitComputed;

  @override
  bool get canSubmit =>
      (_$canSubmitComputed ??= Computed<bool>(() => super.canSubmit,
              name: '_FormWriteArticleStore.canSubmit'))
          .value;
  Computed<bool> _$isTitleCheckPendingComputed;

  @override
  bool get isTitleCheckPending => (_$isTitleCheckPendingComputed ??=
          Computed<bool>(() => super.isTitleCheckPending,
              name: '_FormWriteArticleStore.isTitleCheckPending'))
      .value;
  Computed<bool> _$createArticlePendingComputed;

  @override
  bool get createArticlePending => (_$createArticlePendingComputed ??=
          Computed<bool>(() => super.createArticlePending,
              name: '_FormWriteArticleStore.createArticlePending'))
      .value;
  Computed<bool> _$createArticleErrorComputed;

  @override
  bool get createArticleError => (_$createArticleErrorComputed ??=
          Computed<bool>(() => super.createArticleError,
              name: '_FormWriteArticleStore.createArticleError'))
      .value;
  Computed<bool> _$createArticleSuccessfulComputed;

  @override
  bool get createArticleSuccessful => (_$createArticleSuccessfulComputed ??=
          Computed<bool>(() => super.createArticleSuccessful,
              name: '_FormWriteArticleStore.createArticleSuccessful'))
      .value;

  final _$titleAtom = Atom(name: '_FormWriteArticleStore.title');

  @override
  String get title {
    _$titleAtom.reportRead();
    return super.title;
  }

  @override
  set title(String value) {
    _$titleAtom.reportWrite(value, super.title, () {
      super.title = value;
    });
  }

  final _$descriptionAtom = Atom(name: '_FormWriteArticleStore.description');

  @override
  String get description {
    _$descriptionAtom.reportRead();
    return super.description;
  }

  @override
  set description(String value) {
    _$descriptionAtom.reportWrite(value, super.description, () {
      super.description = value;
    });
  }

  final _$contentAtom = Atom(name: '_FormWriteArticleStore.content');

  @override
  String get content {
    _$contentAtom.reportRead();
    return super.content;
  }

  @override
  set content(String value) {
    _$contentAtom.reportWrite(value, super.content, () {
      super.content = value;
    });
  }

  final _$selectedTagsAtom = Atom(name: '_FormWriteArticleStore.selectedTags');

  @override
  List<Tag> get selectedTags {
    _$selectedTagsAtom.reportRead();
    return super.selectedTags;
  }

  @override
  set selectedTags(List<Tag> value) {
    _$selectedTagsAtom.reportWrite(value, super.selectedTags, () {
      super.selectedTags = value;
    });
  }

  final _$isUniqueTitleFutureAtom =
      Atom(name: '_FormWriteArticleStore.isUniqueTitleFuture');

  @override
  ObservableFuture<bool> get isUniqueTitleFuture {
    _$isUniqueTitleFutureAtom.reportRead();
    return super.isUniqueTitleFuture;
  }

  @override
  set isUniqueTitleFuture(ObservableFuture<bool> value) {
    _$isUniqueTitleFutureAtom.reportWrite(value, super.isUniqueTitleFuture, () {
      super.isUniqueTitleFuture = value;
    });
  }

  final _$createArticleFutureAtom =
      Atom(name: '_FormWriteArticleStore.createArticleFuture');

  @override
  ObservableFuture<int> get createArticleFuture {
    _$createArticleFutureAtom.reportRead();
    return super.createArticleFuture;
  }

  @override
  set createArticleFuture(ObservableFuture<int> value) {
    _$createArticleFutureAtom.reportWrite(value, super.createArticleFuture, () {
      super.createArticleFuture = value;
    });
  }

  final _$validateTitleAsyncAction =
      AsyncAction('_FormWriteArticleStore.validateTitle');

  @override
  Future<void> validateTitle() {
    return _$validateTitleAsyncAction.run(() => super.validateTitle());
  }

  final _$resetAllFieldsAsyncAction =
      AsyncAction('_FormWriteArticleStore.resetAllFields');

  @override
  Future<void> resetAllFields() {
    return _$resetAllFieldsAsyncAction.run(() => super.resetAllFields());
  }

  final _$validateAllFieldsAsyncAction =
      AsyncAction('_FormWriteArticleStore.validateAllFields');

  @override
  Future<bool> validateAllFields() {
    return _$validateAllFieldsAsyncAction.run(() => super.validateAllFields());
  }

  final _$createArticleAsyncAction =
      AsyncAction('_FormWriteArticleStore.createArticle');

  @override
  Future<void> createArticle() {
    return _$createArticleAsyncAction.run(() => super.createArticle());
  }

  final _$_FormWriteArticleStoreActionController =
      ActionController(name: '_FormWriteArticleStore');

  @override
  void validateDescription() {
    final _$actionInfo = _$_FormWriteArticleStoreActionController.startAction(
        name: '_FormWriteArticleStore.validateDescription');
    try {
      return super.validateDescription();
    } finally {
      _$_FormWriteArticleStoreActionController.endAction(_$actionInfo);
    }
  }

  @override
  void validateContent() {
    final _$actionInfo = _$_FormWriteArticleStoreActionController.startAction(
        name: '_FormWriteArticleStore.validateContent');
    try {
      return super.validateContent();
    } finally {
      _$_FormWriteArticleStoreActionController.endAction(_$actionInfo);
    }
  }

  @override
  void validateSelectedTags() {
    final _$actionInfo = _$_FormWriteArticleStoreActionController.startAction(
        name: '_FormWriteArticleStore.validateSelectedTags');
    try {
      return super.validateSelectedTags();
    } finally {
      _$_FormWriteArticleStoreActionController.endAction(_$actionInfo);
    }
  }

  @override
  String toString() {
    return '''
title: ${title},
description: ${description},
content: ${content},
selectedTags: ${selectedTags},
isUniqueTitleFuture: ${isUniqueTitleFuture},
createArticleFuture: ${createArticleFuture},
hasNoContent: ${hasNoContent},
canSubmit: ${canSubmit},
isTitleCheckPending: ${isTitleCheckPending},
createArticlePending: ${createArticlePending},
createArticleError: ${createArticleError},
createArticleSuccessful: ${createArticleSuccessful}
    ''';
  }
}
