#region Copyright

// (c) Developed by Eva, 12 июня 2024 г.

#endregion

#region Using

using SFML.Graphics;
using System.IO;

#endregion

namespace UserDataStreams
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
    /// <example>https://www.sfml-dev.org/tutorials/2.6/system-stream.php</example>
    /// <param name="sArgsArray">App params</param>
    public static void Main(string[] sArgsArray)
    {
      /*
       * Класс InputStream используется внутри SFML классов неявно.
       * Является обверткой над Stream
       * Поэтому нужно использовать любой наследник от Stream, какой хочется:
       * FileStream, MemoryStream, что-то свое...
       */

      // sf::FileStream stream;
      // stream.open("image.png");

      // sf::Texture texture;
      // texture.loadFromStream(stream);

      {
        FileStream pFileStream = File.OpenRead("./test_image.png");
        Texture texture = new Texture(pFileStream);

        texture.Dispose();
        pFileStream.Dispose();
      }

      
    }

    #endregion

    #region Help methods

    #endregion

  }

  #endregion

}