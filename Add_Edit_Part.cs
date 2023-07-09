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
        string targetName = "notarget";
        SQLiteConnection con = new SQLiteConnection();
        public Add_Edit_Part(SQLiteConnection con, int selected = -1)
        {
            this.con = con;
            InitializeComponent();
            
            if (selected != -1)
            {
                target = selected;
                isedit = true;
                SQLiteCommand command = con.CreateCommand();
                command.CommandText = "SELECT part_name,bin_number,quantity,description FROM parts WHERE parts.id = "+(selected)+";";
                var result = command.ExecuteReader();
                if (result.Read()){
                    targetName = result.GetString(0).ToString();
                    txtName.Text = result.GetValue(0).ToString();
                    txtBin.Text = result.GetValue(1).ToString();
                    txtQuantity.Text = result.GetValue(2).ToString();
                    txtDesc.Text = result.GetValue(3).ToString();
                }
                btnAdd.Text = "Save";
                btnDelete.Visible = true;
                this.Text = "Edit Part";
                hasChanged();
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
                if (command.ExecuteNonQuery() > 0)
                {
                    this.Close();
                }
            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure you want to save changes to: "+targetName,
                                     "Confirm Changes",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    command.CommandText = "UPDATE parts SET " +
                        "'part_name' = '" + txtName.Text + "', 'bin_number' = '" + txtBin.Text + "', 'quantity' = '" + txtQuantity.Text + "', 'description' = '" + txtDesc.Text + "'" +
                        "WHERE parts.id = " + target + ";";

                    if (command.ExecuteNonQuery() > 0)
                    {
                        this.Close();
                    }
                }
                
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                SQLiteCommand command = con.CreateCommand();
                command.CommandText = "DELETE FROM parts WHERE parts.id = "+(target)+"; ";

                if (command.ExecuteNonQuery() > 0)
                {
                    this.Close();
                }
            }
        }
        private void hasChanged()
        {

            if (target != -1)
            {
                SQLiteCommand command = con.CreateCommand();
                command.CommandText = "SELECT part_name,bin_number,quantity,description FROM parts WHERE parts.id = " + (target) + ";";

                var result = command.ExecuteReader();
                if (result.Read())
                {
                    if(txtName.Text != result.GetValue(0).ToString() ||
                       txtBin.Text != result.GetValue(1).ToString() ||
                       txtQuantity.Value != Int32.Parse(result.GetValue(2).ToString()) ||
                       txtDesc.Text != result.GetValue(3).ToString())
                    {
                        btnAdd.Enabled = true;
                    }
                    else
                    {
                        btnAdd.Enabled = false;
                    }

                }

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            hasChanged();
        }

        private void txtBin_TextChanged(object sender, EventArgs e)
        {
            hasChanged();
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            hasChanged();
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            hasChanged();
        }
    }
}
