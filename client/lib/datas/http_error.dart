class HttpError {
  const HttpError({
    this.title,
    this.statusCode,
    this.errorMesage,
  });

  final String title;
  final int statusCode;
  final String errorMesage;

  factory HttpError.convert(Map<String, dynamic> dioErrorResponse) {
    return HttpError(
      title: dioErrorResponse["Title"],
      statusCode: dioErrorResponse["Status"],
      errorMesage: dioErrorResponse["Detail"],
    );
  }
}