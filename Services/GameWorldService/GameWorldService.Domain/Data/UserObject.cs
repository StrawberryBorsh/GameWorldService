namespace GameWorldService.Domain.Data
{
    /// <summary>
    /// Представляет объект игрока.
    /// </summary>
    class UserObject : GameObject
    {
        /// <summary>
        /// Имя владельца.
        /// </summary>
        public string Owner { get; set; }
    }
}
