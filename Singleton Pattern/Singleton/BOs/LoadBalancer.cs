using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.BOs
{
    public sealed class LoadBalancer
    {
        // Lock synchronization object
        private static readonly LoadBalancer instance = new LoadBalancer();
        // Note: constructor is 'private'
        private LoadBalancer()
        {
        }
        public static LoadBalancer GetLoadBalancer()
        {
            return instance;
        }

    }
}
