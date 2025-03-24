using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassesHotels;


namespace GestioHotels
{
    public partial class frmHotels : Form
    {
        private Gestio gestio = new Gestio();
        public frmHotels()
        {
            InitializeComponent();
        }      
       
        private void lstHotels_DoubleClick(object sender, EventArgs e)
        {
            SelectHotel();   
        }

        private void SelectHotel()
        {
            if (lstHotels.SelectedItems.Count == 1)
            {
                gestio.HotelActual = (Hotels)lstHotels.SelectedItem;
                txtCodi.Enabled = false;
                txtNomHotel.Enabled = false;
                txtPobHotel.Enabled = false;
                txtNumHab.Enabled = false;
                MostrarCampsHotel();
            }

        }

        private void MostrarCampsHotel()
        {
            Hotels hotelActual = gestio.HotelActual;
            txtNomHotel.Text =  hotelActual.NomHotel;
            txtCodi.Text = hotelActual.CodiHotel;
            txtPobHotel.Text = hotelActual.PobHotel;
            txtNumHab.Text = hotelActual.NumHabitacions.ToString();
        }

        private void BorrarCampsHotel()
        {
            txtNomHotel.Text = "";
            txtCodi.Text = "";
            txtPobHotel.Text = "";
            txtNumHab.Text = "";
        }

        private void frmHotels_Load(object sender, EventArgs e)
        {
            ActualitzarLstBoxHotels();
            ActualitzarLstBoxClients();
            ActualitzarGrid();
        }

        private void ActualitzarGrid()
        {
            dtgReserves.DataSource = null;
            dtgReserves.DataSource = gestio.reservesList;
        }

        private void ActualitzarLstBoxClients()
        {
            lstClients.DataSource = null;
            lstClients.DisplayMember = "NomClient";
            lstClients.ValueMember = "CodiClient";
            lstClients.DataSource = gestio.ClientsList; //posar lists en private i fer una funcio que retorni la llista?
        }

        private void ActualitzarLstBoxHotels()
        {
            lstHotels.DataSource = null;
            lstHotels.DisplayMember = "NomHotel";
            lstHotels.ValueMember = "CodiHotel";
            lstHotels.DataSource = gestio.HotelsList; //posar lists en private i fer una funcio que retorni la llista?
        }

        private void lstClients_DoubleClick(object sender, EventArgs e)
        {
            SelectClient();
        }

        private void SelectClient()
        {
            if (lstClients.SelectedItems.Count == 1)
            {
                gestio.ClientActual = (Clients)lstClients.SelectedItem;
                txtSoci.Enabled = false;
                txtNomClient.Enabled = false;
                txtPobClient.Enabled = false;
                txtEdat.Enabled = false;
                MostrarCampsClient();
            }
        }


        private void MostrarCampsClient()
        {
            Clients clientActual = gestio.ClientActual;
            txtSoci.Text = clientActual.CodiClient;
            txtNomClient.Text = clientActual.NomClient;
            //txtCognomClient.Text = clientActual.CognomClient;
            txtPobClient.Text = clientActual.PoblacioClient;
            txtEdat.Text = clientActual.EdatClient.ToString();            
        }
        private void BorrarCampsClient()
        {
            txtSoci.Text = "";
            txtNomClient.Text = "";
            //txtCognomClient.Text = "";
            txtPobClient.Text = "";
            txtEdat.Text = "";
        }


        private void btnReserva_Click(object sender, EventArgs e)
        {
            AfegirReserva();
        }

        private void AfegirReserva()
        {
            DateTime data = dtpReserva.Value;
            if(int.TryParse(txtDies.Text, out int dies) && data != null)
            {
                gestio.AfegirReserva(data, dies);
                ActualitzarGrid();
            }
            else
            {
                MessageBox.Show("La data o els dies no són vàlids");
            }            
        }



        #region CRUD clients


        private void btnEditClient_Click(object sender, EventArgs e)
        {
            EditClient();
        }

        private void EditClient()
        {
            txtSoci.Enabled = true;
            txtNomClient.Enabled = true;
            //txtCognomClient.Enabled = true;
            txtPobClient.Enabled = true;
            txtEdat.Enabled = true;
        }

        private void btnActualitzar_Click(object sender, EventArgs e)
        {
            ActualitzarClient();
        }

        private void ActualitzarClient()
        {
            string codiClient = txtSoci.Text;
            string nomClient = txtNomClient.Text;
            //string cognomClient = txtCognom.Text;
            string pobClient = txtPobClient.Text;
            if(int.TryParse(txtEdat.Text, out int edatClient))
            {
                gestio.ActualitzarClient(codiClient, nomClient, pobClient, edatClient);
                ActualitzarLstBoxClients();
                ActualitzarGrid();
                BorrarCampsClient();
            }
            else
            {
                MessageBox.Show("Edat client ha de ser un número");
            }
        }

        private void btnAfegirClient_Click(object sender, EventArgs e)
        {
            AfegirClient();
            ActualitzarLstBoxClients();
            BorrarCampsClient();
        }

        private void AfegirClient()//cal o es pot posar a l'event?
        {
            gestio.AfegirClient(txtSoci.Text, txtNomClient.Text, txtPobClient.Text, int.Parse(txtEdat.Text));
            ActualitzarLstBoxClients();            
        }

        private void btnEsborrarClient_Click(object sender, EventArgs e)
        {
            gestio.EsborrarClient();
            ActualitzarLstBoxClients();
            BorrarCampsClient();
        }

        //private void EsborrarClient()
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        #region CRUD Hotels

        private void btnActualitzarHotel_Click(object sender, EventArgs e)
        {
            ActualitzarHotel();
        }
        private void ActualitzarHotel()
        {
            string codiHotel = txtCodi.Text;
            string nomHotel = txtNomHotel.Text;
            //string cognomClient = txtCognom.Text;
            string pobHotel = txtPobHotel.Text;
            if (int.TryParse(txtNumHab.Text, out int numHabitacions))
            {
                gestio.ActualitzarHotel(codiHotel, nomHotel, pobHotel, numHabitacions);
                ActualitzarLstBoxHotels();
                ActualitzarGrid();
                BorrarCampsHotel();
            }
            else
            {
                MessageBox.Show("El número habitacions ha de ser un número");
            }
        }

        private void btnAfegirHotel_Click_1(object sender, EventArgs e)
        {
            AfegirHotel();
            ActualitzarLstBoxHotels();
            BorrarCampsHotel();
        }
        private void AfegirHotel()
        {
            //si el Hotel/ClientActual esta aqui i nomes enviem el client o hotel a la funcio?
            gestio.AfegirHotel(txtCodi.Text, txtNomHotel.Text, txtPobHotel.Text, int.Parse(txtNumHab.Text));
            ActualitzarLstBoxHotels();
        }

        private void btnEsborrarHotel_Click(object sender, EventArgs e)
        {
            gestio.EsborrarHotel();
            ActualitzarLstBoxHotels();
            BorrarCampsHotel();
        }
        //private void EsborrarHotel()
        //{

        //}

        private void btnEditarHotel_Click(object sender, EventArgs e)
        {
            EditarHotel();
        }
        private void EditarHotel()
        {
            txtCodi.Enabled = true;
            txtNomHotel.Enabled = true;
            txtNumHab.Enabled = true;
            txtPobHotel.Enabled = true;
        }


        #endregion


    }
}
