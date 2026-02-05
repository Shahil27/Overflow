using Contracts;
using Typesense;

namespace SearchService.MessageHandlers;

public class UpdatedAnswerCountHandler(ITypesenseClient client)
{
    public async Task HandleAsync(UpdatedAnswerCount message)
    {
        await client.UpdateDocument("questions", message.QuestionId,
            new { message.AnswerCount }
        );
    }
}