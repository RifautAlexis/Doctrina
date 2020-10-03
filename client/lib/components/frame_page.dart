import 'package:client/components/header_frame_page.dart';
import "package:flutter/material.dart";

class FramePage extends StatelessWidget {
  final Drawer drawer;
  final Widget body;

  const FramePage({Key key, @required this.body, this.drawer}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    HeaderFramePage header = HeaderFramePage();
    // returnBlocBuilder<AuthenticationBloc, AuthenticationState>(
    //   builder: (context, state) {
        return Scaffold(
          appBar: header,
          body: Padding(padding: EdgeInsets.all(15.0), child: body),
          drawer: drawer,
        );
    //   }
    // );
  }
}