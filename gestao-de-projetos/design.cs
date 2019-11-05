using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Import the Material Skin
using MaterialSkin;
using MaterialSkin.Controls;

namespace gestao_de_projetos
{
    public partial class design : MaterialForm
    {
        public design()
        {
            InitializeComponent();
        }

        public design(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public static void configMaterialSkin(MaterialForm instance)
        {
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(instance);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal700, Primary.Teal800,
                Primary.Teal700, Accent.Red700,
                TextShade.WHITE
            );
        }
    }
}
