using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientCharges
{
   public class ClientBased
    {

        private IStrategy _strategy;

        public ClientBased()
        { }
        public ClientBased(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        public interface IStrategy
        {
            object DoAlgorithm(int data);
        }
        public double AdCharges(double charge,int hours)
        {
            Console.WriteLine();
            Console.WriteLine("\nHours : "+ hours);
            Console.WriteLine("Client Charges  : " + charge);

            double result = charge * hours;
            Console.Write("Total Charge = "+ result + "\n");
            Console.WriteLine();
            return result;
        }

    }
}
