using System;
using Project_OOP.Classes;
using MaterialSkin;
using MaterialSkin.Controls;
namespace Project_OOP.Forms
{
    public partial class AdminForm : MaterialForm
    {
        private Administrator Administrator { get; set; }
        public AdminForm(Administrator admin)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Green800,
            Primary.Green900,
            Primary.Green500,
            Accent.LightGreen200,
            TextShade.WHITE);
        }

    }
}