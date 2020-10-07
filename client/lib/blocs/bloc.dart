import 'dart:async';
import 'package:flutter/material.dart';

abstract class Bloc<Event, State> {

  final _streamController = StreamController<State>.broadcast();
  final _eventController = StreamController<Event>.broadcast();
  
  Sink<State> get updateState => _streamController.sink;
  Stream<State> get state => _streamController.stream;

  Sink<Event> get updateEvent => _eventController.sink;
  Stream<Event> get event => _eventController.stream;

  Bloc(State initialState) : super() {
    _bindEventsToStates();
  }

  _bindEventsToStates() {
    event.listen((event) => mapEventToState(event));
  }

  void add(Event event) {
    if (_eventController.isClosed) return;
    _eventController.add(event);
  }

  void mapEventToState(Event event);

  @mustCallSuper
  close() async {
    await _eventController.close();
    await _streamController.close();
  }
}