namespace Exam.Services.Response
{
    public class ResponseService
    {
        public bool IsError { get; init; }
        public string ErrorMessage { get; init; }

        public static ResponseService Ok()
        {
            return new ResponseService()
            {
                IsError = false,
            };
        }

        public static ResponseService Error(string errorMessage)
        {
            return new ResponseService()
            {
                ErrorMessage = errorMessage,
                IsError = true,
            };
        }
    }

    public class ResponseService<T>
    {
        public bool IsError { get; init; }
        public string ErrorMessage { get; init; }
        public T Value { get; init; }

        public static ResponseService<T> Ok(T value)
        {
            return new ResponseService<T>()
            {
                IsError = false,
                Value = value,
            };
        }

        public static ResponseService<T> Error(string errorMessage)
        {
            return new ResponseService<T>()
            {
                IsError = true,
                ErrorMessage = errorMessage,
            };
        }
    }
}