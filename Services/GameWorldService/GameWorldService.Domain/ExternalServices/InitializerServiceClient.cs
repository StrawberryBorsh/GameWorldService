using GameWorldService.Domain.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldService.Domain.ExternalServices
{
    class InitializerServiceClient
    {
        public GameField InitializeField(string userName)
        {
            return new GameField()
            {
                FieldOwner = userName,
                Cells = new GameCell[20][]
            };
        }
    }
}
