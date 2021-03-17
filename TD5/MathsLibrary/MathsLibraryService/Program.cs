using ServiceReference2;
using System;

namespace MathsLibraryService
{
    class Program
    {
        static void Main(string[] args)
        {
            MathsOperationsClient client = new MathsOperationsClient(MathsOperationsClient.EndpointConfiguration.BasicHttpBinding_IMathsOperations); 
            Console.WriteLine("1+2=" + client.AddAsync(1, 2).Result);
        }
    }
}
