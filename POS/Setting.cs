using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            ReadConfig();
        }
        public void ReadConfig() {
            try
            {  
                var host = ConfigurationManager.AppSettings["dbhost"].ToString();
                var port = ConfigurationManager.AppSettings["port"].ToString();
                var dbname = ConfigurationManager.AppSettings["dbname"].ToString();
                var user = ConfigurationManager.AppSettings["user"].ToString();
                var pass = ConfigurationManager.AppSettings["pass"].ToString();

                txtDbHost.Text = host;
                txtDbPort.Text = port;
                txtDbName.Text = dbname;
                txtDbUser.Text = user;
                txtDbPass.Text = pass;
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดผลาด "+ex.Message,"เกิดข้อผิดผลาด",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void setConfig(String host = "localhost",String port ="1433",String dbname= "myDatabase", String user = "weera",String pass = "passTh")
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings.RemoveAt(1);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");

                config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings.Add(
                    new ConnectionStringSettings("strConnString",
                    "Server="+host+"\\SQLEXPRESS;Database="+dbname+";User Id="+user+";Password="+pass+";"));


                config.AppSettings.Settings["dbhost"].Value = host;
                config.AppSettings.Settings["port"].Value=port;
                config.AppSettings.Settings["dbname"].Value = dbname;
                config.AppSettings.Settings["user"].Value=user;
                config.AppSettings.Settings["pass"].Value=pass;

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("AppSettings");
                ConfigurationManager.RefreshSection("connectionStrings");

                txtDbHost.Text = host;
                txtDbPort.Text = port;
                txtDbName.Text = dbname;
                txtDbUser.Text = user;
                txtDbPass.Text = pass;
            }
            catch (Exception ex)
            {
                MessageBox.Show("มีข้อมผิดผลาดเกิดขึ้น " +ex.ToString()+" "+ ex.Message);
            }
        }

        private void cancleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadConfig();
        }

        private void resetToDefualtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("การตั้งค่าฐานข้อมูลจะเปลี่ยนแปลงกลับเป็นค่าเรื่มต้นทันที","ใช่หรือไม่",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                setConfig();
            }            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setConfig(txtDbHost.Text.Trim(),txtDbPort.Text.Trim(),txtDbName.Text.Trim(),txtDbUser.Text.Trim(),txtDbPass.Text.Trim());
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);            
        }       
    }
}
