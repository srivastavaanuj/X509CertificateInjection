using System;
using X509CertficateInjectionAndRetrieval;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var embeddedCert = CertificateDetails.GetExecutingAssemblyCertificate(); 

            //Embedded certificate details
            if (embeddedCert != null)
            {

                Console.WriteLine("Embedded certificate Details");
                Console.WriteLine(embeddedCert.GetSerialNumberString());
                Console.WriteLine(embeddedCert.Issuer);
            }

            //Imported certificate details
            Console.WriteLine("Input X509 Certificate path:");
            var path = Console.ReadLine();
            var importedCert = CertificateDetails.ImportX509AppCertificate(path);

            if (importedCert != null)
            {
                Console.WriteLine("Imported certificate Details");
                Console.WriteLine(importedCert.GetSerialNumberString());
                Console.WriteLine(importedCert.Issuer);
            }

            Console.ReadLine();
        }

        
    }
}
