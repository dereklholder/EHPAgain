using System;
using System.Xml;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;

using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.Bcpg;
using System.Windows.Forms;

namespace OpenEdgeHostPayDemo
{
    public class SuperSecret
    {   
        public static void SaveInContainer(string ContainerName)
        {
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            //MessageBox.Show("Key added to container: \n {0}", rsa.ToXmlString(true));
        }
        public static void GetKey(string containerName)
        {
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = containerName;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);
        }
        
    }
}
