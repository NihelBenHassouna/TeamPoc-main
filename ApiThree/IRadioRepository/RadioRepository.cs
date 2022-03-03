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
    public class RadioRepository : IRadioRepository
    {


        public object getByIdRadio(RadioDbContext _context, string id)
        {
            return _context.Todos.Where(b => b.NeId == id).Select((c) => new
            {
                NeId = c.NeId,
                NodeName = c.NodeName,
                Object = c.Object,
                Time = c.Time,
                Interval = c.Interval,
                Direction = c.Direction,
                NeAlias = c.NeAlias,
                NeType = c.NeType,
                Position = c.Position,
                RxLevelBelowTS1 = c.RxLevelBelowTS1,
                RxLevelBelowTS2 = c.RxLevelBelowTS2,
                MinRxLevel = c.MinRxLevel,
                MaxRxLevel = c.MaxRxLevel,
                TxLevelAboveTS1 = c.TxLevelAboveTS1,
                MinTxLevel = c.MinTxLevel,
                MaxTxLevel = c.MaxTxLevel,
                IdLogNum = c.IdLogNum,
                FailureDescription = c.FailureDescription
            }).ToList();

        }


        public void getFiles(RadioDbContext _context, Ftp Ftp)
        {
            Console.WriteLine("---------------------111----------------------------");



            Console.WriteLine("---------------------22----------------------------");

            try
            {

                WebClient request = new WebClient();
                string url = "ftp://" + Ftp.remoteHost + Ftp.remotePath + Ftp.remoteFilename;
                Console.WriteLine("-------------url=  " + url + "----------------------------");
                request.Credentials = new NetworkCredential(Ftp.remoteUser, Ftp.remotePassword);
                Console.WriteLine("-------------------------------------------------");
                /*byte[] newFileData = request.DownloadData(url);
                string fileString = System.Text.Encoding.UTF8.GetString(newFileData);
                Console.WriteLine("--------------" + fileString);
                */

                //var engine = new DelimitedFileEngine(typeof(Radio));
                byte[] data = request.DownloadData(url);
                /* var encoding = new System.Text.ASCIIEncoding();
                 string dataString = encoding.GetString(data);*/
                //  var Radios = (Radio[])engine.ReadString(dataString);


                List<Input> list = new List<Input>();
                var engine = new FileHelperEngine<Input>();

                var encoding = new ASCIIEncoding();
                string dataString = encoding.GetString(data);
                var records = engine.ReadString(dataString);
                foreach (var record in records)
                {
                    list.Add(record);
                    Console.WriteLine(record.NodeName);
                    Console.WriteLine(record.Direction);
                    Console.WriteLine(record.FailureDescription);
                    Console.WriteLine(record.IdLogNum);
                    Console.WriteLine(record.Interval);
                    Console.WriteLine(record.NeId);
                    Console.WriteLine(record.Object);
                    Console.WriteLine(record.Position);
                    Console.WriteLine(record.RxLevelBelowTS2);
                    Console.WriteLine(record.TxLevelAboveTS1);
                }

                Console.WriteLine("------------------------------------------------");
                _context.Todos.AddRange(list);

                _context.SaveChanges();
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine(e.ToString());
            }

            catch (WebException e)
            {
                Console.WriteLine(e.ToString());

            }
        }

        public void PostFiles(RadioDbContext context, Input radio)
        {
            context.Add(radio);
            context.SaveChanges();
        }

        object IRadioRepository.getRadio(RadioDbContext context)
        {
            return context.Todos.Select(c => new
            {
                NeId = c.NeId,
                NodeName = c.NodeName,
                Object = c.Object,
                Time = c.Time,
                Interval = c.Interval,
                Direction = c.Direction,
                NeAlias = c.NeAlias,
                NeType = c.NeType,
                Position = c.Position,
                RxLevelBelowTS1 = c.RxLevelBelowTS1,
                RxLevelBelowTS2 = c.RxLevelBelowTS2,
                MinRxLevel = c.MinRxLevel,
                MaxRxLevel = c.MaxRxLevel,
                TxLevelAboveTS1 = c.TxLevelAboveTS1,
                MinTxLevel = c.MinTxLevel,
                MaxTxLevel = c.MaxTxLevel,
                IdLogNum = c.IdLogNum,
                FailureDescription = c.FailureDescription


            }).ToList();
        }
    }
}