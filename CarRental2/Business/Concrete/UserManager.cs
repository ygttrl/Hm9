﻿using Business.Abstruct;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstruct;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserServis
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user==null)
            {
                return new ErrorResult(Message.UserErrorMassage);
            }
            _userDal.Add(user);
            return new SuccessResult(Message.UserSuccessMassage);
        }

        public IResult Delete(User user)
        {
            if (user==null)
            {
                return new ErrorResult(Message.UserErrorDeleteMassage);
            }
            _userDal.Delete(user);
            return new SuccessResult(Message.UserSuccessDeleteMassage);
        }

        public IResult Update(User user)
        {
            if (user==null)
            {
                return new ErrorResult("Kullanıcı Update başarısız.");
            }
            return new SuccessResult("Kullanıcı Update başarılı.");
        }

        public IDataResult<List<User>> GetAll()
        {
            List<User> users = _userDal.GetAll();
            if (users==null)
            {
                return new ErrorDataResult<List<User>>(Message.UserErrorListMassage);
            }
            return new SuccessDataResult<List<User>>(users, Message.UserSuccessListMassage);
        }

        public IDataResult<List<User>> GetAll(int id)
        {
            var users = _userDal.GetAll(x => x.Id==id);

            if (users==null)
            {
                return new ErrorDataResult<List<User>>(Message.UserErrorListMassage);
            }
            return new SuccessDataResult<List<User>>(users,Message.UserSuccessListMassage);
        }

        public IDataResult<User> GetById(int id)
        {
            if (id<=0)
            {
                return new ErrorDataResult<User>(Message.UserErrorGetMassage);
            }
            return new SuccessDataResult<User>(_userDal.Get(x => x.Id == id), Message.UserSuccessGetMassage);
        }

        
    }
}
