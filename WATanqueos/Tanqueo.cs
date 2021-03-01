using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WATanqueos.Models;

namespace WATanqueos
{
    public partial class Tanqueo : Form
    {
        WAdbContext context = new WAdbContext();
        Vehiculo vehiculo = new Vehiculo();
        Models.Tanqueo tanqueo = new Models.Tanqueo();
        public Tanqueo()
        {
            InitializeComponent();
        }

        private void Tanqueo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtValor.Text != "")
            {
                tanqueo.IdIsla = int.Parse((cmbIslas.SelectedItem as ComboBoxModel).ValueMember.ToString());
                tanqueo.IdVehiculo = vehiculo.IdVehiculo;
                tanqueo.Placa = vehiculo.Placa;
                tanqueo.Valor = Convert.ToInt32(txtValor.Text);
                context.Tanqueos.Add(tanqueo);
                context.SaveChanges();
                MessageBox.Show("Tanqueo Registrado");
                txtPlaca.Text = "";
                txtValor.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese un Valor");
            }
        }

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            cmbIslas.Items.Clear();
            vehiculo = context.Vehiculos.Where(vh => vh.Placa.Equals(txtPlaca.Text)).ToList().FirstOrDefault();
            if (vehiculo == null)
            {
                MessageBox.Show("Lo siento, Este Vehiculo no existe");
            }
            else
            {
                List<Isla> islas = context.Islas.Where(i => i.IdTipoCombustible.Equals(vehiculo.IdTipoCombustible)).ToList();
                //ObservableCollection<Isla> isl = new ObservableCollection<Isla>();
                foreach (Isla isla in islas)
                {
                    ComboBoxModel isl = new ComboBoxModel();
                    isl.DisplayMember = isla.NIsla;
                    isl.ValueMember = isla.IdIsla;
                    cmbIslas.Items.Add(isl);
                }
            }
        }
    }
}
