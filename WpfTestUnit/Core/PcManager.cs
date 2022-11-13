using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestUnit.Core
{
    public class PcManager
    {
        public string LoadPcFeature(int numberOfCpus, bool os64)
        {
            try
            {
                if (numberOfCpus == 0)
                {
                    return "The number of CPUs cannot be zero";
                }


                BasicInfo myInfo = new BasicInfo
                {
                    OsVersion = Environment.OSVersion.ToString(),
                    Os64 = os64,
                    PcName = Environment.MachineName,
                    NumberOfCpus = numberOfCpus,
                    WindowsFolder = Environment.SystemDirectory,
                    LogicalDrives = Environment.GetLogicalDrives()
                };

                return "PC data has been successfully generated";
            }
            catch
            {

                return "An error occurred during data generation";
            }

        }
    }
}
