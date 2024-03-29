﻿using MvcCoreBlogProject.BusinessLayer.Abstract;
using MvcCoreBlogProject.DataAccessLayer.Abstract;
using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About entity)
        {
            _aboutDal.Add(entity);
        }

        public void TDelete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public About TGetByID(int id)
        {
            return _aboutDal.GetByID(id);
        }

        public List<About> TGetListAll()
        {
            return _aboutDal.GetListAll().Take(1).ToList();
        }

        public void TUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
