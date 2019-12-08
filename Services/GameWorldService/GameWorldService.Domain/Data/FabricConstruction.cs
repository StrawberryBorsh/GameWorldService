namespace GameWorldService.Domain.Data
{
    /// <summary>
    /// Представляет фабрику игрока.
    /// </summary>
    class FabricConstruction : UserObject
    {
        /// <summary>
        /// Тип требуемого ресурса.
        /// </summary>
        public ResourceType RequiredResource { get; set; }

        /// <summary>
        /// Тип вырабатываемого ресурса.
        /// </summary>
        public ResourceType ProducedResource { get; set; }

        /// <summary>
        /// Доступное количество требуемого ресурса.
        /// </summary>
        public int RequiredResourceValue { get; set; }

        /// <summary>
        /// Доступное количество вырабатываемого ресурса.
        /// </summary>
        public int ProducedResourceValue { get; set; }
    }
}
