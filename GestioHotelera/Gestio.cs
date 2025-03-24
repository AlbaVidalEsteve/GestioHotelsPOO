using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHotels
{
    public class Gestio
    {

        public List<Hotels> HotelsList = new List<Hotels>();
        public List<Clients> ClientsList = new List<Clients>();
        public List<Reserves> reservesList = new List<Reserves>();
        public Hotels HotelActual;
        public Clients ClientActual;


        #region CRUD clients
        public Clients BuscarClients(string codiClient)
        {
            Clients clientTrobat = ClientsList.Find(x => x.CodiClient == codiClient);
            return clientTrobat;
        }
              
        public void ActualitzarClient(string codiClient, string nomClient, string poblacioClient, int edatClient)
        {
           ClientActual.CodiClient = codiClient;
           ClientActual.NomClient = nomClient;
           //ClientActual.CognomClient = cognomClient;
           ClientActual.PoblacioClient = poblacioClient;
           ClientActual.EdatClient = edatClient;
        }               

        public void AfegirClient(string codi, string nomClient, string poblacio, int edat)
        {
            Clients client = new Clients();
            client.CodiClient = codi;
            client.NomClient = nomClient;
            client.PoblacioClient = poblacio;
            client.EdatClient = edat;
            ClientsList.Add(client);
        }
        
        public void EsborrarClient()
        {
            ClientsList.Remove(ClientActual);
        }

        #endregion

        #region CRUD Hotels   
        //public bool BuscarReservaHotel(string codiHotel)
        //{
        //    bool existeix = false;
        //    Reserves reservaTrobada = reservesList.Find(x => x.CodiHotel == codiHotel);
        //    if(reservaTrobada != null)
        //    {
        //        existeix = true;
        //    }
        //    return existeix;
        //}
        public void ActualitzarHotel(string codiHotel, string nomHotel, string pobHotel, int numHabitacions)
        {
            HotelActual.CodiHotel = codiHotel;
            HotelActual.NomHotel = nomHotel;
            HotelActual.PobHotel = pobHotel;
            HotelActual.NumHabitacions = numHabitacions;
        }  
        
        public void AfegirHotel(string codi, string nomHotel, string poblacio, int numHab)
        {
            Hotels hotel = new Hotels();
            hotel.CodiHotel = codi;
            hotel.NomHotel = nomHotel;
            hotel.PobHotel = poblacio;
            hotel.NumHabitacions = numHab;
            HotelsList.Add(hotel);

        } 
        
        public void EsborrarHotel()
        {
            HotelsList.Remove(HotelActual);
        }


        #endregion

        #region Reserves
        public void AfegirReserva(DateTime dataEntrada, int nits)
        {
            Reserves novaReserva = new Reserves();
            novaReserva.CodiHotel = HotelActual.CodiHotel;
            novaReserva.CodiClient = ClientActual.CodiClient;
            novaReserva.DataEntrada = dataEntrada.Date;
            novaReserva.NumDies = nits;
            reservesList.Add(novaReserva);
        }
        #endregion
    }
}
