namespace GameWorldService.Domain.Data
{
    /// <summary>
    /// Представялет ячейку игрового поля.
    /// </summary>
    public class GameCell
    {
        /// <summary>
        /// Положение ячейки по оси X.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Положение ячейки по оси Y.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Объект, находящийся в ячейке.
        /// </summary>
        public GameObject Object { get; set; }
    }
}
