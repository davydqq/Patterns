using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregationPrinciple
{
    class Good
    {
        interface ICall
        {
            void Call();
        }
        interface IPhoto
        {
            void TakePhoto();
        }
        interface IVideo
        {
            void MakeVideo();
        }
        interface IWeb
        {
            void BrowseInternet();
        }

        class Camera : IPhoto
        {
            public void TakePhoto()
            {
                Console.WriteLine("TakePhoto");
            }
        }

        class Phone : ICall, IPhoto, IVideo, IWeb
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
