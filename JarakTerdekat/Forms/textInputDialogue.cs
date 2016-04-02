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

        public textInputDialogue(string title, string hint, string currentValue)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            InitializeComponent();

            this.Text = title;
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
