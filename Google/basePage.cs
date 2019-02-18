using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteKitTest
{
   public class BasePage
    {
        public T As<T>() where T : BasePage
        {
            return (T)this;
        }
    }
}
