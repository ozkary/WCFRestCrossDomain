using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ogbit.web.WcfRestCrossDomainSupport.Data
{
    internal sealed class VehicleData
    {
       /// <summary>
       /// returns sample data
       /// </summary>
       /// <returns></returns>
        public static Model.CarResponse GetItems()
        {
            Model.CarResponse resp = new Model.CarResponse();            
            List<Model.Vehicle> list = new List<Model.Vehicle>();
            list.Add(new Model.Vehicle()
            {
                Make="Nissan",
                Model="Altima",
                Trim="GXE"
            });

            list.Add(new Model.Vehicle()
            {
                Make = "Nissan",
                Model = "Maxima",
                Trim = "GXE"
            });

            list.Add(new Model.Vehicle()
            {
                Make = "Nissan",
                Model = "XTerra",
                Trim = "GXE"
            });

            list.Add(new Model.Vehicle()
            {
                Make = "Toyota",
                Model = "Corolla",
                Trim = "LT"
            });

            resp.Items= list;

            return resp;
        }
    }
}
