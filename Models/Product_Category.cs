//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CnC_Store.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product_Category
    {
        public int Id { get; set; }
        public string CatName { get; set; }
        public int ProId { get; set; }
        public string ProName { get; set; }
        public string ProImage { get; set; }
        public Nullable<decimal> ProPrice { get; set; }
        public Nullable<int> CatId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> Quantity { get; set; }
        public int Expr1 { get; set; }
        public string OrderName { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string PaymentType { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
