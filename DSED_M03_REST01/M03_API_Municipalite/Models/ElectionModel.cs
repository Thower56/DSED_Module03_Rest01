using M03_Svr_Municipalite;

namespace M03_API_Municipalite.Models
{
    public class ElectionModel
    {
        public int Id { get; set; }
        public int CodeGeographique { get; set; }
        public DateTime DateElection { get; set; }


        public ElectionModel(Election p_election)
        {
            Id = p_election.Id;
            CodeGeographique = p_election.CodeGeographique;
            DateElection = p_election.DateElection;

        }

        public ElectionModel()
        {
        }

        public Election VersEntite()
        {
            return new Election(Id, CodeGeographique, DateElection);
        }
    }
}
