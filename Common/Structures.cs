using System.Collections.Generic;
using System;
using System.Text;

namespace Common
{
    public struct UserFiles
    {
        int username;
        List<FileShown> files;
    }

    public struct FileShown
    {
        string filename;
        string user;
        DateTime created;
        DateTime modified;
    }

    public class Message
    {
        byte[] metadata = new byte[12];
        byte[] content = new byte[4084];

        string decodeMetadata()
        {
            return Encoding.ASCII.GetChars(metadata).ToString();
        }

        string decodeContent()
        {
            return Encoding.ASCII.GetChars(content).ToString();
        }
    }
}
