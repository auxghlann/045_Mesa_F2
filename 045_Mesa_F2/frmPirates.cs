using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _045_Mesa_F2
{
    public partial class frmPirates : Form
    {
        private Database db = new Database();
        public frmPirates()
        {
            InitializeComponent();
        }
        // variables

        private int selected_id;
        private bool is_new_record;

        // Helper Functiton
        public void fill_dataGridView(string type)
        {

            if (type.Equals("search"))
            {
                grdData.DataSource = db.search_information(txtKeyword.Text, cboSearchPirateGroup.Text);
            }
            else if (type.Equals("load"))
            {
                grdData.DataSource = db.get_information();
            }
            else if (type.Equals("view"))
            {
                grdData.DataSource = db.display_selected_information(this.selected_id);
            }
            grdData.Columns["ID"].Visible = false;
            grdData.Columns["age"].Visible = false;
        }

        public void InitializeCBO()
        {
            DataTable dt = db.get_pirate_group();
            cboPirateGroup.DataSource = dt;
            cboSearchPirateGroup.DataSource = dt;

            cboPirateGroup.DisplayMember = "PIRATE GROUP";
            cboSearchPirateGroup.DisplayMember = "PIRATE GROUP";

            cboPirateGroup.ValueMember = "PIRATE GROUP";
            cboSearchPirateGroup.ValueMember = "PIRATE GROUP";
            //String[] pirateGroups = { "Straw Hat Pirates", "Red Hair Pirates", "Black Beard Pirate Fleet",
            //                            "Whitebeard Pirates", "Big Mom Pirates", "Heart Pirates", "Beast Pirates", "Roger Pirates"};


            //foreach (String pirateGroup in pirateGroups)
            //{
            //    cboPirateGroup.Items.Add(pirateGroup);
            //    cboSearchPirateGroup.Items.Add(pirateGroup);
            //}
        }

        public void clear_fields()
        {
            txtAlias.Clear();
            txtName.Clear();
            txtAge.Clear();
            cboPirateGroup.SelectedIndex = -1;
            txtBounty.Clear();
        }

        public void disable_pirate_group_control()
        {
            txtAlias.Enabled = false;
            txtName.Enabled = false;
            txtAge.Enabled = false;
            cboPirateGroup.Enabled = false;
            txtBounty.Enabled = false;
        }
        public void enable_pirate_group_control()
        {
            txtAlias.Enabled = true;
            txtName.Enabled = true;
            txtAge.Enabled = true;
            cboPirateGroup.Enabled = true;
            txtBounty.Enabled = true;
        }

        public void add_record()
        {
            int rows_affected = db.insert_record(txtAlias.Text, txtName.Text, Convert.ToInt32(txtAge.Text), cboPirateGroup.Text, Convert.ToDouble(txtBounty.Text));


            if (rows_affected > 0)
            {
                MessageBox.Show("Record Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_fields();
            }
            else
            {
                MessageBox.Show("Record Failed to Add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update_record()
        {
            int rows_affected = db.update_record(this.selected_id, txtAlias.Text, txtName.Text, Convert.ToInt32(txtAge.Text), cboPirateGroup.Text, Convert.ToDouble(txtBounty.Text));
            if (rows_affected > 0)
            {
                MessageBox.Show("Record Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_fields();
            }
            else
            {
                MessageBox.Show("Record Failed to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // WinForm Function
        private void frmPirates_Load(object sender, EventArgs e)
        {
            fill_dataGridView("load");
            InitializeCBO();
            clear_fields();
            disable_pirate_group_control();
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnView.Enabled = false;
            this.is_new_record = false;
        }



        private void grdData_SelectionChanged(object sender, EventArgs e)
        {
            if (grdData.SelectedRows.Count > 0)
            {
                DataRowView selected_row = grdData.SelectedRows[0].DataBoundItem as DataRowView;

                if (selected_row != null)
                {
                    btnDelete.Enabled = true;
                    btnView.Enabled = true;
                    this.selected_id = Convert.ToInt32(selected_row["ID"]);
                    txtAlias.Text = selected_row["ALIAS"].ToString();
                    txtName.Text = selected_row["GIVEN NAME"].ToString();
                    txtAge.Text = selected_row["age"].ToString();
                    cboPirateGroup.Text = selected_row["PIRATE GROUP"].ToString();
                    txtBounty.Text = selected_row["BOUNTY"].ToString();
                }
            }
        }

        private void btnSearchPirate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKeyword.Text) || string.IsNullOrEmpty(cboSearchPirateGroup.Text))
            {
                MessageBox.Show("Both Search Controls are required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            fill_dataGridView("search");
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear_fields();
            disable_pirate_group_control();
            btnNewRecord.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            clear_fields();
            enable_pirate_group_control();
            btnNewRecord.Enabled = false;
            btnSave.Enabled = true;
            this.is_new_record = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAlias.Text) || string.IsNullOrEmpty(txtAge.Text) || string.IsNullOrEmpty(cboPirateGroup.Text) || string.IsNullOrEmpty(txtBounty.Text))
            {
                MessageBox.Show("All Fields are required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Convert.ToInt32(txtBounty.Text) <= 0)
            {
                MessageBox.Show("Bounty must be greater than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (this.is_new_record)
            {
                add_record();
            }
            else
            {
                update_record();
            }

            fill_dataGridView("load");
            disable_pirate_group_control();
            this.is_new_record = false;
            btnSave.Enabled = false;
            btnNewRecord.Enabled = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnNewRecord.Enabled = false;
            enable_pirate_group_control();
            fill_dataGridView("view");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dg = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dg == DialogResult.Yes)
            {
                int rows_affected = db.remove_record(this.selected_id);

                if (rows_affected > 0)
                {
                    MessageBox.Show("Record Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_fields();
                }
                else
                {
                    MessageBox.Show("Record Failed to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fill_dataGridView("load");
            }

        }
    }
}
