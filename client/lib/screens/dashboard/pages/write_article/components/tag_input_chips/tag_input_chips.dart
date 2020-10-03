import 'package:client/datas/models/tag.dart';
import 'package:client/screens/dashboard/pages/write_article/components/tag_input_chips/bloc/list_tags_bloc.dart';
import 'package:client/services/tag_service.dart';
import 'package:flutter/material.dart';
import 'package:flutter_form_bloc/flutter_form_bloc.dart';
import 'package:flutter_tagging/flutter_tagging.dart';

class TagInputChips extends StatefulWidget {
  TagInputChips({Key key}) : super(key: key);

  @override
  _TagInputChipsState createState() => _TagInputChipsState();
}

class _TagInputChipsState extends State<TagInputChips> {
  List<Tag> _selectedTags;

  @override
  void initState() {
    _selectedTags = [];
    super.initState();
  }

  @override
  void dispose() {
    _selectedTags.clear();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return BlocProvider(
        create: (context) =>
            ListTagsBloc(tagService: TagService())..add(TagsFetched()),
        child: BlocBuilder<ListTagsBloc, ListTagsState>(
          builder: (context, state) {
            if (state is ListTagsInitial) {
              return Center(
                child: CircularProgressIndicator(),
              );
            }
            if (state is ListTagsFailure) {
              return Center(
                child: Text('failed to fetch tags'),
              );
            }
            if (state is ListTagsSuccess) {
              if (state.tags.isEmpty) {
                return Center(
                  child: Text('no tags'),
                );
              }
              return _buildTagInputChips(state.tags);
            }
          },
        ));
  }

  Widget _buildTagInputChips(List<Tag> tags) {
    return FlutterTagging<Tag>(
              initialItems: _selectedTags,
              textFieldConfiguration: TextFieldConfiguration(
                decoration: InputDecoration(
                  border: InputBorder.none,
                  filled: true,
                  fillColor: Colors.green.withAlpha(30),
                  hintText: 'Search Tags',
                  labelText: 'Select Tags',
                ),
              ),
              findSuggestions: (search) => tags.where((tag) => tag.name.toLowerCase().contains(search.toLowerCase())).toList(),
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
                    backgroundColor: Colors.green,
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
                setState(() {
                  // _selectedValuesJson = _selectedTags
                  //     .map<String>((lang) => '\n${lang.toJson()}')
                  //     .toList()
                  //     .toString();
                  // _selectedValuesJson =
                  //     _selectedValuesJson.replaceFirst('}]', '}\n]');
                });
              },
            );
  }
}
