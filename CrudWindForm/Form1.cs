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

namespace CrudWindForm
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        #region HELPER
        private void Refrescar()
        {
            using (CrudsEntities db = new CrudsEntities())
            {
                var lst = from d in db.crud
                          select d;
                dataGridView1.DataSource = lst.ToList();
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Presentacion.Fmrtabla fmrtabla = new Presentacion.Fmrtabla();
            fmrtabla.ShowDialog();
            Refrescar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id =int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            if (id != null)
            {
                Presentacion.Fmrtabla fmrtabla = new Presentacion.Fmrtabla();
                fmrtabla.ShowDialog();
            }
            Refrescar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            if (id != null)
            {
                using(CrudsEntities db= new CrudsEntities())
                {
                    crud cruds = db.crud.Find(id);
                    db.crud.Remove(cruds);
                    db.SaveChanges();
                }
            }
            Refrescar();
        }
    }
}
