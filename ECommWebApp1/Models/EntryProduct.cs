using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommWebApp1.Models
{
    public class EntryProduct
    {   [Key]
        public int ProductID  {get; set;}
        public string   ProductNo { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public int SubCategory { get; set; }
        public string Featured { get; set; }
        public int MainCategoryID { get; set; }
        public  string PhotoID { get; set; }
        
    }
}