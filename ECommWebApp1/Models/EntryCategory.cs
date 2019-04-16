using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommWebApp1.Models
{
    public class EntryCategory
    {
      [Key]
      public    int  CategoryID          { get; set; }
      public    string  CategoryNo       { get; set; }
      public    string  CategoreyName    { get; set; }
      public    int     Parent           { get; set; }
    }
}