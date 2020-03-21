using GameWorldService.Domain.Data;

namespace GameWorldService.Domain.Logic
{
    public interface IInitializerServiceClient
    {
        GameField InitializeNewField();
    }
}
