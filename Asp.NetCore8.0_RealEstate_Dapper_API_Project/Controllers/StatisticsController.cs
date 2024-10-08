﻿using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.StatisticsRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public StatisticsController(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }
        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            return Ok(_statisticsRepository.ActiveCategoryCount());
        }
        [HttpGet("ActiveEmployeeCount")]
        public IActionResult ActiveEmployeeCount()
        {
            return Ok(_statisticsRepository.ActiveEmployeeCount());
        }
        [HttpGet("ApartmentCount")]
        public IActionResult ApartmentCount()
        {
            return Ok(_statisticsRepository.ApartmentCount());
        }
        [HttpGet("AverageProductPriceByRent")]
        public IActionResult AverageProductPriceByRent()
        {
            return Ok(_statisticsRepository.AverageProductPriceByRent());
        }
        [HttpGet("AverageProductPriceBySale")]
        public IActionResult AverageProductPriceBySale()
        {
            return Ok(_statisticsRepository.AverageProductPriceBySale());
        }
        [HttpGet("AverageRoomCount")]
        public IActionResult AverageRoomCount()
        {
            return Ok(_statisticsRepository.AverageRoomCount());
        }
        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            return Ok(_statisticsRepository.CategoryCount());
        }  
        [HttpGet("CategoryNameByMaxCount")]
        public IActionResult CategoryNameByMaxCount()
        {
            return Ok(_statisticsRepository.CategoryNameByMaxCount());
        }
        [HttpGet("CityNameByMaxProductCount")]
        public IActionResult CityNameByMaxProductCount()
        {
            return Ok(_statisticsRepository.CityNameByMaxProductCount());
        }
        [HttpGet("DifferentCityCount")]
        public IActionResult DifferentCityCount()
        {
            return Ok(_statisticsRepository.DifferentCityCount());
        }
        [HttpGet("EmployeeNameByMaxCount")]
        public IActionResult EmployeeNameByMaxCount()
        {
            return Ok(_statisticsRepository.EmployeeNameByMaxCount());
        } 
        [HttpGet("LastProductPrice")]
        public IActionResult LastProductPrice()
        {
            return Ok(_statisticsRepository.LastProductPrice());
        } 
        [HttpGet("NewestBuildingYear")]
        public IActionResult NewestBuildingYear()
        {
            return Ok(_statisticsRepository.NewestBuildingYear());
        } 
        [HttpGet("OldestBuildingYear")]
        public IActionResult OldestBuildingYear()
        {
            return Ok(_statisticsRepository.OldestBuildingYear());
        } 
        [HttpGet("PassiveCategoryCount")]
        public IActionResult PassiveCategoryCount()
        {
            return Ok(_statisticsRepository.PassiveCategoryCount());
        }
        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_statisticsRepository.ProductCount());
        }
    }
}
