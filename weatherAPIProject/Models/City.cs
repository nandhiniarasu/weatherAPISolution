using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace weatherAPIProject.Models
{
    public class City
    {
       
            [Key]
            public int CityID { get; set; }
            public string Forecast { get; set; }
            public string Pincode { get; set; }

            }
}
