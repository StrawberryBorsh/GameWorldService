using GameWorldService.Domain.Data;
using GameWorldService.Domain.Logic;

namespace GameWorldService.Logic.Clients
{
    public class InitializerServiceClient : IInitializerServiceClient
    {
        public GameField InitializeNewField()
        {
            var cells = new GameCell[20][];
            for (var i = 0; i < cells.Length; i++)
            {
                cells[i] = new GameCell[20];
                for (var j = 0; j < cells[i].Length; j++)
                {
                    cells[i][j] = new GameCell();
                }
            }

            return new GameField()
            {
                Cells = cells
            };
        }
    }
}
