using ApiFour.Contexts;
using ApiFour.Models;
using System;

namespace ApiFour
{
    public interface IAggRepository
    {

        object getAgg_Between_Date1_U_Date2(AggDbContext context, DateTime date1, DateTime date2);

        object getAgg(AggDbContext context);
        void AddAgg(AggDbContext context, Agg aGG_SLOT_HOURLY);
    }
}
