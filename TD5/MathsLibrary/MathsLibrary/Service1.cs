using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathsLibrary
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Service1 : IMathsOperations
    {
        public int Add(int arg1, int arg2)
        {
            return arg1 + arg2;
        }

        public int Multiply(int arg1, int arg2)
        {
            return arg1 * arg2;
        }

        public int Subtract(int arg1, int arg2)
        {
            return arg1 - arg2;
        }
    }
}
