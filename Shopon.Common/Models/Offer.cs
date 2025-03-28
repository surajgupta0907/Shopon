namespace Shopon.Common.Models
{
    /// <summary>
    /// The Offer
    /// </summary>
    public class Offer
    {
        public int OfferId { get; set; }

        public string OfferType { get; set; } = string.Empty;

        public int Discount { get; set; }

        public string Remark { get; set; } = string.Empty;

        public DateTime OfferTime { get; set; } = DateTime.Now;

        public Bank Bank { get; set; }

        public bool isDeleted { get; set; }
    }
}
