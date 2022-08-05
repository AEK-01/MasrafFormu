using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class FisManager : IFisService
    {
        private IFisDal fisDal;

        public FisManager(IFisDal fisDal)
        {
            this.fisDal = fisDal;
        }

        public IResult Add(Fis fis)
        {
            fisDal.Add(fis);
            return new SuccessResult(Messages.FisAdded);
        }

        public IResult Delete(Fis fis)
        {
            fisDal.Delete(fis);
            return new SuccessResult(Messages.FisDeleted);
        }

        public IDataResult<Fis> GetById(int fisId)
        {
            return new SuccessDataResult<Fis>(fisDal.Get(p => p.Id== fisId));
        }

        public IDataResult<List<Fis>> GetAll()
        {
            return new SuccessDataResult<List<Fis>>(fisDal.GetAll().ToList());
        } 

        public IResult Update(Fis fis)
        {
            fisDal.Update(fis);
            return new SuccessResult(Messages.FisUpdated);
        }
    }
}
