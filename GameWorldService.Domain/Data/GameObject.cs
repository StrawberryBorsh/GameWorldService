namespace GameWorldService.Domain.Data
{
    /// <summary>
    /// Представляет базовый класс для всех игровых объектов.
    /// </summary>
    public abstract class GameObject
    {
        /// <summary>
        /// Положение объекта по оси X.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Положение объекта по оси Y.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Возвращает описание объекта.
        /// </summary>
        /// <returns>Описание объекта.</returns>
        public virtual string GetDescription() =>
            "игровой объект";
    }
}
