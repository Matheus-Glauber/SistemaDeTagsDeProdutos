using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Modulo10.Models
{
    class UsedProduct : Product
    {
        public DateTime manufactoreDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactoreDate) : base(name, price)
        {
            this.manufactoreDate = manufactoreDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name);
            sb.Append(" (used) $ ");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append($" (Manufacture date: {manufactoreDate.ToString("dd/MM/yyyy")})");

            return sb.ToString();
        }
    }
}
