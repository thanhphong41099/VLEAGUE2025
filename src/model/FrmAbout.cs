using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VLeague.src.helper;

namespace VLeague.src.model
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();

            try
            {
                string licenseKey = LicenseKeyHandler.readLicenseLocalFile();
                LicenseKeyHandler.writeLicenseLocalFile(licenseKey);
                string expirationDate = LicenseKeyHandler.onGetValueOfLicenseByKey(licenseKey, "expirationDate");
                DateTimeOffset dateOfExpired = LicenseKeyHandler.onGetExpirationDate(expirationDate);
                string expirationDate2 = dateOfExpired.Date.ToString("dd/MM/yyyy");


                txtAbout.Text = 
                    $"Version 1.0.3. Expiration: ({expirationDate2})\n" +
                    $"Copyright © VTVBroadcom MS.\n" +
                    $"All rights reserved http://vtvms.vn.\n\n" +
                    $"--------------------------------------------------";
            }
            catch 
            {
                txtAbout.Text =
                $"Version 1.0.3. Ex: No License Key\n" +
                $"Copyright © VTVBroadcom MS.\n" +
                $"All rights reserved http://vtvms.vn\n\n." +
                $"--------------------------------------------------";
            }
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
