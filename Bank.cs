using System;
using System.Collections.Generic;

public class Bank
{


    List<Account> _accounts = new List<Account>();


    public void AddAccount(Account account)
    {
        _accounts.Add(account);

    }
    public Account GetAccount(string name)
    {
        foreach (Account acc in _accounts)
        {

            if (acc.Name.Equals(name))
            {

                return acc;
            }
        }
        return null;
    }

    public void ExecuateTransaction(withdrawTransaction WD)
    {


        WD.Execute();



        WD.Print();
    }
    public void ExecuateTransaction(DepsiteTransaction DT)
    {

    }
    // public void ExecuateTransaction(TransTransaction TT)
    // {

    // }



}