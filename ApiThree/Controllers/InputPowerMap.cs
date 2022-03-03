
using ApiThree.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiThree.Maps
{
     public class InputPowerMap
    {
        public InputPowerMap(EntityTypeBuilder<Link> entityBuilder)
        {
            entityBuilder.ToTable("trans_mw_erc_pm_tn_radio_link_power");
            entityBuilder.HasKey(p => new { p.NETWORK_SID });
            entityBuilder.Property(f => f.NETWORK_SID).ValueGeneratedOnAdd().HasColumnName("network_sid");
            entityBuilder.Property(x => x.NeId).HasColumnName("neid");
            entityBuilder.Property(x => x.NodeName).HasColumnName("nodename");
            entityBuilder.Property(x => x.Object).HasColumnName("object");
            entityBuilder.Property(x => x.Time).HasColumnName("time");
            entityBuilder.Property(x => x.Interval).HasColumnName("interval");
            entityBuilder.Property(x => x.Direction).HasColumnName("direction");
            entityBuilder.Property(x => x.NeAlias).HasColumnName("nealias");
            entityBuilder.Property(x => x.NeType).HasColumnName("netype");
            entityBuilder.Property(x => x.Position).HasColumnName("position");
            entityBuilder.Property(x => x.RFInputPower).HasColumnName("rfinputpower");
            entityBuilder.Property(x => x.MeanRxLevel1m).HasColumnName("meanrxlevel1m");
            entityBuilder.Property(x => x.TID).HasColumnName("tid");
            entityBuilder.Property(x => x.FarEndTID).HasColumnName("farendtid");
            entityBuilder.Property(x => x.IdLogNum).HasColumnName("idlognum");
            entityBuilder.Property(x => x.FailureDescription).HasColumnName("failuredescription");
        }
    }
}