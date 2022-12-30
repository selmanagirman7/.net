using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IImageService
    {
        void Add(Image image);
        List<Image> GetAll();
        void Delete(Image image);
        Image Get(int id);
    }
}
