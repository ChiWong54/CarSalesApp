using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AssetSalesApp.Data
{
    public class Asset
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime DateAcquired { get; set; }
        public bool InUse { get; set; }
        public double PurchasePrice { get; set; }

        // Default Constructor
        public Asset()
        {
            Name = string.Empty;
            Location = string.Empty;
        }

        public Asset(int id, string name, string location, DateTime dateAcquired, 
            bool inUse, double purchasePrice)
        {
            Id = id;
            Name = name;
            Location = location;
            DateAcquired = dateAcquired;
            InUse = inUse;
            PurchasePrice = purchasePrice;
        }

        // Methods
        public override string ToString()
        {
            var str = Id + ": " + Location + " - " + Name 
                + PurchasePrice + " " + "(" + DateAcquired.ToShortDateString() + ")";

            if (InUse)
            {
                str = str + " **";
            };
            return str;
        }
    } // End of Class
}
