using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ogbit.web.WcfRestCrossDomainSupport.Model
{
    /// <summary>
    /// vehicle model to represent car detail
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// vehicle make: nissan toyota
        /// </summary>
        public string Make { get; set; }
        
        /// <summary>
        /// models for each make: Altima, XTerra
        /// </summary>
        public string Model { get; set; }
        
        /// <summary>
        /// Trim information: GXE, LT
        /// </summary>
        public string Trim { get; set; }
    }

}