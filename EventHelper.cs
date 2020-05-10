using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management; 			 
		 
namespace QuickSpecs
{

	public static class EventHelper
	{

		public static string[] getPortNames()
		{
			return System.IO.Ports.SerialPort.GetPortNames();
		}

		public static string getPortNames(string separator="\n")
		{
			return string.Join(separator, System.IO.Ports.SerialPort.GetPortNames());
		}

		public static string getServicePackName()
		{
			OperatingSystem os = Environment.OSVersion;
			return os.ServicePack;
		}

		public static string getWindowsName()
		{
			string win_name = "";
			ManagementObjectSearcher   mgtObj  = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
			ManagementObjectCollection infoObj = mgtObj.Get();
			
			if (infoObj != null)
			{
				foreach (ManagementObject obj in infoObj){
					win_name = obj["Caption"].ToString() + " - " + obj["OSArchitecture"].ToString();
				}
				win_name = win_name.Replace("NT 5.1.2600", "XP");
				win_name = win_name.Replace("NT 5.2.3790", "Server 2003");
			}
			else { win_name = "Unknown OS"; }
			return win_name;
		}

		public static string getCpuName()
		{
			string cpu_name = "";
			ManagementObjectSearcher mgtObj  = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
			
			foreach (ManagementObject obj in mgtObj.Get()){
				cpu_name = obj["Name"].ToString();
			}
			return cpu_name;
		}

		public static string getGpuName()
		{
			string gpu_name = "";
			ManagementObjectSearcher mgtObj  = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");
			
			foreach (ManagementObject obj in mgtObj.Get()){
				foreach (PropertyData property in obj.Properties){
					if (property.Name == "Description"){
						gpu_name = property.Value.ToString();
					}
				}
			}
			
			return gpu_name;
		}

		public static int getRamCapacity()
		{
			string ramCap = "";
			ManagementScope ms = new ManagementScope(
					"\\\\.\\root\\cimv2");
			ms.Connect();
			ManagementObjectSearcher searcher =
					new ManagementObjectSearcher(
					"SELECT * FROM Win32_PhysicalMemoryArray");
			searcher.Scope = ms;

			foreach (ManagementObject service in searcher.Get())
			{
				try
				{
					ramCap = service.Properties["MaxCapacity"].Value.ToString();
				}
				catch (Exception)
				{

					Debug.WriteLine($"Error here");
				}			
			}

			return Int32.Parse(ramCap);
		}
		public static int getCurrentRam()
		{
			string ramCurrent = "";
			ManagementScope ms = new ManagementScope(
					"\\\\.\\root\\cimv2");
			ms.Connect();
			ManagementObjectSearcher searcher =
					new ManagementObjectSearcher(
					"SELECT * FROM Win32_MemoryArray");
			searcher.Scope = ms;

			foreach (ManagementObject service in searcher.Get())
			{
				try
				{
					ramCurrent = service.Properties["EndingAddress"].Value.ToString();
				}
				catch (Exception)
				{

					Debug.WriteLine($"Error here");
				}
			}
			return Int32.Parse(ramCurrent);
		}
		public static List<string[]> getLogicalDisks()
		{
			List<string[]> logicalDisks = new List<string[]>();
			ManagementScope ms = new ManagementScope(
					"\\\\.\\root\\cimv2");
			ms.Connect();
			ManagementObjectSearcher searcher =
					new ManagementObjectSearcher(
					"SELECT * FROM Win32_logicalDisk");
			searcher.Scope = ms;

			foreach (ManagementObject service in searcher.Get())
			{
				try
				{
					string[] tmpString = new string[3] {service.Properties["DeviceID"].Value?.ToString(), service.Properties["ProviderName"].Value?.ToString(), service.Properties["VolumeName"].Value?.ToString() };
					logicalDisks.Add(tmpString);
				}
				catch (Exception)
				{

					Debug.WriteLine($"Error here");
				}
			}
			return logicalDisks;
		}



		public static string getHardDisks()
		{
			string hardString = "";
			foreach (string[] item in getLogicalDisks())
			{
				hardString = $"{ hardString } { item[0] } - { item[1] } - { item[2] } \n";
			}

			return hardString;
		}
	}
}
