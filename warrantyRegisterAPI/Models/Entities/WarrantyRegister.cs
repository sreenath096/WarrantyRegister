using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace warrantyRegisterAPI.Models.Entities
{
    public class WarrantyRegister
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductPart { get; set; }
        public int WarrantyPeriod { get; set; }
        public DateTime PurchasedDate { get; set; }
        public string PurchasedFrom { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal? MRPAmount { get; set; }
        public string PurchasedPlace { get; set; }
        public int Pincode { get; set; }
        public bool IsActive { get; set; }
    }
}