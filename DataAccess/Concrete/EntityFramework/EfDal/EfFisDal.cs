using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFisDal : EfEntityRepositoryBase<Fis, MasrafFormContext>, IFisDal
    {
        public List<Fis> GetFisler()
        {
            using (var context = new MasrafFormContext())
            {
                var result = from fis in context.Fisler
                             select new Fis { Id = fis.Id, Company=fis.Company, Date=fis.Date, Description=fis.Description, FisType=fis.FisType, TotalCost=fis.TotalCost, VatValue=fis.VatValue };
                return result.ToList();
            }
        }
    } 
}
