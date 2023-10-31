using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class FetchItemCommand
    {
        public ICommand FetchMethod { get; set; }
        

        public void Selected()
        {
            if (FetchMethod != null)
            {
                FetchMethod.Execute();
            }
        }
    }
}
