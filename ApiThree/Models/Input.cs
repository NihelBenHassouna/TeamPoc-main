using FileHelpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiThree.Models
{

    [DelimitedRecord(",")]
    public class Input
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



        public string RxLevelBelowTS1 { get; set; }



        public string RxLevelBelowTS2 { get; set; }



        public string MinRxLevel { get; set; }



        public string MaxRxLevel { get; set; }



        public string TxLevelAboveTS1 { get; set; }



        public string MinTxLevel { get; set; }



        public string MaxTxLevel { get; set; }



        public string IdLogNum { get; set; }



        public string FailureDescription { get; set; }

    }

}