namespace Asp.NetCore8._0_RealEstate_Dapper_API_Project.Models.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories
{
    public interface IStatisticRepository
    {
         
        int StatusProductCountByStatusTrue(int id);
        int StatusProductCountByStatusFalse(int id);
        int ProductCountByEmployeeID(int id);
        int AllProductCount();
       
    }
}
