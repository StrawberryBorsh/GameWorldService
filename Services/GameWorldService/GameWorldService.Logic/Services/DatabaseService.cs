using System.Collections.Generic;
using System.Linq;
using GameWorldService.Domain.Data;
using GameWorldService.Domain.Logic;
using GameWorldService.Logic.Mappers;

namespace GameWorldService.Logic.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly GameWorldServiceContext _dbContext;

        public DatabaseService(GameWorldServiceContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddField(GameField field)
        {
            _dbContext.GameFields.Add(field.ToEntityMap());
            _dbContext.SaveChanges();
        }

        public GameField GetFieldByNick(string nick)
        {
            return _dbContext
                    .GameFields
                    .FirstOrDefault(fld => fld.FieldOwner.Equals(nick))
                    .FromEntityMap();
        }

        public IEnumerable<GameField> GetFields() =>
            _dbContext
                .GameFields
                .Select(fld => fld.FromEntityMap());
    }
}
