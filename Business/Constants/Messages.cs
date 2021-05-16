using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime { get; } = "Sistem bakımda";
        public static string ProductsListed { get; } = "Ürünler listelendi.";

        public static string ProductAdded { get; } = "Ürün eklendi.";
        public static string ProductNameInvalid { get; } = "Ürün ismi geçersiz.";
    }
}
