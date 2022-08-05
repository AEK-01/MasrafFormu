using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MakbuzManager : IMakbuzService
    {
        private IMakbuzDal makbuzDal;

        public MakbuzManager(IMakbuzDal makbuzDal)
        {
            this.makbuzDal = makbuzDal;
        }


        public IResult Add(Makbuz makbuz) 
        {
            makbuzDal.Add(makbuz);
            return new SuccessResult(Messages.MakbuzAdded);
        }

        public IResult Delete(Makbuz makbuz)
        {
            makbuzDal.Delete(makbuz);
            return new SuccessResult(Messages.MakbuzDeleted);
        }

        public IDataResult<Makbuz> GetById(int makbuzId)
        {
            return new SuccessDataResult<Makbuz>(makbuzDal.Get(p => p.Id == makbuzId));
        }
         
        public IDataResult<List<Makbuz>> GetAll()
        {
            return new SuccessDataResult<List<Makbuz>>(makbuzDal.GetAll(), Messages.MakbuzlarListelendi);
        }

        public IResult Update(Makbuz makbuz) 
        {
            makbuzDal.Update(makbuz);
            return new SuccessResult(Messages.MakbuzUpdated);
        }
    }
}
