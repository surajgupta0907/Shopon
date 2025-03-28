using Shopon.Business.Contracts;
using Shopon.Common.Models;
using Shopon.Data.Contracts;

namespace Shopon.Business
{
    /// <summary>
    /// The BankManager
    /// </summary>
    public class BankManager : IBankManager
    {
        private readonly IBankRepository bankRepository;
        public BankManager(IBankRepository bankRepository)
        {
            this.bankRepository=bankRepository;
        }

        public Bank AddBank(Bank bank) => this.bankRepository.AddBank(bank);

        public IEnumerable<Bank>? GetAllBanks()=>this.bankRepository.GetAllBanks();
       
    }
}
