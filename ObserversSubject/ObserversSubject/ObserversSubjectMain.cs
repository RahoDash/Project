/**
 * Author       : SILKA Besmir
 * Date         : 14.11.2017
 * Program      : Observers/Subject
 * Descripion   : Console exercie for practicing Observers/subject mecanism.
 *                (manual method without Interface nor event handler)
 **/

namespace ObserversSubject
{
    class ObserversSubjectMain
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            Observer observer1 = new Observer(1);
            System.Console.WriteLine("Subscribe Observer 1.");
            subject.RegisterObserver(observer1);

            Observer observer2 = new Observer(2);
            System.Console.WriteLine("Subscribe Observer 2.");
            subject.RegisterObserver(observer2);

            Observer observer3 = new Observer(3);
            System.Console.WriteLine("Subscribe Observer 3.");
            subject.RegisterObserver(observer3);

            System.Console.WriteLine("\nChange the rate field of the subject.");
            subject.Rate += .5;

            System.Console.WriteLine("\nUnsubscribe observer1.");
            System.Console.WriteLine("\nChange the field of the subject.");
            subject.UnregisterObserver(observer1);

            subject.Rate += .5;
        }
    }
}
