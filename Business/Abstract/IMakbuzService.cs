using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMakbuzService
    {
        IDataResult<Makbuz> GetById(int makbuzId);
        IDataResult<List<Makbuz>> GetAll();
        IResult Add(Makbuz product);
        IResult Delete(Makbuz product);
        IResult Update(Makbuz product); 

    }
}
