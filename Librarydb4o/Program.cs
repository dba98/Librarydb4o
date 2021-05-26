using System;
using System.IO;
using Db4objects.Db4o;

namespace Librarydb4o
{
    public class Program
    {
        private static readonly string Db4ODatabaseFile = $"{Directory.GetCurrentDirectory()}/data.db4o";

        private static void Main(string[] args)
        {
            if (!File.Exists(Db4ODatabaseFile))
            {
                File.Create(Db4ODatabaseFile);
                Db4oEmbedded.OpenFile(Db4oEmbedded.NewConfiguration(), Db4ODatabaseFile);
            }
            IObjectContainer db = Db4oEmbedded.OpenFile(Db4ODatabaseFile);

            try
            {
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}