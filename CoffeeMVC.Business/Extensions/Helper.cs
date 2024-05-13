using CoffeeMVC.Business.Exceptions;
using CoffeeMVC.Core.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMVC.Business.Extensions
{
    public static class Helper
    {
        public static string ImageSaveContentRoot(string repoPath, string folderName, IFormFile file) 
        {
            if (file.ContentType != "image/png" && file.ContentType != "image/jpeg")
                throw new ImageFileContextException("File formati duzgun deyil!");

            if (file.Length > 2097152)
                throw new ImageSizeException("File olcusu boyukdur!");


            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

            string path = repoPath + folderName + fileName;

            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);    
            }

            return fileName;
        }


    }
}
