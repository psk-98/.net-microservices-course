namespace Play.Inventory.Service.Dtos
{
    public record GrantItemsDto(Guid UserId, Guid CatalogItemId, int Quantity);

    public record InventoryItemsDto(Guid CatatlogItemId, int Quantity, DateTimeOffset AcquiredDate);
}