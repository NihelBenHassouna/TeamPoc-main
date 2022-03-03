using FileHelpers;
using Microsoft.OData.Edm;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFour.Models
{

    [DelimitedRecord(",")]
    public class Agg
    {
        [FieldHidden]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int NETWORK_SID { get; set; }
        public string RSL_DEVIATION { get; set; }

        public string  checkpoint { get; set; }


    }

}