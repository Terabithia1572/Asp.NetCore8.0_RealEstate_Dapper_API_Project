﻿using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ProductDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDTO>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDTO> > GetAllProductWithCategoryAsync();
    }
}