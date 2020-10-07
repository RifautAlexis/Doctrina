import 'package:client/components/frame_page.dart';
import 'package:flutter/material.dart';

class Dashboard extends StatelessWidget {
  final Widget body;
  const Dashboard({Key key, @required this.body}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return FramePage(
        body: Row(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
      ConstrainedBox(
          constraints: BoxConstraints(maxWidth: 200, minHeight: MediaQuery.of(context).size.height),
          child: Container(
            margin: EdgeInsets.symmetric(horizontal: 10.0),
              decoration:
                  BoxDecoration(border: Border(right: BorderSide(width: 1.5))),
              child: ListView(
                padding: EdgeInsets.zero,
                shrinkWrap: true,
                children: <Widget>[
                  ListTile(
                      title: Center(child: Text('Write a new article')),
                      onTap: () =>
                          Navigator.of(context).pushNamed('/dashboard/write')),
                ],
              ))),
      Expanded(child: Container(margin: EdgeInsets.only(left: 20.0), child: body))
    ]));
  }
}