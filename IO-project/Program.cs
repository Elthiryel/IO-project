using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
			// TESTING PARSER
			ProblemInstance pi = new ProblemInstance();
			InputParser.FillRoadsAndCrossroads(pi, "test.txt");
            InputParser.FillRoutes(pi, "routes.xml");

            var algorithm = new RandomStartAdaptiveGeneticAlgorithm(pi, 10, 10, 10000);
            algorithm.Run();
            var result = algorithm.GetResult();
            //Console.WriteLine("END, result: " + result);
            foreach(var light in result.Keys)
                Console.WriteLine("KEY: "+light+" VALUE: "+String.Format(@"NorthSouth Duration:{0}, SouthWest Duration:{1}, Phase: {2}",result[light].NorthSouthDuration,result[light].WestEastDuration, result[light].TimeShift));
            Console.ReadLine();
        }
    }
}
