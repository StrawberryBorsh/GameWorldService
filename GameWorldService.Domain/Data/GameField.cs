namespace GameWorldService.Domain.Data
{
    /// <summary>
    /// Представляет игровое поле.
    /// </summary>
    public class GameField
    {
        /// <summary>
        /// Имя игрока-владельца поля.
        /// </summary>
        public string FieldOwner { get; set; }

        /// <summary>
        /// Набор игровых ячеек.
        /// </summary>
        public GameCell[][] Cells { get; set; }
    }
}
