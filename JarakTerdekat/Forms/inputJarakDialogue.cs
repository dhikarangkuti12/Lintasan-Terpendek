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

    public partial class inputJarakDialogue : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public double jarak;

        public inputJarakDialogue(double currentJarak)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            InitializeComponent();

            txtField_jarakInput.Text = currentJarak.ToString();
        }

        private void btn_updateJarak_Click(object sender, EventArgs e)
        {
            if(txtField_jarakInput.Text != "")
            {
                jarak = double.Parse(txtField_jarakInput.Text);
            }
        }
    }
}
