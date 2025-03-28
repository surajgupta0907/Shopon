using Shopon.Business.Contracts;
using Shopon.Common.Models;
using Shopon.Data.Contracts;

namespace Shopon.Business
{
    /// <summary>
    /// The CompanyAsyncManager
    /// </summary>
    public class CompanyAsyncManager : ICompanyAsyncManager
    {
        private readonly ICompanyAsyncRepository companyRepo;

        public CompanyAsyncManager(ICompanyAsyncRepository companyRepo)
        {
            this.companyRepo=companyRepo;
        }
        public Task<Company?> GetCompanyByIdAsync(int id) => companyRepo.GetCompanyByIdAsync(id);
        
    }
}
