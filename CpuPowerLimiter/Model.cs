using System;
using System.Diagnostics;
using Microsoft.Win32;

namespace CpuPowerLimiter
{
    public sealed class Model
    {
        // Singleton instance.
        public static Model Instance { get; } = new Model();
        private Model(){}

        public void SetSettings(int cpuLimitPercentage,int turboBoostParam)
        {
            var currentPowerSchemes = ReadReg(@"SYSTEM\CurrentControlSet\Control\Power\User\PowerSchemes", "ActivePowerScheme");

            var cmd = new Process
            {
                StartInfo =
                {
                    FileName = Environment.GetEnvironmentVariable("ComSpec"),
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    Arguments = $@"/c powercfg -setacvalueindex {currentPowerSchemes} 54533251-82be-4824-96c1-47b60b740d00 bc5038f7-23e0-4960-96da-33abaf5935ec {cpuLimitPercentage} & powercfg -setdcvalueindex {currentPowerSchemes} 54533251-82be-4824-96c1-47b60b740d00 bc5038f7-23e0-4960-96da-33abaf5935ec {cpuLimitPercentage} & powercfg -setacvalueindex {currentPowerSchemes} 54533251-82be-4824-96c1-47b60b740d00 be337238-0d82-4146-a960-4f3749d470c7 {turboBoostParam} & powercfg -setdcvalueindex {currentPowerSchemes} 54533251-82be-4824-96c1-47b60b740d00 be337238-0d82-4146-a960-4f3749d470c7 {turboBoostParam} & Powercfg -setactive {currentPowerSchemes}"
                }
            };
            cmd.Start();
        }

        private string ReadReg(string subKey, string keyName)
        {
            try
            {
                var key = Registry.LocalMachine.OpenSubKey(subKey);
                if (key != null) return key.GetValue(keyName).ToString();
            }
            catch
            {
                return "";

            }
            return "";
        }

    }
}