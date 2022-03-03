using ApiTwo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTwo.Maps
{
    public class LinkMap
    {
        public LinkMap(EntityTypeBuilder<Input> entityBuilder)
        {
            entityBuilder.ToTable("trans_mw_erc_pm_wan_rfinputpower");
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
            entityBuilder.Property(x => x.RxLevelBelowTS1).HasColumnName("rxlevelbelowts1");
            entityBuilder.Property(x => x.RxLevelBelowTS2).HasColumnName("rxlevelbelowts2");
            entityBuilder.Property(x => x.MinRxLevel).HasColumnName("minrxlevel");
            entityBuilder.Property(x => x.MaxRxLevel).HasColumnName("maxrxlevel");
            entityBuilder.Property(x => x.TxLevelAboveTS1).HasColumnName("txlevelabovets1");
            entityBuilder.Property(x => x.MinTxLevel).HasColumnName("mintxlevel");
            entityBuilder.Property(x => x.MaxTxLevel).HasColumnName("maxtxlevel");
            entityBuilder.Property(x => x.IdLogNum).HasColumnName("idlognum");
            entityBuilder.Property(x => x.FailureDescription).HasColumnName("failuredescription");
        }
    }
}