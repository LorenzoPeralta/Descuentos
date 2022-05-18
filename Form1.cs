using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Lorenzo Peralta ID:1104686

namespace Descuentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            Deducciones();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarColumnasTabla();
        }
        public void InicializarColumnasTabla()
        {
            dvgDeducciones.Columns.Add("sueldo", "Sueldo");
            dvgDeducciones.Columns.Add("isr", "ISR");
            dvgDeducciones.Columns.Add("afp", "AFP");
            dvgDeducciones.Columns.Add("ssf", "SSF");
            dvgDeducciones.Columns.Add("retenciones", "Retenciones");
            dvgDeducciones.Columns.Add("sueldo neto", "Sueldo Neto");
            dvgDeducciones.Columns.Add("sueldo quincenal", "Sueldo Quincenal");
        }

        public void Deducciones()
        {
            double sueldo = Convert.ToInt32(txtSueldoData.Text);
            double sBruto = sueldo;
            double nSueldo;

            double excedente;
            double iAnual;
            double vISR = 0;
            double vAFP = sueldo * 0.0287;
            double vSFS = sueldo * 0.0304;
            double deducciones = vAFP + vSFS;
            double bImpuesto = sBruto - deducciones;
            double mAnual = bImpuesto * 12;
            double iMensual;
            double retenciones = vISR + vAFP + vSFS; ;


            if (mAnual > 416220 && mAnual <= 624329)
            {
                excedente = mAnual - 416220.01;
                iAnual = excedente * 0.15;
                iMensual = iAnual / 12;
                vISR = iMensual;
                nSueldo = bImpuesto - vISR;
                retenciones = vISR + vAFP + vSFS;
                dvgDeducciones.Rows.Add(sueldo, vISR, vAFP, vSFS, retenciones, nSueldo, nSueldo / 2);
            }
            else if (mAnual > 624329 && mAnual <= 867123)
            {
                excedente = mAnual - 624239.01;
                iAnual = excedente * 0.20 + 31216;
                iMensual = iAnual / 12;
                vISR = iMensual;
                nSueldo = bImpuesto - vISR;
                retenciones = vISR + vAFP + vSFS;
                dvgDeducciones.Rows.Add(sueldo, vISR, vAFP, vSFS, retenciones, nSueldo, nSueldo / 2);
            }
            else if (mAnual > 867123)
            {
                excedente = mAnual - 867123.01;
                iAnual = excedente * 0.25 + 79776;
                iMensual = iAnual / 12;
                vISR = iMensual;
                nSueldo = bImpuesto - vISR;
                retenciones = vISR + vAFP + vSFS;
                dvgDeducciones.Rows.Add(sueldo, vISR, vAFP, vSFS, retenciones, nSueldo, nSueldo / 2);
            }
            else
            {
                dvgDeducciones.Rows.Add(sueldo, vISR, vAFP, vSFS, retenciones, bImpuesto, bImpuesto / 2);
            }
        }
    }
}

