using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.CategoryDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.WhoWeAreDetailDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.DTOs.WhoWeAreDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.DapperContext;
using Dapper;

namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.WhoWeAreRepository
{
    public class WhoWeAreDetailRepository : IWhoWeAreDetailRepository
    {
        private readonly Context _context;

        public WhoWeAreDetailRepository(Context context)
        {
            _context = context;
        }

        public async void CreateWhoWeAreDetail(CreateWhoWeAreDetailDTO createWhoWeAreDetailDTO)
        {
            string query = "insert into WhoWeAreDetail (Title,SubTitle,Description1,Description2) values (@title,@subtitle,@description1,@description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", createWhoWeAreDetailDTO.Title);
            parameters.Add("@subTitle", createWhoWeAreDetailDTO.SubTitle);
            parameters.Add("@description1", createWhoWeAreDetailDTO.Description1);
            parameters.Add("@description2", createWhoWeAreDetailDTO.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteWhoWeAreDetail(int id)
        {
            string query = "delete from WhoWeAreDetail where WhoWeAreDetailID=@whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public Task<List<ResultWhoWeAreDetailDTO>> GetAllWhoWeAreDetailAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIDWhoWeAreDetail> GetWhoWeAreDetail(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDTO updateWhoWeAreDetailDTO)
        {
            throw new NotImplementedException();
        }
    }
}
