#region Copyright

// (c) Developed by Eva, 12 июня 2024 г.

#endregion

#region Using

using System;
using System.Diagnostics.Metrics;
using System.Threading;
using System.Threading.Tasks;

#endregion

namespace Threads
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

    private static Mutex mutex;

    #endregion

    #region Public methods

    /// <summary>
    /// Entrypoint
    /// </summary>
    /// <example>https://www.sfml-dev.org/tutorials/2.6/system-thread.php</example>
    /// <param name="sArgsArray">App params</param>
    public static void Main(string[] sArgsArray)
    {
      /*
       * Возможно лучше использовать Task вместо Thread
       * Является надстройкой над Thread и уже обладает большинством функций,
       * что потребуется написать самому, изобретая велосипед
       */


      mutex = new Mutex();

      #region Thread

      // create a thread with func() as entry point
      Thread thread1 = new Thread(Func1);

      // run it
      thread1.Start();

      // the main thread continues to run...

      mutex.WaitOne();

      for (int i = 0; i < 10; ++i) {
        Console.WriteLine("I'm the main thread");
      }

      mutex.ReleaseMutex();

      Thread thread2 = new Thread(x => Func2((int)x));
      thread2.Start(5);

      #endregion

      #region Task

      // create a thread with func() as entry point
      Task task1 = new Task(Func1);

      // run it
      task1.Start();

      // the main thread continues to run...

      mutex.WaitOne();

      for (int i = 0; i < 10; ++i)
      {
        Console.WriteLine("I'm the main thread");
      }

      mutex.ReleaseMutex();

      #endregion

    }

    #endregion

    #region Help methods

    private static void Func1()
    {
      mutex.WaitOne();

      // this function is started when thread.launch() is called

      for (int i = 0; i < 10; ++i) {
        Console.WriteLine("I'm thread number one");
      }

      mutex.ReleaseMutex();
    }

    private static void Func2(int x)
    {
      Console.WriteLine(x);
    }

    #endregion


  }

  #endregion

}