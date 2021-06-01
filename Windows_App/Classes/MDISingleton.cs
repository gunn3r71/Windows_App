using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_App.Classes
{
    public class MDISingleton
    {
        private MDISingleton()
        {
        }

        private static frmContainer instanceMDI;

        public static frmContainer GetMDI()
        {
            if (instanceMDI == null)
            {
                instanceMDI = new frmContainer();
                return instanceMDI;
            }
            return instanceMDI;
        }
    }
}
