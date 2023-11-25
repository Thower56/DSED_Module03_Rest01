using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_DAL_Municipalite
{
    public class ClefAPI
    {
        [Key]
        public Guid ClefAPIId;
        public ClefAPI() { }

        public ClefAPI(Guid p_clef)
        {
            this.ClefAPIId = p_clef;
        }
    }
}
