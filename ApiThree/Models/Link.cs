using FileHelpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiThree.Models
{

    [DelimitedRecord(",")]
    public class Link
    {

 
        [FieldHidden]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int NETWORK_SID { get; set; }
        public string NodeName { get; set; }



        public string NeId { get; set; }



        public string Object { get; set; }



        public string Time { get; set; }



        public string Interval { get; set; }



        public string Direction { get; set; }



        public string NeAlias { get; set; }



        public string NeType { get; set; }



        public string Position { get; set; }



        public string RFInputPower { get; set; }



        public string MeanRxLevel1m { get; set; }



        public string IdLogNum { get; set; }



 


        public string TID { get; set; }



        public string FarEndTID { get; set; }



        public string FailureDescription { get; set; }



        

    }

}