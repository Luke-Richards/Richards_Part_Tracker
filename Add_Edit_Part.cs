using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Richards_Part_Tracker
{
    public partial class Add_Edit_Part : Form
    {
        Boolean isedit = false;
        int target = -1;
        SQLiteConnection con = new SQLiteConnection();
        public Add_Edit_Part(SQLiteConnection con, int selected = -1)
        {
            this.con = con;
            InitializeComponent();
            
            if (selected != -1)
            {
                target = selected;
                isedit = true;
                Console.WriteLine(selected);
                SQLiteCommand command = con.CreateCommand();
                command.CommandText = "SELECT part_name,bin_number,quantity,description FROM parts WHERE parts.id = "+(selected+1)+";";
                var result = command.ExecuteReader();
                if (result.Read()){
                    txtName.Text = result.GetValue(0).ToString();
                    txtBin.Text = result.GetValue(1).ToString();
                    txtQuantity.Text = result.GetValue(2).ToString();
                    txtDesc.Text = result.GetValue(3).ToString();
                }
                btnAdd.Text = "Edit";
                this.Text = "Edit Part";

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SQLiteCommand command = con.CreateCommand();
            if (!isedit)
            {
                command.CommandText = "INSERT INTO parts ('part_name','bin_number','quantity','description') " +
                "VALUES ('" + txtName.Text + "','" + txtBin.Text + "','" + txtQuantity.Text + "','" + txtDesc.Text + "');";
            }
            else
            {
                command.CommandText = "UPDATE parts SET " +
                "'part_name' = '" + txtName.Text + "', 'bin_number' = '" + txtBin.Text + "', 'quantity' = '" + txtQuantity.Text + "', 'description' = '" + txtDesc.Text + "'" +
                "WHERE parts.id = "+(target+1)+";";
            }

            if (command.ExecuteNonQuery() > 0)
            {
                this.Close();
            }
        }
    }
}
