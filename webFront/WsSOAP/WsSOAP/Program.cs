using System;
using ServiceReference1;

namespace WsSOAP
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorSoapClient calculator = new CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap);
            Console.WriteLine("2 + 3 = {0}", calculator.AddAsync(2,3).Result);
        }
    }
}
