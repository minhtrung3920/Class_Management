using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class ListForm : Form
    {
        private ClassManagement Business;
        public ListForm()
        {
            InitializeComponent();
            this.Business = new ClassManagement();
            this.Load += ListForm_Load; //show CLASS
            this.btnCreate.Click += btnCreate_Click; // add a class
            this.btndelete.Click += btndelete_Click; // delete a class
            // this.btnView.Click += btnView_Click;  another way
            this.grdList.Click += grdList_Click; // double click to update
        }

        private void LoadAllClass()
        {
            var classes = this.Business.GetClasses();
            this.grdList.DataSource = classes;
        }

        void grdList_Click(object sender, EventArgs e)
        {
            if (this.grdList.SelectedRows.Count == 1)
            {
                var @class = (CLASSS)this.grdList.SelectedRows[0].DataBoundItem;

                var updateForm = new UpdateClassForm(@class.ID);
                updateForm.ShowDialog();
                this.LoadAllClass();
            }
        }

        void ListForm_Load(object sender, EventArgs e)
        {
            this.LoadAllClass();
        }

        void btnCreate_Click(object sender, EventArgs e)
        {
            var createForm = new CreateClassForm();
            createForm.ShowDialog();
            this.LoadAllClass();
        }

        void btndelete_Click(object sender, EventArgs e)
        {
            if (this.grdList.SelectedRows.Count == 1)
            {
                if(MessageBox.Show("Do you wanna delete this row ?", "Confirm",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var @class = (CLASSS)this.grdList.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteClass(@class.ID);
                    MessageBox.Show("Delete class successfully.");
                    this.LoadAllClass();
                }
            }
        }
    }
}
