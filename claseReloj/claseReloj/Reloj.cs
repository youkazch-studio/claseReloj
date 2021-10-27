using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseReloj
{
    class Reloj
    {
        private int _relojId;
        private string _marca;
        private string _modelo;

        public string _publishedDate { get; set; }
        public string _ISBN { get; set; }

        public Reloj() 
        { }
        public Reloj(int relojId, string marca, string modelo, string fechadelanzamiento, string ISBN)  
        {
            _bookId = relojId;
            _title = marca;
            _subtitle = modelo;
            _publishedDate = fechadelanzamiento;
            _ISBN = ISBN;
        }

        public reloj(string marca)
        {
            _marca = marca;
        }
        public Reloj(string marca, string modelo)
        {
            _marca = marca;
            _modelo = modelo;
        }

       

     
        public void setrelojId(int relojId)
        {
            _relojId = relojId;
        }
        public int getrelojId()
        {
            return _relojId;
        }
        
        public void setmarca(string marca)
        {
            _marca = marca;
        }
        public string getmarca()
        {
            return _marca;
        }
        
        public void setmodelo(string modelo)
        {
            _modelo = modelo;
        }
        public string getmodelo()
        {
            return _modelo;
        }


        
        public string getrelojInfo()
        {
            return _relojId + " " + _marca + " " + _modelo + " " + _publishedDate + " "
                + _ISBN;
        }

        public string getmarcamodelo()
        {
            return "Marca" + _marca + "Modelo:" + _modelo;
        }
    }
}
