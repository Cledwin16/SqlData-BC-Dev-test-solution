using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClient.ClassLibrary
{
    public class Client
    {
        public string xName { get; set; }
        public string xSurname { get; set; }
        public string xMail { get; set; }

        public string RowEntry 
        {
            get {
                return $"{xName }{xSurname}({xMail})";
            }
        }
    }
}
