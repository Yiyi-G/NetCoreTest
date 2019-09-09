using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.ServiceModel
{
    public interface IInjectInstanceProvider
    {
        void Register(Type contractType, Type serviceType);
        IInstanceProvider GetInstanceProvider(Type contractType);
    }
}
