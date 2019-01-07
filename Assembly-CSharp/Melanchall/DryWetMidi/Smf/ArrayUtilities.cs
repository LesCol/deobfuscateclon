using System;
using System.Collections.Generic;
using System.Linq;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001CE RID: 462
	internal static class ArrayUtilities
	{
		// Token: 0x0600346D RID: 13421 RVA: 0x0001813A File Offset: 0x0001633A
		internal static bool Equals<T>(T[] array1, T[] array2)
		{
			return array1 == array2 || (array1 != null && array2 != null && array1.Length == array2.Length && array1.SequenceEqual(array2));
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x0001815B File Offset: 0x0001635B
		internal static int GetHashCode<T>(T[] array)
		{
			if (array == null)
			{
				return 0;
			}
			return array.GetHashCode(EqualityComparer<T>.Default);
		}
	}
}
