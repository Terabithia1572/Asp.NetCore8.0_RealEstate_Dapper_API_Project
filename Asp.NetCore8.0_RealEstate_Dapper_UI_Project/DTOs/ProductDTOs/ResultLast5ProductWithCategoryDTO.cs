namespace Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.ProductDTOs
{
    public class ResultLast5ProductWithCategoryDTO
    {

        public int ProductID { get; set; }
        public string ProductTitle { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCity { get; set; }
        public string ProductDistrict { get; set; }
        public int ProductCategory { get; set; }
        public string CategoryName { get; set; }
        public DateTime ProductAdvertisementDate { get; set; }
    }
}
