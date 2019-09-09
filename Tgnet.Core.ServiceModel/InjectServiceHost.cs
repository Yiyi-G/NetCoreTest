using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.ServiceModel
{
    //public class InjectServiceHost : ServiceHost
    //{
    //    private IInjectInstanceProvider m_InjectInstanceProvider;

    //    public InjectServiceHost(IInjectInstanceProvider injectInstanceProvider, Type serviceType, params Uri[] baseAddresses)
    //        : base(serviceType, baseAddresses)
    //    {
    //        m_InjectInstanceProvider = injectInstanceProvider;
    //    }

    //    protected override void OnOpening()
    //    {
    //        base.OnOpening();
    //        if (this.Description.Behaviors.Find<InjectServiceBehavior>() == null)
    //        {
    //            this.Description.Behaviors.Add(new InjectServiceBehavior(m_InjectInstanceProvider));
    //        }
    //    }
    //}
}
