using System.Collections.Generic;
using GameWorldService.Domain.Data;

namespace GameWorldService.Domain.Logic
{
    public interface IDatabaseService
    {
        void AddField(GameField field);

        GameField GetFieldByNick(string nick);

        IEnumerable<GameField> GetFields();
    }
}