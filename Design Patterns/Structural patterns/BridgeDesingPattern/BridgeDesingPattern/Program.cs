﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesingPattern
{
   //Interface tanımı yapılır.
    public interface IVideoMode
    {
        string GetScreen();
    }
    // IVideoMode OpenGLMode'dan kalıtılır.
    public class OpenGLMode : IVideoMode
    {
        const string MODE_NAME = "OpenGL Mode";
        public string GetScreen()
        {
            return string.Format("Video started with {0}", MODE_NAME);
        }
    }
    
    /// ConcreteImplementor for Direct3D
    
    public class Direct3DMode : IVideoMode
    {
        const string MODE_NAME = "Direct3D Mode";
        public string GetScreen()
        {
            return string.Format("Video started with {0}", MODE_NAME);
        }
    }

    
    /// The 'Abstraction' class
    
    public class VideoAbstraction
    {
        protected IVideoMode _videoMode;
        // Property
        public IVideoMode VideoMode
        {
            set { _videoMode = value; }
        }

        public virtual void ShowScreen()
        {
            Console.WriteLine(_videoMode.GetScreen());
        }

    }
    // VideoAbstraction VideoRefinedAbstraction'dan kalıtıldı
    public class VideoRefinedAbstraction : VideoAbstraction
    {
        public override void ShowScreen()
        {
            Console.WriteLine(_videoMode.GetScreen());
        }

    }
    // VideoAbstraction'dan video oluşturuldu.
    class Program
    {
        static void Main(string[] args)
        {
            VideoAbstraction video = new VideoRefinedAbstraction();
            video.VideoMode = new OpenGLMode();
            video.ShowScreen();

            Console.ReadLine();
        }
    }
}
