using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLirary.Models
{
     public class PersonModels
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname 
        {
            get { return $"{this.Firstname} {this.Lastname}"; }
        }
             
    }
}
