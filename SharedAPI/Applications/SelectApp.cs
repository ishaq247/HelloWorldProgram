using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedAPI
{
    public class SelectApp
    {
        public IWriteMessage obj = null;
        
        public SelectApp(IWriteMessage message)
        {
            this.obj = message;
        }

        public void WriteMessage(string text)
        {
            obj.WriteText(text);
        }
    }
}
