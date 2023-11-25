using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_Svr_Municipalite
{
    public interface IDepotElections
    {
        public void AjouterElection(Election p_Election);
        public IEnumerable<Election> ChercherElectionParCodeGeographique(int p_codeGeograhpique);
        public IEnumerable<Election> ListerElections();
        public void MAJElection(Election p_Election);
    }
}
