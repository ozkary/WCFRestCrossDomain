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
        /// <summary>
        /// gets the makes in the vehicle data
        /// </summary>
        /// <returns></returns>
        public List<string> GetMakes()
        {
            return Data.VehicleData.GetMakes();
            
        }

        /// <summary>
        /// gets all the cars
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Model.CarResponse GetCars(Model.CarRequest req)
        {
            return Data.VehicleData.GetItems(req);
        }

        /// <summary>
        /// cross domain support for complex types
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Model.CarResponse GetCarsXdr(Stream req)
        {
            try
            {
                Model.CarRequest request = MapRequest<Model.CarRequest>(req);
                return GetCars(request);
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
