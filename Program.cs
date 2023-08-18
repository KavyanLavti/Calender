using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace phybox
{
    class program
    {
        static public void Main()
        {
             using(Game game = new Game(800, 600, "learnOpenTK"))
             {
                game.Run();
             }
        }
       
        
    }
}
