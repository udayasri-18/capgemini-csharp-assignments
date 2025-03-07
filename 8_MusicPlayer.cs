using PracticeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Interface Implementation Challenge**
//Define an interface `IPlayable` with a method `Play()`.
//Implement this interface in `MusicPlayer` and `VideoPlayer` classes with different implementations.


namespace PracticeApp
{
    interface IPlayable
    {
        public void Play()
        {

        }

    }
    class MusicPlayer:IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Music is Playing");
        }
    }

    class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Video is Playing");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            MusicPlayer m = new MusicPlayer();
            m.Play();

            VideoPlayer v = new VideoPlayer();
            v.Play();
        }
    }
}
