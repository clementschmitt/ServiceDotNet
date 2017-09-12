using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MonPremierServiceWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return $"valeur passé en paramètre : {value}";
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public float GetPrice(string id)
        {
            System.Threading.Thread.Sleep(10000);
            switch (id)
            {
                case "Mario et les lapins Crétins":
                    return 49.99f;
                case "PS4":
                    return 399.99f;
                case "Assasins Creed":
                    return 29.99f;
                case "Far Cry 5":
                    return 69.99f;
                case "Destiny 2":
                    return 59.99f;
                case "OverWatch":
                    return 39.99f;
                case "League of Legends":
                    return 0;
                default:
                    return 99999999999999999.999f;
            }
        }
    }
}
