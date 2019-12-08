using System;
using System.Collections.Generic;
using System.Text;
using GameWorldService.Domain.Data;
using GameWorldService.Domain.ExternalServices;

namespace GameWorldService.Domain.Logic.Impl
{
    class GameWorldService : IGameWorldService
    {
        private readonly InitializerServiceClient _initializerService;

        public GameWorldService(InitializerServiceClient initializerService)
        {
            _initializerService = initializerService;
        }

        public GameField GetField(string userName)
        {
            return _initializerService.InitializeField(userName);
        }
    }
}
