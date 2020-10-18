import 'package:mobx/mobx.dart';

part 'form_write_article_error_state.g.dart';

class FormWriteArticleErrorState = _FormWriteArticleErrorState with _$FormWriteArticleErrorState;

abstract class _FormWriteArticleErrorState with Store {
  @observable
  String title;

  @observable
  String description;

  @observable
  String content;

  @observable
  String selectedTags;

  @computed
  bool get hasErrors => title != null || description != null || content != null || selectedTags != null;
}
