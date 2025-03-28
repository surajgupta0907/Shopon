using System;

namespace Shopon.Common.Models
{
    /// <summary>
    /// The Bank
    /// </summary>
    public class Bank
    {
        public int BankId { get; set; }

        public string BankName { get; set; } = string.Empty;

        public string Branch { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string IFSC { get; set; } = string.Empty;

        public bool isDeleted { get; set; }

        public ICollection<Offer> Offers { get; set; }

        public void AddOffer(Offer offer) => this.Offers.Add(offer);

        public Bank()
        {
            Offers = new List<Offer>();
        }
    }
}
