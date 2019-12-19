using GameWorldService.Domain.Data;
using GameWorldService.Logic.Entities;
using Newtonsoft.Json;

namespace GameWorldService.Logic.Mappers
{
    static class GameFieldMapper
    {
        public static GameFieldEntity ToEntityMap(this GameField source)
        {
            return
                source == null
                    ? null
                    : new GameFieldEntity
                    {
                        FieldOwner = source.FieldOwner,
                        Cells = JsonConvert.SerializeObject(source.Cells)
                    };
        }

        public static GameField FromEntityMap(this GameFieldEntity source)
        {
            return
                source == null
                    ? null
                    : new GameField
                    {
                        FieldOwner = source.FieldOwner,
                        Cells = JsonConvert.DeserializeObject<GameCell[][]>(source.Cells)
                    };
        }
    }
}
