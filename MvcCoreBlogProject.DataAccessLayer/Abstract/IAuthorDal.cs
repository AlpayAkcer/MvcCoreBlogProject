﻿using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.DataAccessLayer.Abstract
{
    public interface IAuthorDal : IGenericDal<Author>
    {
        int GetAuthorByBlogCount(int id);
    }
}
