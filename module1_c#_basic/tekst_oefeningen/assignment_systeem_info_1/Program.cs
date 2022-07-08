using System;
using System.IO;

namespace assignment_systeem_info_1
{
  class Program
  {
    static void Main(string[] args)
    {
      string pcname = Environment.MachineName;
      int proccount = Environment.ProcessorCount;
      string username = Environment.UserName;
      long memory = Environment.WorkingSet;
      var operatingSystem = Environment.OSVersion;
      var version = Environment.Version;
      int invoer= Convert.ToInt32(Console.ReadLine()) - 1;
      long cdriveinbytes = DriveInfo.GetDrives()[invoer].AvailableFreeSpace;  
      long totalsize = DriveInfo.GetDrives()[invoer].TotalSize;
      Console.WriteLine($"pc name: {pcname}\nprocessors: {proccount}\nusername: {username}\nassigned program memory: {memory}\noperating system: {operatingSystem}\nversion: {version}");
      Console.WriteLine($"c drive in bytes:{cdriveinbytes*1e-9:F2}GB\ntotal size:{totalsize*1e-9:F2}GB");
    }
  }
}