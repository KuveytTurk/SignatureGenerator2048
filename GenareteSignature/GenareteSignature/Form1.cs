using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenareteSignature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbHttpMethod.SelectedIndex = 0;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cmbHttpMethod.SelectedIndex = 0;
            txtAccessToken.Text = string.Empty;
            txtAPIEndpointURL.Text = string.Empty;
            txtPrivateKey.Text = string.Empty;
            txtPostRequestBody.Text = string.Empty;
            txtSignature.Text = string.Empty;

            txtPostRequestBody.ReadOnly = true;
            txtAPIEndpointURL.ReadOnly = true;
        }

        private void cmbHttpMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    txtPostRequestBody.ReadOnly = true;
                    txtAPIEndpointURL.ReadOnly = true;
                    break;
                case 1:
                    txtPostRequestBody.ReadOnly = true;
                    txtAPIEndpointURL.ReadOnly = false;
                    txtPostRequestBody.Text = string.Empty;
                    txtAPIEndpointURL.Text = string.Empty;
                    break;
                case 2:
                    txtAPIEndpointURL.ReadOnly = true;
                    txtPostRequestBody.ReadOnly = false;
                    txtAPIEndpointURL.Text = string.Empty;
                    txtPostRequestBody.Text = string.Empty;
                    break;
                default:
                    txtPostRequestBody.ReadOnly = true;
                    txtAPIEndpointURL.ReadOnly = true;
                    break;

            }
        }

        private void btnCopySignature_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSignature.Text);
        }

        private void btnSignature_Click(object sender, EventArgs e)
        {

            ComboBox httpMethod = cmbHttpMethod;
            if (httpMethod.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen Metod seçiniz");
            }
            var privateKeyService = GetClientPrivateKeyFromRest(txtPrivateKey.Text);
            var key = privateKeyService.ExportParameters(true);
            string bodyData = httpMethod.SelectedIndex == 1 ? string.Concat("", txtAPIEndpointURL.Text.Split('?').Length <= 1 ? string.Empty : "?" + txtAPIEndpointURL.Text.Split('?')[1]) : txtPostRequestBody.Text;
            var signedData = SignData(txtAccessToken.Text + bodyData, key);
            txtSignature.Text = signedData;
        }

        static string SignData(string data, RSAParameters key)
        {
            // Create a UnicodeEncoder to convert between byte array and string.
            var byteConverter = new ASCIIEncoding();
            var originalData = byteConverter.GetBytes(data);

            try
            {
                // Create a new instance of RSACryptoServiceProvider using the 
                // key from RSAParameters.  
                var rsaProvider = new RSACryptoServiceProvider();

                rsaProvider.ImportParameters(key);

                // Hash and sign the data. Pass a new instance of SHA1CryptoServiceProvider
                // to specify the use of SHA1 for hashing.
                var signedData = rsaProvider.SignData(originalData, "SHA256");
                return Convert.ToBase64String(signedData);

            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        static RSACryptoServiceProvider GetClientPrivateKeyFromRest(string privateKey)
        {
            using (TextReader privateKeyTextReader = new StringReader(privateKey))
            {
                var readKeyPair = (AsymmetricCipherKeyPair)new PemReader(privateKeyTextReader).ReadObject();

                var privateKeyParams = ((RsaPrivateCrtKeyParameters)readKeyPair.Private);
                var cryptoServiceProvider = new RSACryptoServiceProvider();
                var parameters = new RSAParameters
                {

                    Modulus = privateKeyParams.Modulus.ToByteArrayUnsigned(),
                    P = privateKeyParams.P.ToByteArrayUnsigned(),
                    Q = privateKeyParams.Q.ToByteArrayUnsigned(),
                    DP = privateKeyParams.DP.ToByteArrayUnsigned(),
                    DQ = privateKeyParams.DQ.ToByteArrayUnsigned(),
                    InverseQ = privateKeyParams.QInv.ToByteArrayUnsigned(),
                    D = privateKeyParams.Exponent.ToByteArrayUnsigned(),
                    Exponent = privateKeyParams.PublicExponent.ToByteArrayUnsigned(),

                };

                cryptoServiceProvider.ImportParameters(parameters);
                return cryptoServiceProvider;
            }
        }
    }
}
