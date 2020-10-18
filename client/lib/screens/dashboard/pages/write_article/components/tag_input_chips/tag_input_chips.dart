import 'package:client/datas/models/tag.dart';
import 'package:client/mobx/tags_store.dart';
import 'package:client/screens/dashboard/pages/write_article/mobx/form_write_article_store.dart';
import 'package:flutter/material.dart';
import 'package:flutter_mobx/flutter_mobx.dart';
import 'package:flutter_tagging/flutter_tagging.dart';
import 'package:provider/provider.dart';

class TagInputChips extends StatefulWidget {
  TagInputChips({Key key}) : super(key: key);

  @override
  _TagInputChipsState createState() => _TagInputChipsState();
}

class _TagInputChipsState extends State<TagInputChips> {

  @override
  void initState() {
    super.initState();
  }

  @override
  void dispose() {
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    final tagsStore = Provider.of<TagsStore>(context);
    final formAWStore = Provider.of<FormWriteArticleStore>(context);

    return Observer(
        builder: (_) => FlutterTagging<Tag>(
              initialItems: formAWStore.selectedTags,
              textFieldConfiguration: TextFieldConfiguration(
                decoration: InputDecoration(
                  border: InputBorder.none,
                  filled: true,
                  fillColor: Colors.green.withAlpha(30),
                  hintText: 'Search Tags',
                  labelText: 'Select Tags',
                ),
              ),
              findSuggestions: (search) => tagsStore.tags
                  .where((tag) =>
                      tag.name.toLowerCase().contains(search.toLowerCase()))
                  .toList(),
              additionCallback: (value) {
                return Tag(
                  0,
                  value,
                  DateTime.now(),
                  DateTime.now(),
                );
              },
              configureSuggestion: (tag) {
                return SuggestionConfiguration(
                  title: Text(tag.name),
                  additionWidget: Chip(
                    avatar: Icon(
                      Icons.add_circle,
                      color: Colors.white,
                    ),
                    label: Text('Add New Tag'),
                    labelStyle: TextStyle(
                      color: Colors.white,
                      fontSize: 14.0,
                      fontWeight: FontWeight.w300,
                    ),
                    backgroundColor: Colors.pink,
                  ),
                );
              },
              configureChip: (tag) {
                return ChipConfiguration(
                  label: Text(tag.name),
                  backgroundColor: Colors.green,
                  labelStyle: TextStyle(color: Colors.white),
                  deleteIconColor: Colors.white,
                );
              },
              onChanged: () {
                  print(formAWStore.selectedTags);
              },
            ));
  }
}
