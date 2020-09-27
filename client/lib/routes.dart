import 'package:client/screens/home/home.dart';
import 'package:flutter/material.dart';

final routes = <String, WidgetBuilder>{
  '/' :                             (BuildContext context) => Home(),
  // '/login':                         (BuildContext context) => Login(),
  // '/signup':                        (BuildContext context) => Signup(),
  // '/door':                          (BuildContext context) => Door(),
  // '/home':                          (BuildContext context) => Home(),
  // '/chat':                          (BuildContext context) => Chat(arguments: ModalRoute.of(context).settings.arguments),
  // '/chat/progression':              (BuildContext context) => Progression(arguments: ModalRoute.of(context).settings.arguments),
  // '/chat/progression/attributeChallenge': (BuildContext context) => AttributeChallenge(arguments: ModalRoute.of(context).settings.arguments),
  // '/profile':                       (BuildContext context) => Profile(arguments: ModalRoute.of(context).settings.arguments),
  // '/changePassword':                (BuildContext context) => ChangePassword(),
  // '/groups':                        (BuildContext context) => Groups(),
  // '/groups/details':                (BuildContext context) => GroupDetails(arguments: ModalRoute.of(context).settings.arguments),
  // '/group/create':                  (BuildContext context) => CreateGroup(),
  // '/myGroup':                       (BuildContext context) => MyGroup(arguments: ModalRoute.of(context).settings.arguments),
  // '/myGroup/edit':                  (BuildContext context) => EditGroup(arguments: ModalRoute.of(context).settings.arguments),
  // '/admin/challenge':               (BuildContext context) => AdminChallenge(),
  // '/admin/challenge/add':           (BuildContext context) => AddChallenge(),
  // '/admin/challenge/edit':          (BuildContext context) => EditChallenge(arguments: ModalRoute.of(context).settings.arguments),
  // '/admin/user':                    (BuildContext context) => UserManagement(),
  // '/admin/user/userInfo':           (BuildContext context) => UserInfo(arguments: ModalRoute.of(context).settings.arguments),
  // '/admin/group':                   (BuildContext context) => GroupManagement(),
  // '/admin/group/details':           (BuildContext context) => AdminGroupDetails(arguments: ModalRoute.of(context).settings.arguments),
  // '/' :                             (BuildContext context) => Door(),
};
