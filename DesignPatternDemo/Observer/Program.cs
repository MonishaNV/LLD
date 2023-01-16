using System;
using System.Collections;
using System.Collections.Generic;

namespace Observer
{
    interface IObserver
    {
        public void Notify(string message);
    }
    class User : IObserver
    {
        public string UserName { get; }
        public User(string name)
        {
            UserName = name;
        }
        public void Notify(string message)
        {
            Console.WriteLine($"{this.UserName} received notification with message {message}");
        }
    }

    class Subject
    {
        IList users = new List<User>();
        public void Subscribe(User user)
        {
            users.Add(user);
            Console.WriteLine($"user {user.UserName} is susbcribed");
        }
        public void Unsubscribe(User user)
        {
            users.Remove(user);
            Console.WriteLine($"user {user.UserName} is unsusbcribed");
        }
        public int NumberOfSubscribers()
        {
            return users.Count;
        }
        public void Notify()
        {
            foreach (User u in users)
            {
                u.Notify("notified");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Monisha");
            User user2 = new User("Thunga");
            User user3 = new User("Priya");

            Subject subject = new Subject();
            subject.Subscribe(user1);
            subject.Subscribe(user2);
            subject.Subscribe(user3);

            Console.WriteLine($"number of subscribers = {subject.NumberOfSubscribers()}");
            subject.Notify();

            subject.Unsubscribe(user1);

            Console.WriteLine($"number of subscribers = {subject.NumberOfSubscribers()}");
            subject.Notify();

        }
    }
}
