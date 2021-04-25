using System;
using System.Collections.Generic;


var subject = new subject();
var observer1 = new ObserverType1("Ismail");
var observer2  = new ObserverType2("Ramadan");
var observer3  = new ObserverType2("Mohammad");
subject.Register(observer1);
subject.Register(observer2);
subject.Register(observer3);
subject.Flag = 5;
System.Console.WriteLine("================================");
subject.Unregister(observer3);

subject.Flag=10;


// The IObserver , ISubject
#region interfaces
interface IObserver
{
    void Update(int i);
}

interface ISubject
{
    void Register(IObserver o);
    void Unregister(IObserver o);

    void NotifyRegisteredUsers(int i);

}

#endregion


#region Observers

class ObserverType1 : IObserver
{
    string _nameOfObserver;
    public ObserverType1(string nameOfObserver)
    {
        _nameOfObserver = nameOfObserver;
    }
    public void Update(int i)
    {
        Console.WriteLine($"{_nameOfObserver} has recieved an alert; someOne change my value in subject to {i}");
    }
}


class ObserverType2 : IObserver
{
    string _nameOfObserver;
    public ObserverType2(string nameOfObserver)
    {
        _nameOfObserver = nameOfObserver;
    }
    public void Update(int i)
    {
        Console.WriteLine($"{_nameOfObserver} notified: myValue in subject at present :{i}");
    }
}

#endregion

class subject : ISubject
{
    List<IObserver> Observers = new List<IObserver>();
    private int _flag;

    public int Flag
    {
        get
        {
            return _flag;
        }
        set
        {
            _flag =value;
            NotifyRegisteredUsers(_flag);

        }
    }

    public void NotifyRegisteredUsers(int i)
    {
        foreach (var observer in Observers)
        {
            observer.Update(i);
        }
    }

    public void Register(IObserver o) => Observers.Add(o);
    

    public void Unregister(IObserver o) => Observers.Remove(o);
    
}
