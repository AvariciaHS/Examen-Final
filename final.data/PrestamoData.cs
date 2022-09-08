using Final.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.AppWin
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var prestamo = new Prestamo();
            var frm = new frmConsultarPrestamos(prestamo);
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }

    internal class frmConsultarPrestamos
    {
        private Prestamo prestamo;

        public frmConsultarPrestamos(Prestamo prestamo)
        {
            this.prestamo = prestamo;
        }

        internal DialogResult ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}

