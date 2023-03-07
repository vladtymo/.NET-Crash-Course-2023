using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9._1
{
    internal interface IPrintInformation
    {
        public string GetName();
        public void Print(string str);
    }

    internal interface IDisk
    {
        public string GetName();
        string Read();
        void Write(string str);
    }

    public interface IRemovableDisk
    {
        bool HasDisk { get; }
        public string GetName();
        public void Insert();
        public void Reject(); 
    }
}
