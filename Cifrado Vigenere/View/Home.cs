using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cifrado_Vigenere
{
    public partial class formHome : Form
    {
        // Propiedad para listar los caracteres del Abecedario
        public List<char> Abecedario { get; set; }

        // Variables privadas para controlar el idioma y opciones del Abecedario
        private string _idioma;
        private string _opcion;

        public formHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            // Inicializar la lista vacia
            Abecedario = new List<char>();

            toolStripStLblInfo.Text = "";
            btnCalculate.Enabled = false;

            // Establece el primer Abecedario
            cmbBxAbc.SelectedIndex = 0;
            cmbBxOptions.SelectedIndex = 0;

            // Establece que se quiere cifrar
            radBtnCipher.Checked = true;
        }

        private void CmbBxAbc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia el texto a cifrar
            richTxtBxSource.Text = "";
            txtBxKey.Text = "";
            _idioma = cmbBxAbc.Text;
            _opcion = cmbBxOptions.Text;

            // Cambia el Abecedario con el que se trabajara
            Abecedario = Vigenere.cambioAbecedario(_opcion, _idioma);

            // Muestra el Abecedario seleccionado
            richTxtBxAbc.Text = Abecedario.ToAbc();
        }

        private void CmbBxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia el texto a cifrar
            richTxtBxSource.Text = "";
            txtBxKey.Text = "";
            _idioma = cmbBxAbc.Text;
            _opcion = cmbBxOptions.Text;

            // Cambia el Abecedario con el que se trabajara
            Abecedario = Vigenere.cambioAbecedario(_opcion, _idioma);

            // Muestra el Abecedario seleccionado
            richTxtBxAbc.Text = Abecedario.ToAbc();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Guarda el texto a cifrar/descifrar
            var text = richTxtBxSource.Text;
            var key = txtBxKey.Text;

            richTxtBxResult.Text = "";
            key = key.ToEqualize(text);

            // TODO: Cambiar a funciones separadas (Cifrado y Descifrado)
            // Analiza el texto a cifrar/descifrar
            for (var i = 0; i < text.Length; i++)
            {
                int num;
                // Cifrado
                if (radBtnCipher.Checked)
                    num = Abecedario.IndexOf(text[i]) + Abecedario.IndexOf(key[i]);
                // Descifrado
                else
                    num = Abecedario.IndexOf(text[i]) - Abecedario.IndexOf(key[i]);

                // Desplaza el Abecedario segun el desplazamiento
                if (num < 0) num += Abecedario.Count;

                // Modifica el caracter
                var newCaracter = Abecedario[num % Abecedario.Count];
                richTxtBxResult.Text += newCaracter;
            }

            // Muestra la informacion del analisis
            toolStripStLblInfo.Text = text.Length + " caracteres";
            toolStripStLblInfo.Text += radBtnCipher.Checked ? " cifrados" : " descifrados";
        }

        private void BtnShowHide_Click(object sender, EventArgs e)
        {
            // Efecto visual para mostrar el Abecedario
            splitContInfo.Panel1Collapsed = !splitContInfo.Panel1Collapsed;
            btnShowHide.Text = splitContInfo.Panel1Collapsed ? "MOSTRAR" : "OCULTAR";
        }

        private void TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo caracteres dentro del Abecedario
            if (Abecedario.Contains(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ToolStripStLblAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por: Óskar Calí\n\nOctubre 2019", "ABOUT", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }

        private void TxtBx_TextChanged(object sender, EventArgs e)
        {
            if (!richTxtBxSource.Text.Equals("") && !txtBxKey.Text.Equals(""))
            {
                btnCalculate.Enabled = true;
                return;
            }

            btnCalculate.Enabled = false;
        }
    }
}