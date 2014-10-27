using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class Car
    {
        public static int Length = 2;

		public Route Route { get; set; }

        public Car(int createTime,Route route)
        {
            this.Route = route;
        }
    }
}
