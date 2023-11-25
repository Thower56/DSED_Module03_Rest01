using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_Svr_Municipalite
{
    public class ManipulationElections
    {
        public IDepotElections m_depotElections;

        public ManipulationElections(IDepotElections depotElections)
        {
            this.m_depotElections = depotElections;
        }

        public IEnumerable<Election> ChercherElectionParCodeGeographique(int p_id)
        {
            return m_depotElections.ChercherElectionParCodeGeographique(p_id);
        }

        public IEnumerable<Election> ListerElection()
        {
            return m_depotElections.ListerElections();
        }

        public void AjouterElection(Election p_election)
        {
            m_depotElections.AjouterElection(p_election);
        }

        public void MAJElection(Election p_election)
        {
            m_depotElections.MAJElection(p_election);
        }
    }
}
