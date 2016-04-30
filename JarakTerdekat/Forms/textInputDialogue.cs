using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;


namespace JarakTerdekat
{

    public partial class textInputDialogue : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public string inputText;

        public CheckBox checkBox;

        public textInputDialogue(string title, string hint, string currentValue)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            InitializeComponent();

            this.Text = title;
            checkBox = checkBox1;

            txtField_jarakInput.Text = currentValue;
            txtField_jarakInput.Hint = hint;
        }

        private void btn_updateJarak_Click(object sender, EventArgs e)
        {
            if(txtField_jarakInput.Text != "")
            {
                inputText = txtField_jarakInput.Text;
            }
        }
    }
}
