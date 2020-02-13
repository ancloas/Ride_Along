﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;
using CarPoolApplication.Models;

namespace CodeFirst.Services.Interfaces
{
    public interface IBaseService<T> 
    { 
        HttpResponseException Add(T entity);
        HttpResponseException Delete(int iD);
        List<T> GetAll();
        T GetByID(int id);
    }
}
