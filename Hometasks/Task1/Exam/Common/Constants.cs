namespace Exam.Common
{
    public class Configuration
    {
        public const string OPEN_AI_KEY = "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";
        public const string DEFAULT_CONNECTION = "Data Source=localhost;Database=SupermarketDb;Trusted_Connection=True;Encrypt=false";
    }

    public class Errors
    {
        public const string CREATE_ERROR = "Can't create. Something went wrong";
        public const string DELETE_ERROR = "Can't delete. Something went wrong";
        public const string UPDATE_ERROR = "Cant' update. Something went wrong";
        public const string WAS_CREATED_ERROR = "Was created";
        public const string NOT_FOUND_ERROR = "Not found";
        public const string BUY_ERROR = "You are trying to buy more than we have";
        public const string OPEN_AI_REQUEST_ERROR = "Unhandled error. Try again later";
    }
}