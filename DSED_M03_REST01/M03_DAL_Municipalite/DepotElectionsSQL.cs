using M03_Svr_Municipalite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_DAL_Municipalite
{
    internal class DepotElectionsSQL : IDepotElections
    {
        private readonly ApplicationDbContext m_dbContext;

        public DepotElectionsSQL(ApplicationDbContext p_context)
        {
            m_dbContext = p_context;
        }

        public void AjouterElection(Election p_election)
        {
            m_dbContext.Add(new ElectionDTO(p_election));
            m_dbContext.SaveChanges();
        }

        public IEnumerable<Election> ChercherElectionParCodeGeographique(int p_codeGeographique)
        {
            return m_dbContext.ELECTION.Where(e => e.CodeGeographique == p_codeGeographique).Select(e => e.VersEntite()).ToList();
        }

        public IEnumerable<Election> ListerElections()
        {
            return m_dbContext.ELECTION.Select(e => e.VersEntite()).ToList();
        }

        public void MAJElection(Election p_election)
        {
            ElectionDTO e = m_dbContext.ELECTION.Where(e => e.Id == p_election.Id).SingleOrDefault();

            e.Id = p_election.Id;
            e.DateElection = p_election.DateElection;
            e.CodeGeographique = p_election.CodeGeographique;

            m_dbContext.Update(e);
            m_dbContext.SaveChanges();
        }
    }
}
