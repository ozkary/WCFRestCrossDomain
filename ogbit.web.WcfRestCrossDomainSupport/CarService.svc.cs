using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.Text;

namespace ogbit.web.WcfRestCrossDomainSupport
{
    
    public class CarService : ICarService
    {

        public Model.CarResponse GetCars(Model.CarRequest request)
        {
            return Data.VehicleData.GetItems();
        }

        public Model.CarResponse GetCarsXdr(Stream request)
        {
            try
            {
                Model.CarRequest req = MapRequest<Model.CarRequest>(request);
                return GetCars(req);
            }
            catch (System.Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

         /// <summary>
        /// maps a stream to a request object
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private static T MapRequest<T>(Stream request) where T : class
        {
            T req = null;

            try
            {
                if (request != null)
                {
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                    req = (T)ser.ReadObject(request);
                }
                else
                {
                    throw new System.Exception("Invalid Request");
                }

            }
            catch//TODO add more handling
            {
                throw new System.Exception("Error in Request");
            }

            return req;
        }
    }
}
