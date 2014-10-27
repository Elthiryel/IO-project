using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class Road
    {
		private static int lastId = -1;

		private static int GetUniqueId()
		{
			++lastId;
			return lastId;
		}

		public Road(int length, Crossroad firstCrossroad, Crossroad secondCrossroad, int laneCount, Orientation orientation)
		{
			Id = GetUniqueId();
			Length = length;
			First = firstCrossroad;
			Second = secondCrossroad;
			IncreasingLaneCount = laneCount;
			DecreasingLaneCount = laneCount;
			Orientation = orientation;
            IncreasingLanes = new LinkedList<CarDistance>[laneCount];
            DecreasingLanes = new LinkedList<CarDistance>[laneCount];
		    for (int i = 0; i < laneCount; i++)
		    {
                IncreasingLanes[i] = new LinkedList<CarDistance>();
                DecreasingLanes[i] = new LinkedList<CarDistance>();
		    }         
		}

		public int Id { get; set; }

		public Orientation Orientation { get; set; }

        //get later from Crossroads
        public int Y { get; set; } // what is x or y? road is NOT a point :P
        public int X { get; set; }
        public int Length { get; set; }

        //lesser coordinates 
        public Crossroad First { get; set; }

        public int IncreasingLaneCount { get; set; }
        public int DecreasingLaneCount { get; set; }

        //bigger coordinates
        public Crossroad Second { get; set; }

        public LinkedList<CarDistance>[] IncreasingLanes { get; set; }
        public LinkedList<CarDistance>[] DecreasingLanes { get; set; }

        public void AddCarToIncreasingLane(Car car)
        {
            //
        }

        public void AddCarToDecreasingLane(Car car)
        {
           //
        }
       
    }

	public enum Orientation {
		NorthSouth,
		EastWest
	}
}
