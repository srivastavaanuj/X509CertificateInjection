using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace X509CertficateInjectionAndRetrieval
{
   public static class CertificateDetails 
    {
        public static X509Certificate FetchAppCertificate(string assemblyPath)    
        {
            X509Certificate embeddedCert = null;

            try
            {
                embeddedCert = X509Certificate.CreateFromSignedFile(assemblyPath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unsigned assembly:  {0} ", e.Message);
            }

            return embeddedCert;

        }

        public static X509Certificate GetExecutingAssemblyCertificate() 
        {    
            var assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var cert = FetchAppCertificate(assemblyPath); 
            return cert;
        }

        public static X509Certificate ImportX509AppCertificate(string certificatePath)
        {
            X509Certificate cert = null;
            try
            {
               cert = new X509Certificate(File.ReadAllBytes(certificatePath));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:  {0} ", e.Message);
            }

            return cert;

        }

    }
}
