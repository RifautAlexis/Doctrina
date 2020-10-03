import 'package:client/blocs/forms/write_article_form_bloc.dart';
import 'package:client/screens/dashboard/pages/write_article/components/tag_input_chips/tag_input_chips.dart';
import 'package:flutter/material.dart';
import 'package:flutter_form_bloc/flutter_form_bloc.dart';

class FormWriteArticle extends StatelessWidget {
  final WriteArticleFormBloc writeArticleFormBloc;

  FormWriteArticle({Key key, @required this.writeArticleFormBloc}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      child: Column(
        children: [
          TextFieldBlocBuilder(
            textFieldBloc: this.writeArticleFormBloc.titleInput,
            decoration: InputDecoration(
              labelText: 'Title',
              prefixIcon: Icon(Icons.text_fields),
            ),
          ),
          TextFieldBlocBuilder(
            textFieldBloc: writeArticleFormBloc.descriptionInput,
            decoration: InputDecoration(
              labelText: 'Description',
              prefixIcon: Icon(Icons.text_fields),
            )
          ),
          TextFieldBlocBuilder(
            maxLines: null,
            keyboardType: TextInputType.multiline,
            textFieldBloc: writeArticleFormBloc.contentInput,
            decoration: InputDecoration(
              labelText: 'Content',
              prefixIcon: Icon(Icons.text_fields),
            ),
            onChanged: (newValue) {print(writeArticleFormBloc.contentInput.value);},
          ),
          TagInputChips(),
          FloatingActionButton.extended(
            onPressed: writeArticleFormBloc.submit,
            icon: Icon(Icons.send),
            label: Text('SUBMIT'),
          ),
        ],
      ),
    );
  }
}
