using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;

        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public void Add(Image image)
        {
            _imageDal.Add(image);
        }

        public void Delete(Image image)
        {
            _imageDal.Delete(image);
        }

        public Image Get(int id)
        {
            return _imageDal.GetById(id);

        }

        public List<Image> GetAll()
        {
            return _imageDal.GetAll();
        }
    }
}
