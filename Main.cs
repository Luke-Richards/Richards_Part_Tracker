using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Richards_Part_Tracker
{
    public partial class PartTracker : Form
    {
        SQLiteConnection con = new SQLiteConnection(@"URI=file:./part_database.sqlite");
        IDictionary<int, int> positionID = new Dictionary<int, int>();
        
        public PartTracker()
        {
            InitializeComponent();
            //SQLiteConnection.CreateFile("part_database.sqlite");
            
            con.Open();
            createSQLite(con);
            loadParts();
            
            
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form add = new Add_Edit_Part(con);
            add.ShowDialog();
            loadParts();
        }

        private void loadParts()
        {
            viewPartTracker.Clear();
            viewPartTracker.Columns.Add("Part Name", -2, HorizontalAlignment.Left);
            viewPartTracker.Columns.Add("Bin #", -2, HorizontalAlignment.Left);
            viewPartTracker.Columns.Add("Quantity", -2, HorizontalAlignment.Left);
            viewPartTracker.Columns.Add("Description", -2, HorizontalAlignment.Left);
            SQLiteCommand command = con.CreateCommand();
            command.CommandText = "SELECT id, part_name,bin_number,quantity,description FROM parts";
            var result = command.ExecuteReader();
            positionID = new Dictionary<int, int>();
            for (int i = 1; result.Read(); i++)
            {
                Console.WriteLine(i.ToString()+", "+ result.GetValue(0).ToString());
                positionID.Add(i, Int32.Parse(result.GetValue(0).ToString())); //adding a key/value using the Add() method
                string[] row = new string[result.FieldCount];
                for (int j = 1; j < result.FieldCount; j++)
                {
                    row[j-1] = result.GetValue(j).ToString();
                }
                ListViewItem rowItem = new ListViewItem(row);
                rowItem.UseItemStyleForSubItems = false;

                bool isSearch = txtSearch.Text != "".Trim();
                bool find = !isSearch;
                if (isSearch)
                {
                    for (int j = 0; j < rowItem.SubItems.Count; j++)
                    {

                        if (rowItem.SubItems[j].Text.Contains(txtSearch.Text))
                        {
                            rowItem.SubItems[j].BackColor = System.Drawing.Color.Yellow;
                            Console.WriteLine(rowItem.SubItems[j].Text);
                            find = true;
                        }
                        else
                        {
                            rowItem.SubItems[j].BackColor = System.Drawing.Color.White;
                        }
                    }
                }
                if (find)
                {
                    viewPartTracker.Items.Add(rowItem);
                }
                
            }
            listViewResize(viewPartTracker);

        }



        private void listViewResize(ListView lv)
        {
            //stops the "overflow/extra column" when the form is resized
            foreach (ColumnHeader col in lv.Columns)
            {
                col.Width = -2;
            }
        }

        private void createSQLite(SQLiteConnection con)
        {
            SQLiteCommand command = con.CreateCommand();

            command.CommandText = "SELECT name FROM sqlite_master WHERE name='parts'";
            var name = command.ExecuteScalar();

            // check account table exist or not 
            // if exist do nothing 
            if (name == null || name.ToString() != "parts")
            {
                //first time setup
                command.CommandText = "CREATE TABLE parts (id INTEGER PRIMARY KEY AUTOINCREMENT,   " +
                                                          "part_name VARCHAR(20), " +
                                                          "bin_number VARCHAR(20), " +
                                                          "quantity int, " +
                                                          "description VARCHAR(20))";
                command.ExecuteNonQuery();
            }

            /*// table checker pls ignore
            command.CommandText = "SELECT * FROM parts";
            var result = command.ExecuteReader();
            for(int i = 0; i < result.FieldCount; i++)
            {
                Console.WriteLine(result.GetName(i));
            }
            //*/

            /*// table checker pls ignore
            command.CommandText = "INSERT INTO parts ('part_name','bin_number','quantity','description') VALUES ('oil','xxx',50,'engine oil');";
            command.ExecuteNonQuery();
            command.CommandText = "SELECT part_name,bin_number,quantity,description FROM parts";
            var result = command.ExecuteReader();
            
            for (int i = 1; result.Read(); i++)
            {
                
                string output = "";
                for (int j = 0; j < result.FieldCount; j++)
                {
                    output += result.GetValue(j)+", ";
                }
                Console.WriteLine(output);



            }
            //*/

        }

        private void PartTracker_ResizeEnd(object sender, EventArgs e)
        {
            listViewResize(viewPartTracker);
        }

        private void viewPartTracker_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void viewPartTracker_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form edit = new Add_Edit_Part(con, positionID[viewPartTracker.FocusedItem.Index+1]);
            edit.ShowDialog();
            loadParts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           loadParts();
        }



        /*//
        private void viewPartTracker_Resize(object sender, EventArgs e)
        {
            listViewResize(viewPartTracker);
        }

        private void createConfig()
        {
            string path = "./Richards_Part_Tracker.exe.config";
            if (!File.Exists(path))
            {
                File.Create(path);
                File.WriteAllText(path, "<?xml version=\"1.0\" encoding=\"utf - 8\" ?>< configuration >< startup >< supportedRuntime version = \"v4.0\" sku = \".NETFramework,Version=v4.7.2\" /></ startup >< System.Windows.Forms.ApplicationConfigurationSection >< add key = \"DpiAwareness\" value = \"PerMonitorV2\" /></ System.Windows.Forms.ApplicationConfigurationSection ></ configuration > ");
            }
        }
        //*/
    }
}
