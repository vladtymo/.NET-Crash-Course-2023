using Exam.Common;
using Exam.Services.Response;
using OpenAI_API;
using OpenAI_API.Completions;

namespace Exam.Services.OpenAIServices
{
    public class GPTService : IGPTService
    {
        private readonly OpenAIAPI _api;

        public GPTService()
        {
            _api = new OpenAIAPI(Configuration.OPEN_AI_KEY);
        }

        public async Task<ResponseService<ICollection<string>>> Request(string request)
        {
            CompletionRequest completionRequest = new CompletionRequest(request);
            completionRequest.MaxTokens = 4000;

            try
            {
                var result = await _api.Completions.CreateCompletionAsync(completionRequest);
                if (result == null)
                {
                    return ResponseService<ICollection<string>>.Error(Errors.OPEN_AI_REQUEST_ERROR);
                }

                return ResponseService<ICollection<string>>.Ok(result.Completions.Select(choise => choise.Text).ToList());

            }
            catch (Exception ex)
            {
                return ResponseService<ICollection<string>>.Error($"GPTService Request exception: {ex.Message}");
            }
        }
    }
}