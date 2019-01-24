using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alta
{
    public partial class Form1 : Form
    {
        private IEscritorUsuario escritorUsuario = null;

        public Form1()
        {
            InitializeComponent();
            escritorUsuario = Configuracion.obtenerEstrategia();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            var usuario = new UsuarioDTO(txtNombre.Text, txtApellido.Text);            
            escritorUsuario.escribirUsuario(usuario);
        }
    }
}
