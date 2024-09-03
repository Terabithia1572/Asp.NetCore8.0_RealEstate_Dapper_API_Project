using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.TestimonialDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.TestimonialRepositories
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly Context _context;

        public TestimonialRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultTestimonialDTO>> GetAllTestimonialAsync()
        {
            string query = "select * from Testimonial";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultTestimonialDTO>(query);
                return values.ToList();
            }
        }
    }
}
