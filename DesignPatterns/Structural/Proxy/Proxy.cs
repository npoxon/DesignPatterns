using System;
using DesignPatterns.Structural.Helpers;

namespace DesignPatterns.Structural.Proxy
{
    // The Proxy has an interface identical to the RealSubject.
    public class Proxy : ISubject
    {
        private readonly RealSubject _realSubject;
        
        public Proxy(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }
        
        // The most common applications of the Proxy pattern are lazy loading,
        // caching, controlling the access, logging, etc. A Proxy can perform
        // one of these things and then, depending on the result, pass the
        // execution to the same method in a linked RealSubject object.
        public string Request()
        {
            if (!CheckAccess()) return null;
            _realSubject.Request();
            LogAccess();
            return StructuralText.ProxyHandlingRequest;
        }

        private static bool CheckAccess()
        {
            // Some real checks should go here.
            return true;
        }
        
        private static void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}