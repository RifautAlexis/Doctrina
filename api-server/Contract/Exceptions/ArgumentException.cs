namespace api_server.Contract.Exceptions
{
    public class ArgumentException : ErrorException
    {
        public override string Title => "Object given in request is not valid";
        public override int StatusCode => 404;
        public override string ErrorMessage => "The object or one of his properties is wrong";
    }
}
