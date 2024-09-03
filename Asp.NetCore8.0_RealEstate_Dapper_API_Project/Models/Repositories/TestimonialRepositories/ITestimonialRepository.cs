using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.ServiceDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.TestimonialDTOs;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDTO>> GetAllTestimonialAsync();
    
    }
}
