using System;
using System.Collections.Generic;
using System.Diagnostics;
using Consuum.Domain;

namespace Consuum.Clipboard
{
    public class MacClipboard : ITextReader
    {
        public List<string> GetLines()
        {
            var lines = new List<string>();
            try
            {
                var procStartInfo = new ProcessStartInfo()
                {
                    FileName = "/bin/sh",
                    RedirectStandardOutput = true,
                    Arguments = "-c pbpaste -",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                };

                var proc = new Process { StartInfo = procStartInfo };
                proc.Start();
                while(proc.StandardOutput.EndOfStream == false)
                {
                    lines.Add(proc.StandardOutput.ReadLine());
                }
                proc.WaitForExit();
                return lines;
            }
            catch{ throw; }
        }
    }
}
