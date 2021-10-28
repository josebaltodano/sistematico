using domain.Activo;
using domain.Enums;
using domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoSistematico
{
    public partial class FmrActivofijo : Form
    {
        public ImodelActivo imodel  { get; set; }
        int a = 0;
        public FmrActivofijo(int aa)

        {
            imodel = new ImodelActivo();
            this.a = aa;
            InitializeComponent();
        }

        private void FmrActivofijo_Load(object sender, EventArgs e)
        {
            cmbTipoActivo.Items.AddRange(Enum.GetValues(typeof(EnumsActivo)).Cast<object>().ToArray());
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("no se puede numeros");
            }
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("no se puede numeros");
            }
        }

        private void TxtValorActivo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se pueden letras");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ActivoFijo activo = new ActivoFijo()
            {
                Nombre = txtNombre.Text,

                codigo = txtCodigo.Text,
                descripcion = txtDescripcion.Text,
                FechaDeAdquisicion = dtpAdquision.Value,
                ValorActivo = decimal.Parse(txtValorActivo.Text),
                ValorResidual = decimal.Parse(txtValorResidual.Text),
                TipoActivo = (EnumsActivo)cmbTipoActivo.SelectedIndex,
                depreciacion = (Depreciacion)cmbdepreciacion.SelectedIndex,
                Id = a

            };
            activo.VidaUtil = imodel.VidaUtil(activo.TipoActivo);
            imodel.Add(activo);

            Dispose();
        }
    }
}
