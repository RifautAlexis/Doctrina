namespace api_server.Contract.Exceptions
{
    public class NotFoundException : ErrorException
    {
        public override string Title => "Not Found";
        public override int StatusCode => 456789;
        public override string ErrorMessage => "No entity has been found in database";
    }
}