using System.Collections.Generic;
using GameWorldService.Domain.Data;

namespace GameWorldService.Domain.Logic.Impl
{
    public class GameWorldService : IGameWorldService
    {
        private readonly IDatabaseService _databaseService;
        private readonly IInitializerServiceClient _initializerService;

        public GameWorldService(IDatabaseService databaseService, IInitializerServiceClient initializerService)
        {
            _databaseService = databaseService;
            _initializerService = initializerService;
        }

        public GameField GetField(string nick)
        {
            var field = _databaseService.GetFieldByNick(nick);
            if (field is null)
            {
                field = _initializerService.InitializeNewField();
                field.FieldOwner = nick;
                _databaseService.AddField(field);
            }

            return field;
        }

        public IEnumerable<GameField> GetFields() =>
            _databaseService.GetFields();
    }
}
