using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace warrantyRegisterAPI.Models.Request
{
    public class CreateWarrantyRegisterRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string ProductPart { get; set; }
        [Required]
        public int WarrantyPeriod { get; set; }
        [Required]
        public DateTime PurchasedDate { get; set; }
        public string PurchasedFrom { get; set; }
        [Required]
        public decimal InvoiceAmount { get; set; }
        public decimal? MRPAmount { get; set; }
        [Required]
        public string PurchasedPlace { get; set; }
        [Required]
        public int Pincode { get; set; }
    }
}