﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void BlogAdd(Blog category)
        {
            throw new NotImplementedException();
        }

        public void BlogDelete(Blog category)
        {
            throw new NotImplementedException();
        }

        public void BlogUpdate(Blog category)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAllBlogs()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }
    }
}
