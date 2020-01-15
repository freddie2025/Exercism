using System;

public class BankAccount
{
    public void Open()
    {
        _open = true;
    }

    public void Close()
    {
        _open = false;
    }

    private readonly object _balanceLock = new object();
    private decimal _balance;
    private bool _open;

    public decimal Balance
    {
        get
        {
            return _open ? _balance : throw new InvalidOperationException("The account is closed.");
        }
    }

    public void UpdateBalance(decimal change)
    {
        lock(_balanceLock)
        {
            _balance += change;
        }
    }
}
