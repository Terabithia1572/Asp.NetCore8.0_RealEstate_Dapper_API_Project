﻿namespace Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.ProductDTOs
{
    public class CreateProductDTO
    {
       
        public string ProductTitle { get; set; }
        public string ProductCoverImage { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCity { get; set; }
        public string ProductDistrict { get; set; }
        public string ProductAddress { get; set; }
        public string ProductDescription { get; set; }
        public string ProductType { get; set; }
        public string CategoryID { get; set; }
    }
}
