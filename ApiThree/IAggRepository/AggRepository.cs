using ApiThree.Contexts;
using ApiThree.Models;
using FileHelpers;
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ApiThree
{
    public class AggRepository : IAggRepository
    {
        public object getAllAgg(AggDbContext context)
        {
            return context.Todos.Select(c => new
            {
                NETWORK_SID = c.NETWORK_SID,
                RSL_DEVIATION = c.RSL_DEVIATION,
                checkpoint = c.checkpoint
            }).ToList();
        }

        public object getAgg_Between_Date1_U_Date2(AggDbContext context, DateTime date1, DateTime date2)
        {

            //not working  02/27/2022
            return context.Todos.Select(c => new
            {
                NETWORK_SID = c.NETWORK_SID,
                checkpoint = c.checkpoint,
            }).ToList().Where(b => DateTime.ParseExact(b.checkpoint, "yyyy/MM/dd", null) < DateTime.ParseExact(date1.ToShortDateString(), "yyyy/MM/dd", null))
                                .Where(b => DateTime.ParseExact(b.checkpoint, "yyyy/MM/dd", null) < DateTime.ParseExact(date1.ToShortDateString(), "yyyy/MM/dd", null));
                                
        }
        public void AddAgg(AggDbContext context, Agg aGG_SLOT_HOURLY)
        {
            context.Add(aGG_SLOT_HOURLY);
            context.SaveChanges();
        }

       public  Agg update(AggDbContext context, InputDbContext _contextInput, RadioDbContext _contextRadio)
        {
            var showPiece = _contextInput.Todos.Select(c => new
            {
                NETWORK_SID = c.NETWORK_SID,
                MeanRxLevel1m = c.MeanRxLevel1m,
             }).ToList().LastOrDefault();
            // .OrderByDescending(p => p.Date)

  var showPiece2 = _contextRadio.Todos.Select(c => new
            {
                NETWORK_SID = c.NETWORK_SID,
                MaxRxLevel = c.MaxRxLevel,
            }).ToList().LastOrDefault();
            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine("---------------------"+ showPiece2.MaxRxLevel + "----------------------------");
            Console.WriteLine("---------------------+"+ showPiece.MeanRxLevel1m + "+----------------------------");
            Console.WriteLine("----------------------------------------------------------------------");

            // .OrderByDescending(p => p.Date)

            Agg Y = new Agg( );
            Y.RSL_DEVIATION =  (float.Parse(showPiece.MeanRxLevel1m)- float.Parse(showPiece2.MaxRxLevel)).toString();
            Y.checkpoint =  DateTime.Now.ToShortDateString();
            context.Add(Y);
            context.SaveChanges();
            return Y;
          //  var resOne = context.Todos.Where(x=> x.checkpoint == date).FirstOrDefault();
            //var resList = context.Todos.Where(x=> x.checkpoint == date);

        }
    }


}