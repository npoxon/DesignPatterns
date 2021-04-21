using DesignPatterns.Structural.Helpers;

namespace DesignPatterns.Structural.Proxy
{
    // The RealSubject contains some core business logic. Usually, RealSubjects
    // are capable of doing some useful work which may also be very slow or
    // sensitive - e.g. correcting input data. A Proxy can solve these issues
    // without any changes to the RealSubject's code.
    public class RealSubject : ISubject
    {
        public string Request()
        {
            return StructuralText.SubjectHandlingRequest;
        }
    }
}