using Cakes.Data.Entities;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Cakes
{
    public class RestaurantRepository
    {

        public void GetResponseObject(RestaurantJSON restaurant)
        {

            PropertyInfo[] p = restaurant.GetType().GetProperties();
            foreach (var day in p)
            {
                string str = "";
                int count = 0;
                Console.Write(day.Name + ": ");
                List<Hours> hours = (List<Hours>)day.GetValue(restaurant, null);

                if (hours != null && hours.Count == 0)
                    str += ("Closed");
                
                foreach (var hour in hours)
                {
                        str += UnixTimeToDateTime(hour.Value);
                        if (hour.Type == "open")
                            str += " - ";

                        if (count != 0 && count < hours.Count && hour.Type == "closed")
                            str += ",";

                        count++;

                }
               
                

            }
        }
        private string UnixTimeToDateTime(long unixtime)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime.ToString("htt");
        }
    }
}
