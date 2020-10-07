import 'package:client/screens/home/bloc/list_articles_bloc.dart';
import 'package:flutter/material.dart';

class MultiBlocProvider extends InheritedWidget{
  MultiBlocProvider({
    Key key,
    @required List<BlocProvider> providers,
    Widget child
  }) : assert(providers != null), super();

  static MultiBlocProvider of(BuildContext context) {
    return context.dependOnInheritedWidgetOfExactType<MultiBlocProvider>();
  } 

  @override
  bool updateShouldNotify(covariant InheritedWidget oldWidget) {
    return true;
  }
}


class BlocProvider<B> extends InheritedWidget{
  final B bloc;

  BlocProvider({
    Key key,
    @required this.bloc,
    @required Widget child
  }) : assert(bloc != null), super(key: key, child: child);

  static BlocProvider of(BuildContext context) {
    return context.dependOnInheritedWidgetOfExactType<BlocProvider>();
  } 

  @override
  bool updateShouldNotify(covariant InheritedWidget oldWidget) {
    return true;
  }
}

extension BlocProviderExtension on BuildContext {
  B bloc<B>() => BlocProvider.of<B>(this);
}

// class BlocProvider extends InheritedWidget {

//   // these blocs are the objects that we want to access throughout the app
//   final ListArticlesBloc listArticlesBloc;

//   /// Inherited widgets require a child widget
//   /// which they implicitly return in the same way
//   /// all widgets return other widgets in their 'Widget.build' method.
//   const BlocProvider({
//     Key key,
//     @required Widget child,
//     this.listArticlesBloc,
//   })  : assert(child != null),
//         super(key: key, child: child);

//   /// this method is used to access an instance of
//   /// an inherited widget from lower in the tree.
//   /// `BuildContext.dependOnInheritedWidgetOfExactType` is a built in
//   /// Flutter method that does the hard work of traversing the tree for you
//   static BlocProvider of(BuildContext context) {
//     return context.dependOnInheritedWidgetOfExactType<BlocProvider>();
//   }

//   @override
//   bool updateShouldNotify(BlocProvider old) {
//     return true;
//   }
// }