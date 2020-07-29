using StdCoreApp.Application.ViewModels.Common;
using StdCoreApp.Application.ViewModels.Product;
using StdCoreApp.Data.Enums;
using StdCoreApp.Utilities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StdCoreApp.Models
{
    public class CheckoutViewModel : BillViewModel
    {
        public List<ShoppingCartViewModel> Carts { get; set; }

        public List<EnumModel> PaymentMethods
        {
            get
            {
                return ((PaymentMethod[])Enum.GetValues(typeof(PaymentMethod)))
                    .Select(c => new EnumModel
                    {
                        Value = (int)c,
                        Name = c.GetDescription()
                    }).ToList();
            }
        }
    }
}