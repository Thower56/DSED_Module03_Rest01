using M03_Svr_Municipalite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_DAL_Municipalite
{
    public class ElectionDTO
    {
        [Key]
        public int Id { get; set; }
        public int CodeGeographique { get; set; }
        public DateTime DateElection { get; set; }
        public ElectionDTO(Election p_election)
        {
            Id = p_election.Id;
            CodeGeographique = p_election.CodeGeographique;
            DateElection = p_election.DateElection;
            
        }
        public ElectionDTO()
        {
           
        }

        public Election VersEntite()
        {
            return new Election(Id, CodeGeographique, DateElection);
        }

        
    }
}
