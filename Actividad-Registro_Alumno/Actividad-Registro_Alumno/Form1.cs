using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Registro_Alumno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtmatricula.Text = "SM";
        }

        //ComboBox----------------------------------------------------//
        private void cbxnivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxgrado.Items.Clear();
            cbxgrado.Text = "";

            if (cbxnivel.Text.Equals("Inicial"))
            {
                cbxgrado.Items.Add("3 Años");
                cbxgrado.Items.Add("4 Años");
                cbxgrado.Items.Add("5 Años");
                lstcursos.Items.Clear();
                //cbxgrado.Text = "3 Años";
            }
            if (cbxnivel.Text.Equals("Primaria"))
            {
                cbxgrado.Items.Add("1° Grado");
                cbxgrado.Items.Add("2° Grado");
                cbxgrado.Items.Add("3° Grado");
                cbxgrado.Items.Add("4° Grado");
                cbxgrado.Items.Add("5° Grado");
                cbxgrado.Items.Add("6° Grado");
                lstcursos.BackColor = Color.White;
                lstcursos.Items.Clear();
                //cbxgrado.Text = "1° Grado";
            }
            if (cbxnivel.Text.Equals("Secundaria"))
            {
                cbxgrado.Items.Add("1° Secundaria");
                cbxgrado.Items.Add("2° Secundaria");
                cbxgrado.Items.Add("3° Secundaria");
                cbxgrado.Items.Add("4° Secundaria");
                cbxgrado.Items.Add("5° Secundaria");
                lstcursos.BackColor = Color.White;
                lstcursos.Items.Clear();
                //cbxgrado.Text = "1° Secundaria";
            }
        }

        private void cbxgrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstcursos.Items.Clear();
            //------------------------------------------------//
            //Inicial-----------------------------------------//
            if (cbxgrado.Text.Equals("3 Años"))
            {
                lstcursos.Items.Add("Matematica Pichon");
                lstcursos.Items.Add("Comunicacion Loro");
                lstcursos.Items.Add("Arte del oso");
                lstcursos.BackColor = Color.Aqua;
            }
            if (cbxgrado.Text.Equals("4 Años"))
            {
                lstcursos.Items.Add("Matematica Pichon");
                lstcursos.Items.Add("Comunicacion Loro");
                lstcursos.Items.Add("Arte del oso");
                lstcursos.BackColor = Color.Beige;
            }
            if (cbxgrado.Text.Equals("5 Años"))
            {
                lstcursos.Items.Add("Matematica Pichon");
                lstcursos.Items.Add("Comunicacion Loro ");
                lstcursos.Items.Add("Arte del oso");
                lstcursos.BackColor = Color.DarkOrange;
            }
            //------------------------------------------------//
            //Primaria----------------------------------------//
            if (cbxgrado.Text.Equals("1° Grado"))
            {
                lstcursos.Items.Add("Matematica");
                lstcursos.Items.Add("CSS");
                lstcursos.Items.Add("Comunicacion");
                //lstcursos.BackColor = Color.White;
            }
            if (cbxgrado.Text.Equals("2° Grado"))
            {
                lstcursos.Items.Add("Matematica");
                lstcursos.Items.Add("CSS");
                lstcursos.Items.Add("Comunicacion");
                //lstcursos.BackColor = Color.White;
            }
            if (cbxgrado.Text.Equals("3° Grado"))
            {
                lstcursos.Items.Add("Matematica");
                lstcursos.Items.Add("CSS");
                lstcursos.Items.Add("Comunicacion");
                //lstcursos.BackColor = Color.White;
            }
            if (cbxgrado.Text.Equals("4° Grado"))
            {
                lstcursos.Items.Add("Matematica");
                lstcursos.Items.Add("CSS");
                lstcursos.Items.Add("Comunicacion");
                //lstcursos.BackColor = Color.White;
            }
            if (cbxgrado.Text.Equals("5° Grado"))
            {
                lstcursos.Items.Add("Matematica");
                lstcursos.Items.Add("CSS");
                lstcursos.Items.Add("Comunicacion");
                //lstcursos.BackColor = Color.White;
            }
            if (cbxgrado.Text.Equals("6° Grado"))
            {
                lstcursos.Items.Add("Matematica");
                lstcursos.Items.Add("CSS");
                lstcursos.Items.Add("Comunicacion");
                //lstcursos.BackColor = Color.White;
            }
            //------------------------------------------------//
            //Secundaria--------------------------------------//
            if (cbxgrado.Text.Equals("1° Secundaria"))
            {
                lstcursos.Items.Add("C.T.A");
                lstcursos.Items.Add("Matematica II");
                lstcursos.Items.Add("Ingles");
                //lstcursos.BackColor = Color.White;
            }
            if (cbxgrado.Text.Equals("2° Secundaria"))
            {
                lstcursos.Items.Add("C.T.A");
                lstcursos.Items.Add("Matematica II");
                lstcursos.Items.Add("Ingles");
                //lstcursos.BackColor = Color.White;
            }
            if (cbxgrado.Text.Equals("3° Secundaria"))
            {
                lstcursos.Items.Add("C.T.A");
                lstcursos.Items.Add("Matematica II");
                lstcursos.Items.Add("Ingles");
                //lstcursos.BackColor = Color.White;
            }
            if (cbxgrado.Text.Equals("4° Secundaria"))
            {
                lstcursos.Items.Add("C.T.A");
                lstcursos.Items.Add("Matematica II");
                lstcursos.Items.Add("Ingles");
                //lstcursos.BackColor = Color.White;
            }
            if (cbxgrado.Text.Equals("5° Secundaria"))
            {
                lstcursos.Items.Add("C.T.A");
                lstcursos.Items.Add("Matematica II");
                lstcursos.Items.Add("Ingles");
                //lstcursos.BackColor = Color.White;
            }

        }

        //CheckBox----------------------------------------------------//
        private void chkmañana_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmañana.Checked)
            {
                chktarde.Checked = false;
                chknoche.Checked = false;
            }
        }

        private void chktarde_CheckedChanged(object sender, EventArgs e)
        {
            if (chktarde.Checked)
            {
                chkmañana.Checked = false;
                chknoche.Checked = false;
            }
        }

        private void chknoche_CheckedChanged(object sender, EventArgs e)
        {
            if (chknoche.Checked)
            {
                chkmañana.Checked = false;
                chktarde.Checked = false;
            }
        }
        
        //ListBox-----------------------------------------------------//
        private void lstcursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //------------------------------------------------//
            //Inicial-----------------------------------------//
            if (lstcursos.Text.Equals("Matematica Pichon"))
            {
                txtcurso.Text = "Matematica Pichon";
            }
            if (lstcursos.Text.Equals("Comunicacion Loro"))
            {
                txtcurso.Text = "Comunicacion Loro";
            }
            if (lstcursos.Text.Equals("Arte del oso"))
            {
                txtcurso.Text = "Arte del oso";
            }
            //------------------------------------------------//
            //Primaria----------------------------------------//
            if (lstcursos.Text.Equals("Matematica"))
            {
                txtcurso.Text = "Matematica";
            }
            if (lstcursos.Text.Equals("CSS"))
            {
                txtcurso.Text = "CSS";
            }
            if (lstcursos.Text.Equals("Comunicacion"))
            {
                txtcurso.Text = "Comunicacion";
            }
            //------------------------------------------------//
            //Secundaria--------------------------------------//
            if (lstcursos.Text.Equals("C.T.A"))
            {
                txtcurso.Text = "C.T.A";
            }
            if (lstcursos.Text.Equals("Matematica II"))
            {
                txtcurso.Text = "Matematica II";
            }
            if (lstcursos.Text.Equals("Ingles"))
            {
                txtcurso.Text = "Ingles";
            }
        }

        //Botones-----------------------------------------------------//
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            if(txtmatricula.Text.Length > 0 && txtape_paterno.Text.Length > 0 && txtape_materno.Text.Length > 0 && txtnombres.Text.Length > 0 &&
                cbxnivel.Text.Length > 0 && txtcurso.Text.Length > 0 && txtexa_parcial.Text.Length > 0 && txtexa_final.Text.Length > 0)
            {
                txtmatricula.Text = "";
                txtape_paterno.Text = "";
                txtape_materno.Text = "";
                txtnombres.Text = "";
                rbtmasculino.Checked = true;
                rbtfemenino.Checked = false;
                cbxnivel.Text = null;
                cbxgrado.Text = null;
                lstcursos.Items.Clear();
                chkmañana.Checked = false;
                chktarde.Checked = false;
                chknoche.Checked = false;
                txtcurso.Text = "";
                txtexa_parcial.Text = "";
                txtexa_final.Text = "";
                txtpromedio.Text = "";
                txtsit_academica.Text = "";
                MessageBox.Show("Los datos se guardaron satisfactoriamente", "Confimarcion", MessageBoxButtons.OK);

            }

            else
            {
                MessageBox.Show("Falta completar informacion", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnevaluar_Click(object sender, EventArgs e)
        {
            DialogResult cambiar;
            cambiar = MessageBox.Show("Esta seguro que desea proceder", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (txtmatricula.Text.Length > 0 && txtape_paterno.Text.Length > 0 && txtape_materno.Text.Length > 0 && txtnombres.Text.Length > 0)
            {
                if (cambiar == DialogResult.Yes)
                {
                    int nta1 = int.Parse(txtexa_parcial.Text);
                    int nta2 = int.Parse(txtexa_final.Text);
                    int promedio = (nta1 + nta2) / 2;
                    txtpromedio.Text = Convert.ToString(promedio);

                    if (promedio > 10)
                    {
                        txtsit_academica.Text = "Aprobado";
                    }
                    else
                    {
                        txtsit_academica.Text = "Desaprobado";
                    }
                    MessageBox.Show("El alumno " + txtnombres.Text + " " + txtape_paterno.Text + " " + txtape_materno.Text + " a sido " + txtsit_academica.Text + " con la nota de " + txtpromedio.Text + ".", "Comprobacion");
                }
                else
                {
                    MessageBox.Show("La operacion a sido cancelada", "Validacion");
                }
            }
            else
            {
                MessageBox.Show("Falta datos personales", "Imcompleto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult salida;
            salida = MessageBox.Show("Esta seguro de desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (salida == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
