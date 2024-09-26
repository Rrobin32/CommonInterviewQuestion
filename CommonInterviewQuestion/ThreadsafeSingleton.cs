using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    internal class ThreadsafeSingleton
    {
        private ThreadsafeSingleton() { }

        private static ThreadsafeSingleton threadsafeSingleton;

        private static readonly Object lockInstance = new Object();

        public static ThreadsafeSingleton Instance
        {
            get
            {
                if(threadsafeSingleton == null)
                {
                    lock (lockInstance)
                    {
                        if(threadsafeSingleton == null)
                        {
                            threadsafeSingleton = new ThreadsafeSingleton();
                        }
                    }
                }

                return threadsafeSingleton;
            }
        }
    }
}
