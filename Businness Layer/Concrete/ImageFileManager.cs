using Businness_Layer.Abstract;
using Data_Access_Layer.Abstract;
using Entitiy_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _imagefiledal;

        public ImageFileManager(IImageFileDal imagefiledal)
        {
            _imagefiledal = imagefiledal;
        }
        public List<ImageFile> GetList()
        {
            return _imagefiledal.List();
        }
    }
}
