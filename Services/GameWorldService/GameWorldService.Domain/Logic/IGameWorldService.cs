using GameWorldService.Domain.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldService.Domain.Logic
{
    interface IGameWorldService
    {
        GameField GetField(string userName);
    }
}
