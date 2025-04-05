namespace Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.ProductDTOs
{
    public class CreateProductDTO
    {

        public string ProductTitle { get; set; }
        public int ProductPrice { get; set; }
        public string ProductCoverImage { get; set; }
        public string ProductCity { get; set; }
        public string ProductDistrict { get; set; }
        public string ProductAddress { get; set; }
        public string ProductDescription { get; set; }
        public string ProductType { get; set; }
        public bool ProductDailyOfTheDay { get; set; }
        public DateTime ProductAdvertisementDate { get; set; }
        public bool ProductStatus { get; set; }
        public int ProductCategory { get; set; }
        public int EmployeeID { get; set; }
    }
}
