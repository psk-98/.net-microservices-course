using Play.Inventory.Service.Dtos;

namespace Play.Inventory.Service
{
    public static class Extensions
    {
        public static InventoryItemsDto AsDto(this InventoryItemsDto item)
        {
            return new InventoryItemsDto(item.CatatlogItemId, item.Quantity, item.AcquiredDate);
        }
    }
}