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
            return GetData();
        }

        public static Model.CarResponse GetItems(Model.CarRequest req)
        {
            var list = GetData();
            //apply simple filter to get the matching items
            var data = (from item in list.Items
                        where (string.IsNullOrWhiteSpace(req.Make) || item.Make == req.Make)
                             && (string.IsNullOrWhiteSpace(req.Model) || item.Model == req.Model)
                        select item).ToList();
            Model.CarResponse resp = new Model.CarResponse()
            {
                Items = data
            };

            return resp;
        }

        public static List<string> GetMakes()
        {
            var list = GetData();            
            List<string> makes = null;
            if (list != null)
            {
                makes = (from item in list.Items
                         where !String.IsNullOrWhiteSpace(item.Make)
                         select item.Make).Distinct().ToList();
            }

            return makes;
        }


        
        /// <summary>
        /// gets the vehicle data
        /// </summary>
        /// <returns></returns>
        private static Model.CarResponse GetData()
        {
            Model.CarResponse resp = new Model.CarResponse();
            List<Model.Vehicle> list = new List<Model.Vehicle>();
            list.Add(new Model.Vehicle()
            {
                Make = "Nissan",
                Model = "Altima",
                Trim = "GXE"
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

            resp.Items = list;

            return resp;

        }
    }
}
