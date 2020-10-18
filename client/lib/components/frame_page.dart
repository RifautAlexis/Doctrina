import 'package:client/components/header_frame_page.dart';
import 'package:client/mobx/authentication_store.dart';
import "package:flutter/material.dart";
import 'package:provider/provider.dart';

class FramePage extends StatelessWidget {
  final Widget body;

  const FramePage({Key key, @required this.body}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    HeaderFramePage header = HeaderFramePage();
    return Scaffold(
        appBar: header,
        body: Padding(padding: EdgeInsets.all(15.0), child: body));
  }
}
