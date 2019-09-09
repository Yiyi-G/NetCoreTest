using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.ServiceModel
{
    public class Extension<TValue, T> : System.ServiceModel.IExtension<T>
        where T : System.ServiceModel.IExtensibleObject<T>
    {
        private T Owner { get; set; }

        public TValue Value { get; set; }

        public Extension()
        {
        }

        public Extension(TValue value)
        {
            Value = value;
        }

        public void Attach(T owner)
        {
            Owner = owner;
        }

        public void Detach(T owner)
        {
            Owner = default(T);
        }

        public static implicit operator Extension<TValue, T>(TValue value)
        {
            return new Extension<TValue, T>(value);
        }
    }
}
