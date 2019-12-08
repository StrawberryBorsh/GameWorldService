namespace GameWorldService.Domain.Data
{
    /// <summary>
    /// Представляет юнит игрока.
    /// </summary>
    class Unit : UserObject
    {
        /// <summary>
        /// Максимальный объем переносимого ресурса.
        /// </summary>
        public int ResourceCapacity { get; set; }

        /// <summary>
        /// Текущее количество переносимого ресурса.
        /// </summary>
        public int ResourceAvailableValue { get; set; }
    }
}
