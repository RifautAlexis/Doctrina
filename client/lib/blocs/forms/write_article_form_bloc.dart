import 'package:client/services/article_service.dart';
import 'package:flutter/material.dart';
import 'package:flutter_form_bloc/flutter_form_bloc.dart';

class WriteArticleFormBloc extends FormBloc<String, String> {
  ArticleService articleService;

  final titleInput =
      TextFieldBloc<String>(validators: [FieldBlocValidators.required]);
  final descriptionInput =
      TextFieldBloc<String>(validators: [FieldBlocValidators.required]);
  final contentInput =
      TextFieldBloc<String>(validators: [FieldBlocValidators.required]);

  WriteArticleFormBloc({@required this.articleService}) {
    addFieldBlocs(fieldBlocs: [titleInput, descriptionInput, contentInput]);
  }

  void dispose() {
    titleInput.close();
    descriptionInput.close();
    contentInput.close();
  }

  @override
  void onSubmitting() {
    print(titleInput.value);
    print(descriptionInput.value);
    print(contentInput.value);
    // try {
    //   articleService.createArticle("title");

    //   emitSuccess(canSubmitAgain: false);
    // } catch (e) {
    //   emitFailure();
    // }
  }
}
