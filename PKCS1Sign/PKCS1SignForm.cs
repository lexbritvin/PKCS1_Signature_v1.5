using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKCS1Signature
{
    public partial class signForm : Form
    {
        private String inputFilename;
        public signForm()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputPlainText.Text))
            {
                MessageBox.Show("Input text should not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(inputPrivateExponent.Text))
            {
                MessageBox.Show("The private key is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(inputPrivateModulus.Text))
            {
                MessageBox.Show("The private key is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                RSAKey privateKey = new RSAKey(BigInteger.Parse(inputPrivateModulus.Text), BigInteger.Parse(inputPrivateExponent.Text));
                RSAKey publicKey = new RSAKey(BigInteger.Parse(inputPublicModulus.Text), BigInteger.Parse(inputPublicExponent.Text));
                byte[] octetSignature = RSAPKCS1V1_5Signature.sign(privateKey, inputPlainText.Text);
                inputSignature.Text = RSAPKCS1V1_5Signature.OS2IP(octetSignature).ToString();
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputSignature.Text))
            {
                MessageBox.Show("Input text should not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(inputPublicExponent.Text))
            {
                MessageBox.Show("The public key is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(inputPublicModulus.Text))
            {
                MessageBox.Show("The public key is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                RSAKey publicKey = new RSAKey(BigInteger.Parse(inputPublicModulus.Text), BigInteger.Parse(inputPublicExponent.Text));
                BigInteger signature = BigInteger.Parse(inputSignature.Text);
                if (RSAPKCS1V1_5Signature.verify(publicKey, inputPlainText.Text, signature))
                {
                    MessageBox.Show("The text is original!", "Valid signature", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("The text was spoofed!", "Invalid signature", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnPlainLoad_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgPlainFileLoad.ShowDialog();
            if (result == DialogResult.OK)
            {
                inputFilename = dlgPlainFileLoad.FileName;
                inputPlainText.Text = File.ReadAllText(inputFilename);
            }
        }

        private void btnSignatureLoad_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgSignFileLoad.ShowDialog();
            if (result == DialogResult.OK)
            {
                inputFilename = dlgSignFileLoad.FileName;
                BigInteger sig = new BigInteger(File.ReadAllBytes(inputFilename));
                inputSignature.Text = sig.ToString();
            }
        }

        private void btnPlainSave_Click(object sender, EventArgs e)
        {
            if (dlgPlainFileSave.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlgPlainFileSave.FileName, inputPlainText.Text);
            }
        }

        private void btnEncryptedSave_Click(object sender, EventArgs e)
        {
            if (dlgSignatureFileSave.ShowDialog() == DialogResult.OK)
            {
                BigInteger sig = BigInteger.Parse(inputSignature.Text);
                File.WriteAllBytes(dlgSignatureFileSave.FileName, sig.ToByteArray());
            }
        }

        private void btnGeneratePrivateKey_Click(object sender, EventArgs e)
        {
            RSAKey privateKey;
            RSAKey publicKey;
            BigInteger encrypted;
            BigInteger decrypted;
            BigInteger test = new BigInteger(11);
            do
            {
                BigInteger p = PrimeNumberGenerator.GenerateLargePrime(155);
                BigInteger q = PrimeNumberGenerator.GenerateLargePrime(152);
                BigInteger n = p * q;
                BigInteger fi = (p - 1) * (q - 1);
                BigInteger publ_e = genCoPrime(fi);
                BigInteger d = modInverse(publ_e, fi);
                
                privateKey = new RSAKey(n, d);
                publicKey = new RSAKey(n, publ_e);
                encrypted = RSAPKCS1V1_5Signature.RSASP1(privateKey, test);
                decrypted = RSAPKCS1V1_5Signature.RSAVP1(publicKey, encrypted);
            } while (test != decrypted);
            //BigInteger n = BigInteger.Parse("145906768007583323230186939349070635292401872375357164399581871019873438799005358938369571402670149802121818086292467422828157022922076746906543401224889672472407926969987100581290103199317858753663710862357656510507883714297115637342788911463535102712032765166518411726859837988672111837205085526346618740053");
            //BigInteger publ_e = BigInteger.Parse("65537");
            //BigInteger d = BigInteger.Parse("89489425009274444368228545921773093919669586065884257445497854456487674839629818390934941973262879616797970608917283679875499331574161113854088813275488110588247193077582527278437906504015680623423550067240042466665654232383502922215493623289472138866445818789127946123407807725702626644091036502372545139713");
            
            inputPrivateModulus.Text = privateKey.getModulus().ToString();
            inputPrivateExponent.Text = privateKey.getExponent().ToString();
            inputPublicModulus.Text = publicKey.getModulus().ToString();
            inputPublicExponent.Text = publicKey.getExponent().ToString();
        }

        private void btnGeneratePublicKey_Click(object sender, EventArgs e)
        {
            BigInteger p = PrimeNumberGenerator.GenerateLargePrime(155);
            BigInteger q = PrimeNumberGenerator.GenerateLargePrime(152);
            BigInteger n = p * q;
            BigInteger publ_e = PrimeNumberGenerator.GenerateLargePrime(6);
            RSAKey publicKey = new RSAKey(n, publ_e);
            inputPublicModulus.Text = publicKey.getModulus().ToString();
            inputPublicExponent.Text = publicKey.getExponent().ToString();
        }

        BigInteger modInverse(BigInteger a, BigInteger n)
        {
            BigInteger i = n, v = 0, d = 1;
            while (a > 0)
            {
                BigInteger t = i / a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= n;
            if (v < 0) v = (v + n) % n;
            return v;
        }

        public BigInteger genCoPrime(BigInteger x)
        {
            bool done = false;
            BigInteger result = new BigInteger();

            while (!done)
            {
                result = PrimeNumberGenerator.GenerateLargePrime(6);
                // gcd test
                if (BigInteger.GreatestCommonDivisor(x, result) == BigInteger.One)
                    done = true;
            }

            return result;
        }

    }
}
