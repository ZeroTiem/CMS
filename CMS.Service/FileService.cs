using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Repository;
using CMS.Info;
using AutoMapper;

namespace CMS.Service
{
    public class FileService
    {
        private FileRepository _fileRepository;

        public FileService()
        {
            _fileRepository = new FileRepository();
        }

        public bool Add(Info.FileInfo infoFile)
        {

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Info.FileInfo, Repository.File>();
            });
            var file = Mapper.Map<Repository.File>(infoFile);
            return _fileRepository.Add(file);
        }
    }
}
