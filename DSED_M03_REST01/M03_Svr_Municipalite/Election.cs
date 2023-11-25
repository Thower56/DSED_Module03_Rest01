using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_Svr_Municipalite
{
    public class Election
    {
        public Election(int id, int codeGeographique, DateTime dateTime)
        {
            Id = id;
            CodeGeographique = codeGeographique;
            DateElection = dateTime;
        }

        public int Id { get; set; }
        public int CodeGeographique { get; set; }
        public DateTime DateElection { get; set; }


    }
}
