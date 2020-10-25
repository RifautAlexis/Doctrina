import 'package:client/components/snackbar.dart';
import 'package:client/datas/http_error.dart';
import 'package:client/datas/models/tag.dart';
import 'package:client/screens/dashboard/pages/write_article/mobx/form_write_article_error_state.dart';
import 'package:client/services/article_service.dart';
import 'package:flutter/material.dart';
import 'package:mobx/mobx.dart';
import 'package:validators/validators.dart';

part 'form_write_article_store.g.dart';

class FormWriteArticleStore = _FormWriteArticleStore
    with _$FormWriteArticleStore;

abstract class _FormWriteArticleStore with Store {
  _FormWriteArticleStore({@required this.articleService});

  final ArticleService articleService;

  @observable
  String title = '';

  @observable
  String description = '';

  @observable
  String content = '';

  @observable
  List<Tag> selectedTags = [];

  @computed
  bool get hasNoContent => isNull(content) || content.isEmpty;

  @computed
  bool get canSubmit => !error.hasErrors;

  final FormWriteArticleErrorState error = FormWriteArticleErrorState();

  @observable
  ObservableFuture<bool> isUniqueTitleFuture = ObservableFuture.value(true);

  @computed
  bool get isTitleCheckPending =>
      isUniqueTitleFuture.status == FutureStatus.pending;

  @observable
  ObservableFuture<int> createArticleFuture = ObservableFuture.value(null);

  @computed
  bool get createArticlePending =>
      createArticleFuture.status == FutureStatus.pending;

  @computed
  bool get createArticleError =>
      createArticleFuture.status == FutureStatus.rejected;

  @computed
  bool get createArticleSuccessful =>
      createArticleFuture.status == FutureStatus.fulfilled;

  @action
  Future<void> validateTitle() async {
    if (isNull(title) || title.isEmpty) {
      error.title = 'Cannot be empty';
      return;
    }

    try {
      isUniqueTitleFuture =
          ObservableFuture(articleService.isUniqueTitle(title));
      error.title = null;

      final isUniqueTitle = await isUniqueTitleFuture;
      if (!isUniqueTitle) {
        error.title = 'This title is already taken';
        return;
      }
    } on HttpError catch (failure) {
      error.title = null;
      Snackbar.createError(message: failure.errorMesage);
    } catch (failure) {
      error.title = null;
      Snackbar.createError();
    }
    error.title = null;
  }

  @action
  Future<void> resetAllFields() async {
    title = '';
    description = '';
    content = '';
    selectedTags = [];
  }

  @action
  void validateDescription() {
    error.description =
        isNull(description) || description.isEmpty ? 'Cannot be empty' : null;
  }

  @action
  void validateContent() {
    error.content =
        isNull(content) || content.isEmpty ? 'Cannot be empty' : null;
  }

  @action
  void validateSelectedTags() {
    error.selectedTags = selectedTags.length <= 0 ? 'Cannot be empty' : null;
  }

  @action
  Future<bool> validateAllFields() async {
    await validateTitle();
    validateDescription();
    validateContent();
    validateSelectedTags();
    return !error.hasErrors;
  }

  @action
  Future<void> createArticle() async {
    var tagIds = selectedTags.map((e) => e.id).toList();

    try {
      createArticleFuture = ObservableFuture(
          articleService.createArticle(title, description, content, tagIds));
      await createArticleFuture;
    } on HttpError catch (failure) {
      Snackbar.createError(message: failure.errorMesage);
    } catch (failure) {
      Snackbar.createError();
    }
  }
}
