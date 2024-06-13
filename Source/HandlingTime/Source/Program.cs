#region Copyright

// (c) Developed by Eva, 12 июня 2024 г.

#endregion

#region Using

using SFML.System;
using SFML.Window;
using System;
using System.Threading;

#endregion

namespace HandlingTime
{

  #region Class CProgram

  /// <summary>
  /// CProgram
  /// </summary>
  public class CProgram
  {

    #region Consts

    #endregion

    #region Variables

    #endregion

    #region constructor

    #endregion

    #region Properties

    #endregion

    #region Public methods

    /// <summary>
    /// Entrypoint
    /// </summary>
    /// <example>https://www.sfml-dev.org/tutorials/2.6/system-time.php</example>
    /// <param name="sArgsArray">App params</param>
    public static void Main(string[] sArgsArray)
    {
      #region Converting time

      {
        // sf::Time t1 = sf::microseconds(10000);
        // sf::Time t2 = sf::milliseconds(10);
        // sf::Time t3 = sf::seconds(0.01f);

        Time t1 = Time.FromMicroseconds(10000);
        Time t2 = Time.FromMilliseconds(10);
        Time t3 = Time.FromSeconds(0.01f);

        // sf::Int64 usec = time.asMicroseconds();
        // sf::Int32 msec = time.asMilliseconds();
        // float sec = time.asSeconds();

        long tt1 = t1.AsMicroseconds();
        int tt2 = t2.AsMilliseconds();
        float tt3 = t3.AsSeconds();
      }

      #endregion

      #region Playing with time values

      {
        // sf::Time t1 = ...;
        // sf::Time t2 = t1 * 2;
        // sf::Time t3 = t1 + t2;
        // sf::Time t4 = -t3;

        Time t1 = Time.FromSeconds(10);
        Time t2 = t1 * 2;
        Time t3 = t1 + t2;
        Time t4 = Time.Zero - t3;

        bool b1 = (t1 == t2);
        bool b2 = (t3 > t4);
      }

      #endregion

      #region Measuring time

      {
        // sf::Clock clock; // starts the clock
        // ...
        // sf::Time elapsed1 = clock.getElapsedTime();
        // std::cout << elapsed1.asSeconds() << std::endl;
        // clock.restart();
        // ...
        // sf::Time elapsed2 = clock.getElapsedTime();
        // std::cout << elapsed2.asSeconds() << std::endl;

        Clock clock = new Clock();

        Time elapsed1 = clock.ElapsedTime;
        Console.WriteLine(elapsed1.AsSeconds());
        clock.Restart();

        Thread.Sleep(1000);

        Time elapsed2 = clock.ElapsedTime;
        Console.WriteLine(elapsed2.AsSeconds());
      }

      {
        // sf::Clock clock;
        // while (window.isOpen())
        // {
        //   sf::Time elapsed = clock.restart();
        //   updateGame(elapsed);
        //   ...
        // }

        Clock clock = new Clock();
        Window pAppWindow = new Window(new VideoMode(640, 480), "AppWindow");

        while (pAppWindow.IsOpen) {
          Time elapsed = clock.Restart();
          UpdateGame(elapsed);
        }

      }

      #endregion
    }

    #endregion

    #region Help methods

    /// <summary>
    /// Обновление состояния
    /// </summary>
    /// <param name="elapsed"></param>
    private static void UpdateGame(Time elapsed)
    {
      // todo something
    }

    #endregion


  }

  #endregion

}