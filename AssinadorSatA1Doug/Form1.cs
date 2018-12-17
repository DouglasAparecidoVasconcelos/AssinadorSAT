using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Input;


namespace AssinadorSatA1Doug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAssinar_Click(object sender, EventArgs e)
        {
            try

            {

                X509Store store = new X509Store(StoreLocation.CurrentUser);

                store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);

                X509Certificate2Collection certCollection = (X509Certificate2Collection)store.Certificates;

                X509Certificate2Collection foundCollection = (X509Certificate2Collection)certCollection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);

                X509Certificate2Collection selectedcollection = X509Certificate2UI.SelectFromCollection(foundCollection,

                    "Select a Certificate.", "Select a Certificate from the following list to get information on that certificate", X509SelectionFlag.SingleSelection);



                if (selectedcollection.Count > 0)

                {

                    X509Certificate2 cert = selectedcollection[0];



                    string certificateData = "Subject: " + cert.Subject + Environment.NewLine + "IssuerName: " + cert.Issuer

                            + "\nSerialNumber: " + cert.SerialNumber + "\nFriendlyName:\n" + cert.FriendlyName;



                    MessageBox.Show(certificateData, "Certificate Data",

                       MessageBoxButtons.OK, MessageBoxIcon.Information);



                    if (cert.Verify())

                    {

                        MessageBox.Show(cert.Subject + " is a valid certificate.", cert.FriendlyName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(cert.Subject + " is not a valid certificate.", cert.FriendlyName,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                    RSACryptoServiceProvider rsaEncryptor = (RSACryptoServiceProvider)cert.PrivateKey;

                    byte[] cipherData = rsaEncryptor.Encrypt(Encoding.UTF8.GetBytes(txtSoftwareHouse.Text + txtCliente.Text), true);

                    txtAssinatura.Text = Convert.ToBase64String(cipherData);

                }

            }

            catch (CryptographicException ex)

            {

                MessageBox.Show(ex.Message, ex.GetType().ToString(),

                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, ex.GetType().ToString(),

                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
