﻿using System.Collections.Generic;
using System.Linq;
using BankLoan.Models.Contracts;
using BankLoan.Repositories.Contracts;

namespace BankLoan.Repositories;

public class LoanRepository:IRepository<ILoan>
{
    private List<ILoan> models;


    public LoanRepository()
    {
        models = new List<ILoan>();
    }


    public IReadOnlyCollection<ILoan> Models
    {
        get
        {
            return models.AsReadOnly();
        }
    }




    public void AddModel(ILoan model)
    {
        models.Add(model);
    }

    public bool RemoveModel(ILoan model)
    {
       return models.Remove(model);
    }



    public ILoan FirstModel(string name)
    {
        return models.FirstOrDefault(x => x.GetType().Name == name);
    }
}