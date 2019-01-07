using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001D1 RID: 465
	internal static class FileUtilities
	{
		// Token: 0x0600347E RID: 13438
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern SafeFileHandle CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

		// Token: 0x0600347F RID: 13439 RVA: 0x001491E8 File Offset: 0x001473E8
		internal static FileStream OpenFileForRead(string filePath)
		{
			FileStream result;
			try
			{
				result = File.OpenRead(filePath);
			}
			catch (PathTooLongException)
			{
				result = new FileStream(FileUtilities.GetFileHandle(filePath, 2147483648u, 3u), FileAccess.Read);
			}
			return result;
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x00149228 File Offset: 0x00147428
		internal static FileStream OpenFileForWrite(string filePath, bool overwriteFile)
		{
			FileStream result;
			try
			{
				result = File.Open(filePath, overwriteFile ? FileMode.Create : FileMode.CreateNew);
			}
			catch (PathTooLongException)
			{
				result = new FileStream(FileUtilities.GetFileHandle(filePath, 1073741824u, overwriteFile ? 2u : 1u), FileAccess.Write);
			}
			return result;
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x00149274 File Offset: 0x00147474
		private static SafeFileHandle GetFileHandle(string filePath, uint fileAccess, uint creationDisposition)
		{
			SafeFileHandle safeFileHandle = FileUtilities.CreateFile("\\\\?\\" + filePath, fileAccess, 0u, IntPtr.Zero, creationDisposition, 0u, IntPtr.Zero);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (safeFileHandle.IsInvalid)
			{
				throw new Win32Exception(lastWin32Error);
			}
			return safeFileHandle;
		}

		// Token: 0x04000C05 RID: 3077
		private const uint GENERIC_READ = 2147483648u;

		// Token: 0x04000C06 RID: 3078
		private const uint GENERIC_WRITE = 1073741824u;

		// Token: 0x04000C07 RID: 3079
		private const uint CREATE_NEW = 1u;

		// Token: 0x04000C08 RID: 3080
		private const uint CREATE_ALWAYS = 2u;

		// Token: 0x04000C09 RID: 3081
		private const uint OPEN_EXISTING = 3u;

		// Token: 0x04000C0A RID: 3082
		private const uint FILE_SHARE_NONE = 0u;
	}
}
