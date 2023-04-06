using Exam.Services.Response;

namespace Exam.Services.OpenAIServices
{
    public interface IGPTService
    {
        Task<ResponseService<ICollection<string>>> Request(string request);
    }
}