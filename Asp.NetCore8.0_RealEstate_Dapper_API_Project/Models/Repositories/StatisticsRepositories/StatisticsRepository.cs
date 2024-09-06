﻿using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.StatisticsRepositories
{
    public class StatisticsRepository : IStatisticsRepository
    {

        private readonly Context _context;

        public StatisticsRepository(Context context)
        {
            _context = context;
        }

        public int ActiveCategoryCount()
        {
            string query = "select Count(*) from Category where CategoryStatus=1";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ActiveEmployeeCount()
        {
            string query = "select Count(*) from Employee where EmployeeStatus=1";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ApartmentCount()
        {
            throw new NotImplementedException();
        }

        public decimal AverageProductByRent()
        {
            throw new NotImplementedException();
        }

        public decimal AverageProductBySale()
        {
            throw new NotImplementedException();
        }

        public int AverageRoomCount()
        {
            throw new NotImplementedException();
        }

        public int CategoryCount()
        {
            throw new NotImplementedException();
        }

        public string CategoryNameByMaxCount()
        {
            throw new NotImplementedException();
        }

        public string CityNameByMaxProductCount()
        {
            throw new NotImplementedException();
        }

        public int DifferentCityCount()
        {
            throw new NotImplementedException();
        }

        public string EmployeeNameByMaxCount()
        {
            throw new NotImplementedException();
        }

        public decimal LastProductPrice()
        {
            throw new NotImplementedException();
        }

        public string NewestBuildingYear()
        {
            throw new NotImplementedException();
        }

        public string OldestBuildingYear()
        {
            throw new NotImplementedException();
        }

        public int PassiveCategoryCount()
        {
            throw new NotImplementedException();
        }

        public int ProductCount()
        {
            throw new NotImplementedException();
        }
    }
}
