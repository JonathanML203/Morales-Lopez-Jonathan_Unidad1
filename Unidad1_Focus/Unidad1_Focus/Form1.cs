using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad1_Focus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.MouseHover += new EventHandler(Control_MouseHover);
            button1.MouseHover += new EventHandler(Control_MouseHover);
            comboBox1.MouseHover += new EventHandler(Control_MouseHover);
            checkBox1.MouseHover += new EventHandler(Control_MouseHover);
            radioButton1.MouseHover += new EventHandler(Control_MouseHover);
        }

        private void Control_MouseHover(object sender, EventArgs e)
        {
            if (sender == textBox1)
            {
                labelDescripcion.Text = "TextBox1: Permite la entrada de texto.";
            }
            else if (sender == button1)
            {
                labelDescripcion.Text = "Button1: Permite ejecutar una acción al hacer clic.";
            }
            else if (sender == comboBox1)
            {
                labelDescripcion.Text = "ComboBox1: Permite seleccionar un ítem de una lista desplegable.";
            }
            else if (sender == checkBox1)
            {
                labelDescripcion.Text = "CheckBox1: Permite seleccionar o deseleccionar una opción.";
            }
            else if (sender == radioButton1)
            {
                labelDescripcion.Text = "RadioButton1: Permite seleccionar una opción entre varias.";
            }
        }
    }
}
