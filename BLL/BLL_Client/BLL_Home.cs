﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF_Mapper;
using DAL.DAL_Client;
using DAL.EF;
using Model;
using Model.DTO.DTO_Client;

namespace BLL.BLL_Client
{
    public class BLL_Home
    {
        DAL_Home customDal = new DAL_Home();
        #region Insert, Update, Delete
        public List<DTO_Users_Acc> GetAllCustomers()
        {
            EntityMapper<Users_Acc, DTO_Users_Acc> mapObj = new EntityMapper<Users_Acc, DTO_Users_Acc>();
            List<Users_Acc> customList = customDal.GetAllCustomers();
            List<DTO_Users_Acc> customers = new List<DTO_Users_Acc>();
            foreach (var item in customList)
            {
                customers.Add(mapObj.Translate(item));
            }
            return (List<DTO_Users_Acc>)customers;
        }
        public bool InsertCustomer(DTO_Users_Acc cusInsert)
        {
            EntityMapper<DTO_Users_Acc, Users_Acc> mapObj = new EntityMapper<DTO_Users_Acc, Users_Acc>();
            Users_Acc customObj = mapObj.Translate(cusInsert);
            return customDal.InsertCustomer(customObj);
        }
        public long InsertForFacebook(DTO_Users_Acc cusInsert)
        {
            EntityMapper<DTO_Users_Acc, Users_Acc> mapObj = new EntityMapper<DTO_Users_Acc, Users_Acc>();
            Users_Acc customObj = mapObj.Translate(cusInsert);
            return customDal.InsertForFacebook(customObj);
        }
        public long InsertForGoogle(DTO_Users_Acc cusInsert)
        {
            EntityMapper<DTO_Users_Acc, Users_Acc> mapObj = new EntityMapper<DTO_Users_Acc, Users_Acc>();
            Users_Acc customObj = mapObj.Translate(cusInsert);
            return customDal.InsertForGoogle(customObj);
        }
        public bool UpdateCustomer(DTO_Users_Acc cusUpdate)
        {
            EntityMapper<DTO_Users_Acc, Users_Acc> mapObj = new EntityMapper<DTO_Users_Acc, Users_Acc>();
            Users_Acc customObj = mapObj.Translate(cusUpdate);
            return customDal.UpdateCustomer(customObj);
        }
        public bool DeleteCustomer(int id)
        {
            return customDal.DeleteCustomer(id);
        }
        #endregion

        #region Get by information
        public DTO_Users_Acc GetCustomerByID(int id)
        {
            EntityMapper<Users_Acc, DTO_Users_Acc> mapObj = new EntityMapper<Users_Acc, DTO_Users_Acc>();
            Users_Acc cus = customDal.GetCustomerByID(id);
            DTO_Users_Acc result = mapObj.Translate(cus);
            return result;
        }
        public DTO_Users_Acc GetCustomerByUsername(string user)
        {
            EntityMapper<Users_Acc, DTO_Users_Acc> mapObj = new EntityMapper<Users_Acc, DTO_Users_Acc>();
            Users_Acc custom = customDal.GetCustomerByUsername(user);
            DTO_Users_Acc result = mapObj.Translate(custom);
            return result;
        }
        public DTO_Users_Acc GetCustomerByEmail(string mail)
        {
            EntityMapper<Users_Acc, DTO_Users_Acc> mapObj = new EntityMapper<Users_Acc, DTO_Users_Acc>();
            Users_Acc custom = customDal.GetCustomerByEmail(mail);
            DTO_Users_Acc result = mapObj.Translate(custom);
            return result;
        }
        #endregion
        public DTO_Users_Acc LoginCustomer(string user, string pass)
        {
            EntityMapper<Users_Acc, DTO_Users_Acc> mapObj = new EntityMapper<Users_Acc, DTO_Users_Acc>();
            Users_Acc custom = customDal.GetLoginResultByUsernamePassword(user,pass);
            DTO_Users_Acc result = mapObj.Translate(custom);
            return result;
        }

    }
}