using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudWindForm.Models;

namespace CrudWindForm.Presentacion
{
    public partial class Fmrtabla : Form
    {
        public Fmrtabla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CrudsEntities db=new CrudsEntities())
            {
                Random rnd = new Random();
                crud cruds = new crud();
                cruds.nombre = txtNombre.Text;
                cruds.correo = txtCorreo.Text;
                cruds.fecha_nacimiento = dtpFechaNacimiento.Value;
                cruds.Id = rnd.Next(1, 1000000000);
                db.crud.Add(cruds);
                db.SaveChanges();
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
