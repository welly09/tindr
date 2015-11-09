using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonJobLists.Models
{
    public class getData
    {
       public string client{get;set;}
       public int Jobnumber {get ;set;} 
       public string JobName {get; set;}
       public string  Due {get;set;}
       public string status { get; set; }
    }
}