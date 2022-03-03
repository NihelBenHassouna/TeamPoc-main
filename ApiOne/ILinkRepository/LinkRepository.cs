using ApiOne.Models;
using FileHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace ApiOne
{
    public class LinkRepository : ILinkRepository
    {

 
        public void generateFileLink( Ftp Ftp)
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
          
                byte[] data = request.DownloadData(url);
      

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
                url = "ftp://" + Ftp.remoteHost + Ftp.remotePath+"one.csv" ;
                CreateFile(list, url, Ftp.remoteUser, Ftp.remotePassword);      
             
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


   
        private void CreateFile(List<Input> reportData, string ftpUrl, string userName, string password)
        {

            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl);
            request.Method = WebRequestMethods.Ftp.UploadFile;

            request.Credentials = new NetworkCredential(userName, password);


            var lines = new List<string>();
            IEnumerable<PropertyDescriptor> props = TypeDescriptor.GetProperties(typeof(Input)).OfType<PropertyDescriptor>();
            var header = string.Join(",", props.ToList().Select(x => x.Name));
            lines.Add(header);
            var valueLines = reportData.Select(row => string.Join(",", header.Split(',').Select(a => row.GetType().GetProperty(a).GetValue(row, null))));
            lines.AddRange(valueLines);
            byte[] data = lines.SelectMany(s => Encoding.UTF8.GetBytes(s + Environment.NewLine)).ToArray();

     

            using (Stream requestStream = request.GetRequestStream())
            {
                 requestStream.Write(data, 0, data.ToArray().Length);
 
            }

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                Console.WriteLine($"Upload File Complete, status {response.StatusDescription}");
            }

        }
    }
}