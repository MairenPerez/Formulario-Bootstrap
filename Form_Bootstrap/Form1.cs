using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Bootstrap
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0; // Cambiado de ComboBox1 a comboBox1 y uso de SelectedIndex
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                txtTitle.Text = textBox.Text;
            }
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                MessageBox.Show("Tipo de incidencia seleccionado: " + comboBox.SelectedItem);
                combType.Text = comboBox.Text;
            }
        }

        private void comboCriticity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                MessageBox.Show("Criticidad seleccionada: " + comboBox.SelectedItem);
                comboCriticity.Text = comboBox.Text;
            }
        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            /*
             * Guardamos los datos del formulario.
             * Validación: debe haber algo en Descripción, Titulo y alguno de los 3 chks marcado
             * La fecha puede estar vacía, es decir, puede ser nulo.
             */

            if (string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtTitle.Text) || (!checkProd.Checked && !checkPreppod.Checked && !checkDemo.Checked))
                MessageBox.Show("Campos incompletos");
            else
            {
                MessageBox.Show(@"Datos guardados correctamente"
                    + "\nTitle: " + txtTitle.Text
                    + "\nLocation: " + comboBox1.Text
                    + "\nDescription: " + txtDescription.Text
                    + "\nType: " + combType.Text
                    + "\nCriticity: " + comboCriticity.Text
                    + "\nDuration: " + numDuration.Text
                    + "\nStatus: " + comboStatus.Text
                    + (dtpStartDate.Checked ? "\nStart day: " + dtpStartDate.Value.ToString("dd/MM/yyyy") : string.Empty)
                );
                this.Close();
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            // Puede ser nulo
            DateTime? dateTime = dtpStartDate.Value;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            // Se cierra el formulario
            this.Close();
        }
    }
}
