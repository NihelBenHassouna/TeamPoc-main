using ApiFour.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiFour.Maps
{
    public class AggMap
    {
        public AggMap(EntityTypeBuilder<Agg> entityBuilder)
        {
            entityBuilder.ToTable("trans_mw_agg_slot_hourly");
            entityBuilder.HasKey(p => new { p.NETWORK_SID });
            entityBuilder.Property(f => f.NETWORK_SID).ValueGeneratedOnAdd().HasColumnName("network_sid");
            entityBuilder.Property(x => x.RSL_DEVIATION).HasColumnName("rsl_deviation");
            entityBuilder.Property(x => x.checkpoint).HasColumnName("checkpoint");
         }
    }
}