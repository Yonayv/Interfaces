using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{ 
    /// <summary>
    /// An interface named IGenre was established
    /// automatic properties get & set have been made for ESRB, Title, and Genre. 
    /// an public string method is defined and called Describe
    /// </summary>
    interface IGenre 
    {
        public string Esrb { get; set; }
         
        public string Genre { get; set; }

        public string Title { get; set; }

        public string Describe();
    }
}
