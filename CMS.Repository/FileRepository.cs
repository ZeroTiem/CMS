﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Repository
{
    public class FileRepository
    {
        private CMSEntities _cmsEntities;

        public FileRepository()
        {
            _cmsEntities = new CMSEntities(); 
        }

        public bool Add(File file)
        {
            try
            {
                var datetimeTW = DateTime.UtcNow.AddHours(8);
                file.CreateDateTime = datetimeTW;
                file.ModifyDateTime = datetimeTW;

                _cmsEntities.File.Add(file);
                _cmsEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool Update(File file)
        {
            try
            {

                var update = _cmsEntities.File.Find(file.FileID);
                update.FileUrl = file.FileUrl;
                _cmsEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteByID(int ID)
        {
            try
            {
                var delete = _cmsEntities.File.Find(ID);
                if (delete != null)
                {
                    _cmsEntities.File.Remove(delete);
                    _cmsEntities.SaveChanges();
                    
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public IEnumerable<File> SearchByCategory(string Category)
        {
            try
            {
                var files = _cmsEntities.File.Where(x => x.Category==Category);
                return files;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
