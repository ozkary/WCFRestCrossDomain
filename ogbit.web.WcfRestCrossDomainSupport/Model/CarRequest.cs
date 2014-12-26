using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ogbit.web.WcfRestCrossDomainSupport.Model
{
    /// <summary>
    /// complext type for the request
    /// </summary>
    public class CarRequest
    {
        /// <summary>
        /// vehicle make: nissan toyota
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// models for each make: Altima, XTerra
        /// </summary>
        public string Model { get; set; }
    }
}