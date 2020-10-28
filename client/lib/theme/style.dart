import 'package:flutter/material.dart';

final ThemeData appTheme = ThemeData(
  primarySwatch: MaterialColor(0xff1565C0, {
    50: Color.fromRGBO(21, 101, 192, .1),
    100: Color.fromRGBO(21, 101, 192, .2),
    200: Color.fromRGBO(21, 101, 192, .3),
    300: Color.fromRGBO(21, 101, 192, .4),
    400: Color.fromRGBO(21, 101, 192, .5),
    500: Color.fromRGBO(21, 101, 192, .6),
    600: Color.fromRGBO(21, 101, 192, .7),
    700: Color.fromRGBO(21, 101, 192, .8),
    800: Color.fromRGBO(21, 101, 192, .9),
    900: Color.fromRGBO(21, 101, 192, 1),
  }),
  brightness: Brightness.dark,
  primaryColor: Color(0xff1565C0),
  accentColor: Color(0xD8BD48),
  backgroundColor: Colors.white,
  dividerTheme: DividerThemeData(
    color: Colors.grey,
  ),
  chipTheme: ChipThemeData(
    backgroundColor: Color(0xffF2C26D),
    brightness: Brightness.light,
    deleteIconColor: Color(0xffF2C26D),
    disabledColor: Color(0xffF2C26D),
    labelPadding: EdgeInsets.only(top: 0.0, bottom: 0.0, left: 8.0, right: 8.0),
    labelStyle: TextStyle(
      color: Colors.white,
      fontSize: 14.0,
      fontWeight: FontWeight.w400,
      fontStyle: FontStyle.normal,
    ),
    padding: EdgeInsets.only(top: 4.0, bottom: 4.0, left: 4.0, right: 4.0),
    secondaryLabelStyle: TextStyle(
      color: Colors.white,
      fontSize: 14.0,
      fontWeight: FontWeight.w400,
      fontStyle: FontStyle.normal,
    ),
    secondarySelectedColor: Color(0xffF2C26D),
    selectedColor: Color(0xffF2C26D),
    shape: StadiumBorder(
        side: BorderSide(
      color: Color(0xffF2C26D),
      width: 0.0,
      style: BorderStyle.none,
    )),
  ),
  textTheme: TextTheme(
    headline1: TextStyle(fontSize: 72.0, fontWeight: FontWeight.bold),
    headline6: TextStyle(fontSize: 36.0, fontStyle: FontStyle.italic),
    bodyText2: TextStyle(fontSize: 14.0, fontFamily: 'Hind'),
  ),
);
