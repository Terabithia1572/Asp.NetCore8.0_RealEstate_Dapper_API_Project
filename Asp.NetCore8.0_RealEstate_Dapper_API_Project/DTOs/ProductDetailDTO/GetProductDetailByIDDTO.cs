namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ProductDetailDTO
{
    public class GetProductDetailByIDDTO
    {
        public int ProductDetailID { get; set; }
        public int ProductSize { get; set; }

        public int ProductBedRoomCount { get; set; }
        public int ProductBathCount { get; set; }
        public int ProductRoomCount { get; set; }
        public int ProductGarageSize { get; set; }
        public string ProductBuildYear { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductLocation { get; set; }
        public string ProductVideoURL { get; set; }
        public int ProductID { get; set; }
        public DateTime ProductAdvertisementDate { get; set; }
    }
}
