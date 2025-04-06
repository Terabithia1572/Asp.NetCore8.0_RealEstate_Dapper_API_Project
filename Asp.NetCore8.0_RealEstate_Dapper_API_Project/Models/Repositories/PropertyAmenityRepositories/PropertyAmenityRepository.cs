using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.PropertyAmenityDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.PropertyAmenityRepositories
{
    public class PropertyAmenityRepository : IPropertyAmenityRepository
    {
        private readonly Context _context;

        public PropertyAmenityRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultPropertyAmenityByStatusTrueDTO>> ResultPropertyAmenityByStatusTrue(int id)
        {
            string query = "select PropertyAmenityID,AmenityTitle from PropertyAmenity Inner join Amenity on Amenity.AmenityID=PropertyAmenity.AmenityID where PropertyID=@propertyID and status=1";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPropertyAmenityByStatusTrueDTO>(query,parameters);
                return values.ToList();
            }
        }
    }
}
