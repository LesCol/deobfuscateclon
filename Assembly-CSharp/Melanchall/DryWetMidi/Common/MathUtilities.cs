using System;

namespace Melanchall.DryWetMidi.Common
{
	// Token: 0x020001D8 RID: 472
	internal static class MathUtilities
	{
		// Token: 0x06003495 RID: 13461 RVA: 0x000182F1 File Offset: 0x000164F1
		internal static bool IsPowerOfTwo(int value)
		{
			return value != 0 && (value & value - 1) == 0;
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x00149334 File Offset: 0x00147534
		internal static long LeastCommonMultiple(long a, long b)
		{
			long num;
			long num2;
			if (a > b)
			{
				num = a;
				num2 = b;
			}
			else
			{
				num = b;
				num2 = a;
			}
			int num3 = 1;
			while ((long)num3 < num2)
			{
				if (num * (long)num3 % num2 == 0L)
				{
					return (long)num3 * num;
				}
				num3++;
			}
			return num * num2;
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x00018300 File Offset: 0x00016500
		internal static long GreatestCommonDivisor(long a, long b)
		{
			while (b != 0L)
			{
				long num = a % b;
				a = b;
				b = num;
			}
			return a;
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x0014936C File Offset: 0x0014756C
		internal static Tuple<long, long> SolveDiophantineEquation(long a, long b)
		{
			long num = MathUtilities.GreatestCommonDivisor(a, b);
			return Tuple.Create<long, long>(b / num, -a / num);
		}
	}
}
