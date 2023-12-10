using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastreioLogi.Models
{
   
    internal class LogiDados : INotifyPropertyChanged
    {
        private int id;
        private string status;
        private string dataEnvio;
        private string dataPrev;
        private string historico;
        public int Id {get; set;}

        public string Status { get => status; set => status = value; } 

        public string DataEnvio { get; set; }

        public string DataPrev { get; set; }

        public string Historico { get; set; }


        public LogiDados()
        {
            id = 0;
            status = "";
            dataEnvio = "";
            dataPrev = "";
            historico = "";
        }

        LogiDados logidados = new LogiDados
        {
            id = 0,
            status = "success",
            dataEnvio = "26/05/1996",
            dataPrev = "success",
            historico = "sucess"
        };


    }
}
