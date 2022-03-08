using ApiThree.Contexts;
using ApiThree.Models;
using System;


namespace ApiThree
{
    public interface IAggRepository
    {

        Agg update(AggDbContext context, InputDbContext _contextInput, RadioDbContext _contextRadio);
        object getAgg_Between_Date1_U_Date2(AggDbContext context, Dates date1, Dates date2);

        object getAllAgg(AggDbContext context);
        void AddAgg(AggDbContext context, Agg aGG_SLOT_HOURLY);
    }
}
