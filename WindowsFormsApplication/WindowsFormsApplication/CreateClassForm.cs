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
    public partial class CreateClassForm : Form
    {
        private ClassManagement business;
        public CreateClassForm()
        {
            InitializeComponent();
            this.business = new ClassManagement();

            this.btnSave_1.Click += btnSave_1_Click;
            this.btnCancel_1.Click += btnCancel_1_Click;
        }

        void btnSave_1_Click(object sender, EventArgs e)
        {
            var name = this.txtClassName_1.Text;
            var description = this.txtDescrip_1.Text;

            this.business.AddClass(name, description);
            MessageBox.Show("Add new class successflly");
            this.Close();
        }

        void btnCancel_1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
