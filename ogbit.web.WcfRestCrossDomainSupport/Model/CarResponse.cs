using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ogbit.web.WcfRestCrossDomainSupport.Model
{
    /// <summary>
    /// response from the web service
    /// </summary>
    public class CarResponse
    {
        public List<Vehicle> Items { get; set; }       
    }
}