namespace AutoRepairShop.Core.dtos
{
    public class OrderDto
    {
        public class ProductDto
        {
            public int ProductId { get; set; }
            public int Count { get; set; }
        }
        public int UserInfoId { get; set; }
        public float Price { get; set; }
        public ProductDto[] Products { get; set; }
    }
}
