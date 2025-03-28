using Shopon.Common.Models;

namespace Shopon.Business.Contracts
{
    /// <summary>
    /// The IBankManager
    /// </summary>
    public interface IBankManager
    {
        /// <summary>
        /// Method to add Bank
        /// </summary>
        /// <param name="bank"></param>
        /// <returns></returns>
        public Bank AddBank(Bank bank);

        /// <summary>
        /// Method to get all banks
        /// </summary>
        /// <returns>List of all banks</returns>
        public IEnumerable<Bank>? GetAllBanks();

    }
}
