using ApiOne.Models;
using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ApiOne
{
    public class InputRepository : IInputRepository
    {
   
        public void generateFileInput( Ftp Ftp)
        {
 
            try
            {

                WebClient request = new WebClient();
                string url = "ftp://" + Ftp.remoteHost + Ftp.remotePath + Ftp.remoteFilename;
                Console.WriteLine("-------------url=  " + url + "----------------------------");
                request.Credentials = new NetworkCredential(Ftp.remoteUser, Ftp.remotePassword);
                Console.WriteLine("-------------------------------------------------");
 
                byte[] data = request.DownloadData(url);
 

                List<Link> list = new List<Link>();
                var engine = new FileHelperEngine<Link>();

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
                    Console.WriteLine(record.TID);
                    Console.WriteLine(record.MeanRxLevel1m);
                }

              /*   _context.Todos.AddRange(list);

                _context.SaveChanges();*/
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
 

     

       
        }
}