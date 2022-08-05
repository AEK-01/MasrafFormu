using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMakbuzDal: EfEntityRepositoryBase<Makbuz, MasrafFormContext>, IMakbuzDal
    {
        public List<Makbuz> GetMakbuzlar()
        {
            using (var context = new MasrafFormContext())
            {
                var result = from makbuz in context.Makbuzlar
                             select new Makbuz { Id = makbuz.Id, Company = makbuz.Company, Date = makbuz.Date, Description = makbuz.Description, TotalCost = makbuz.TotalCost, Address=makbuz.Address, NameOfTheAuthor=makbuz.NameOfTheAuthor };
                return result.ToList();
            }
        }
    }
} 
