using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using YakinTech.FTP.Models;

namespace YakinTech.FTP.Services
{
   public class FTPProvider
    {
        public static FTPResultFile UploadFile(FtpModel model, HttpPostedFileBase file)
        {
            FTPResultFile result = null;
            try
            {
                string ftpfullpath = model.Server + model.Directory + file.FileName;
                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(ftpfullpath);
                ftp.Credentials = new NetworkCredential(model.Username, model.Password);

                ftp.KeepAlive = true;
                ftp.UseBinary = true;
                ftp.Method = WebRequestMethods.Ftp.UploadFile;

                Stream fs = file.InputStream;
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();

                Stream ftpstream = ftp.GetRequestStream();
                ftpstream.Write(buffer, 0, buffer.Length);
                ftpstream.Close();

                result.IsSuccess = true;
                
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.IsSuccess = false;
            }

            return result;

        }
    }
}
