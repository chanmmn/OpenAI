using OpenAI_API;

namespace ConAppChatGPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the API key
            var openAi = new OpenAIAPI("OPENAI Key");

            var completions = openAi.Completions.CreateCompletionAsync(
    prompt: "1 + 1=",
    model: "text-davinci-002",
    max_tokens: 100,
    temperature: 1f
);
            foreach (var completion in completions.Result.Completions)
            {
                Console.Write(completion.Text);
            }

        }
    }
}