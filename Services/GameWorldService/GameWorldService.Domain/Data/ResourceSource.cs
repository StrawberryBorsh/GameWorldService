namespace GameWorldService.Domain.Data
{
    /// <summary>
    /// Представляет источник игрового ресурса.
    /// </summary>
    class ResourceSource : GameObject
    {
        /// <summary>
        /// Тип ресурса.
        /// </summary>
        public ResourceType Type { get; set; }

        /// <summary>
        /// Вместимость хранилища.
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// Доступное количество ресурса.
        /// </summary>
        public int Available { get; set; }
    }
}
