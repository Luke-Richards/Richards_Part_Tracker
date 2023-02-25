using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Richards_Part_Tracker
{
    public partial class PartTracker : Form
    {
        public PartTracker()
        {
            InitializeComponent();
            viewPartTracker.Columns.Add("Part Name", -2, HorizontalAlignment.Left);
            viewPartTracker.Columns.Add("Bin #", -2, HorizontalAlignment.Left);
            viewPartTracker.Columns.Add("Quantity", -2, HorizontalAlignment.Left);
            viewPartTracker.Columns.Add("Description", -2, HorizontalAlignment.Left);

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] row = { "hello", "part", "location" };
            viewPartTracker.Items.Add(new ListViewItem(row));

        }


        private void create_config()
        {
            string path = "./Richards_Part_Tracker.exe.config";
            if (!File.Exists(path))
            {
                File.Create(path);
                File.WriteAllText(path, "<?xml version=\"1.0\" encoding=\"utf - 8\" ?>< configuration >< startup >< supportedRuntime version = \"v4.0\" sku = \".NETFramework,Version=v4.7.2\" /></ startup >< System.Windows.Forms.ApplicationConfigurationSection >< add key = \"DpiAwareness\" value = \"PerMonitorV2\" /></ System.Windows.Forms.ApplicationConfigurationSection ></ configuration > ");
            }
        }

        private void viewPartTracker_Resize(object sender, EventArgs e)
        {
            //stops the "overflow/extra column" when the form is resized
            foreach (ColumnHeader col in viewPartTracker.Columns)
            {
                col.Width = -2;
            }
        }
    }
}
