namespace DuplicateFileFinder
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;

    internal static class Program
    {
        internal static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: DuplicateFileFinder <dir1> [dir2] ... [dirN].");
                return;
            }

            foreach (string arg in args)
            {
                if (!Directory.Exists(arg))
                {
                Console.WriteLine("Error: Directory \"{0}\" does not exist.", arg);
                return;
            }
            }

            try
            {
                var files = new Dictionary<string, List<string>>(capacity: 1024);
                foreach (string directory in args)
                {
                    foreach (string file in Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories))
                    {
                        string hash = ComputeHash(file);
                        if (!files.ContainsKey(hash))
                        {
                            files.Add(hash, new List<string>());
                        }

                        files[hash].Add(file);
                    }
                }

                foreach (string hash in files.Keys)
                {
                    if (files[hash].Count > 1)
                    {
                        Console.WriteLine(string.Join(" -> ", files[hash]));
                    }
                }
            }
            catch (Exception x)
            {
                Console.WriteLine("Error: {0}.", x.Message);
            }
        }

        private static string ComputeHash(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var hashAlgorithm = new SHA1Managed();
                byte[] hashedBytes = hashAlgorithm.ComputeHash(stream);
                string hashedString = Encoding.UTF8.GetString(hashedBytes);
                return hashedString;
            }
        }
    }
}
