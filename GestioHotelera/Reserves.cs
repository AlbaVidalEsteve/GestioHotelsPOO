using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHotels
{
    public class Reserves
    {
        public string CodiClient { get; set; }
        public string CodiHotel { get; set; }

        public DateTime DataEntrada { get; set; }

        public int NumDies { get; set; }        
    }
}
