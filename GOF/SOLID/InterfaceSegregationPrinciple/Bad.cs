using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregationPrinciple
{
    class Bad
    {
        interface IPhone
        {
            void Call();
            void TakePhoto();
            void MakeVideo();
            void BrowseInternet();
        }
        class Phone : IPhone
        {
            public void Call()
            {
                Console.WriteLine("Call");
            }
            public void TakePhoto()
            {
                Console.WriteLine("TakePhoto");
            }
            public void MakeVideo()
            {
                Console.WriteLine("MakeVideo");
            }
            public void BrowseInternet()
            {
                Console.WriteLine("BrowseInternet");
            }
        }
    }
}
