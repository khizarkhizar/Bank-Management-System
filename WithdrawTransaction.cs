using System;
using System.IO;

public class withdrawTransaction
{

    private Account _account;
    private decimal _amount;
    private bool _executed = false;
    private bool _success = false;
    //TODO: add reversed
    public bool Success
    {
        get
        {
            return _success;
        }
    }
    public Account Acc
    {
        get
        {
            return _account;
        }
    }

    //  Need reversed and executed property
    public withdrawTransaction(Account account, decimal amount)
    {
        _account = account;
        _amount = amount;
    }
    public void Execute()
    {
        if (_executed)
        {
            throw new Exception("Cannot execute this transaction as it has already been executed.");
        }
        _executed = true;
        _success = _account.Withdraw(_amount);
    }
    public void Rollback()
    {
        //TODO: Throw an exception if the transaction has not been executed
        //TODO: Throw an exception if the transaction has been reversed
        //TODO: Remember that we have reversed
        //TODO: Then rollback by reversing actions from execute
    }
    public void Print()
    {
        Console.WriteLine("Hi: " + _account.Name + " Your account balance is: $" + _account.Balance);
    }
}
