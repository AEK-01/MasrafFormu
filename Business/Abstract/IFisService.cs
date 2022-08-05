using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Business.Abstract
{
    public interface IFisService
    {
        IDataResult<Fis> GetById(int fisId);
        IDataResult<List<Fis>> GetAll();
        IResult Add(Fis Fis);
        IResult Delete(Fis Fis); 
        IResult Update(Fis Fis);

    }
}  
