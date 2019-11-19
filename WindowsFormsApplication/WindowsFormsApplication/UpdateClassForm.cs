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
    public partial class UpdateClassForm : Form
    {
        private int ClassId;
        private ClassManagement business;
        public UpdateClassForm(int id)
        {
            InitializeComponent();
            this.ClassId = id;
            this.business = new ClassManagement();
            this.btnSave_2.Click += btnSave_2_Click;
            this.btnCancel_2.Click += btnCancel_2_Click;
            this.Load += UpdateClassForm_Load;
        }

        void UpdateClassForm_Load(object sender, EventArgs e)
        {
            var oldClass = this.business.GetClass(this.ClassId);
            this.txtClassName_2.Text = oldClass.NAME;
            this.txtDecrip_2.Text = oldClass.DESCRIP;
        }

        void btnCancel_2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_2_Click(object sender, EventArgs e)
        {
            var name = this.txtClassName_2.Text;
            var descrip = this.txtDecrip_2.Text;
            this.business.EditClass(this.ClassId, name, descrip);
            MessageBox.Show("Update");
        }
    }
}
