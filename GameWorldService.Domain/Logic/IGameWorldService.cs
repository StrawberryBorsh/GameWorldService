using System.Collections.Generic;
using GameWorldService.Domain.Data;

namespace GameWorldService.Domain.Logic
{
    public interface IGameWorldService
    {
        GameField GetField(string nick);

        IEnumerable<GameField> GetFields();
    }
}
