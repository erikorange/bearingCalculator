using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bearing
{
    class Program
    {
        static void Main(string[] args)
        {
            double homeLat = 0;
            double homeLon = 0;

            double airLat = 0;
            double airLon = 0;

            double radFactor = (Math.PI / 180.0);

            homeLat = homeLat * radFactor;
            Console.WriteLine("homeLat: " + homeLat.ToString());

            airLat = airLat * radFactor;
            Console.WriteLine("airLat: " + airLat.ToString());

            double diffLon = radFactor * (airLon - homeLon);
            Console.WriteLine("diffLon: " + diffLon.ToString());

            double x = Math.Sin(diffLon) * Math.Cos(airLat);
            Console.WriteLine("x: " + x.ToString());

            double y = Math.Cos(homeLat) * Math.Sin(airLat) - (Math.Sin(homeLat) * Math.Cos(airLat) * Math.Cos(diffLon));
            Console.WriteLine("y: " + y.ToString());

            double init_bearing = Math.Atan2(x, y);
            Console.WriteLine("init_bearing: " + init_bearing.ToString());

            init_bearing = init_bearing * (180.0 / Math.PI);
            Console.WriteLine("init_bearing: " + init_bearing.ToString());

            double compass_bearing = (init_bearing + 360.0) % 360.0;
            Console.Write("Bearing: " + compass_bearing.ToString());
            Console.ReadKey();
        }
    }
}
