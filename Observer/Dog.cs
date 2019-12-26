using System;
using System.Collections;

namespace Observer
{
    internal class Dog
    {
        public IList Observers { get; } = new ArrayList();
        public object ObjectFound { get; set; }

        public void Attach(object observer)
        {
            Observers.Add(observer);
        }

        private void Found(object found) {
            ObjectFound = found;

            foreach(var obj in Observers)
            {
                if(obj is ChewingObserver) {
                    var observer = (ChewingObserver)obj;
                    var response = observer.OnChewing(obj);
                    Console.WriteLine($"Response: {response}");
                }
            }
        }

        public void Run()
        {
            if(DateTime.Now.Millisecond%3 == 0)
            {
                Found(new Sprinkler());
            }
            else {
                Found(new Bone());
            }
        }
    }
}