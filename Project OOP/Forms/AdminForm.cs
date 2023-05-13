using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace Project_OOP.Forms
{
    public partial class AdminForm : MaterialForm
    {
        public AdminForm()
        {
            InitializeComponent();


            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
            Primary.Green800,
            Primary.Green900,
            Primary.Green500,
            Accent.LightGreen200,
            TextShade.WHITE
                    );
        }
    }
}