using System;

public class PhoneCall
{
    public delegate void Notify();

    public event Notify PhoneCallEvent;

    public string Message { get; private set; }


    private void OnSubscribe()
    {
        Message = "Subscribed to Call";
    }

    private void OnUnSubscribe()
    {
        Message = "UnSubscribe to Call";
    }

    public void MakeAPhoneCall(bool notify)
    {
        if (notify)
        {
            PhoneCallEvent+=OnSubscribe;
        }
        else
        {
            PhoneCallEvent+=OnUnSubscribe;
        }

        PhoneCallEvent?.Invoke();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        PhoneCall phoneCall = new PhoneCall();

        bool notify1 = true;
        bool notify2 = false;

        phoneCall.MakeAPhoneCall(notify1);
        Console.WriteLine(phoneCall.Message);
        phoneCall.MakeAPhoneCall(notify2);
        Console.WriteLine(phoneCall.Message);
    }
}