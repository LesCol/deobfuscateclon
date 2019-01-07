using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Melanchall.DryWetMidi.Common
{
	// Token: 0x020001E1 RID: 481
	internal static class ThrowIfArgument
	{
		// Token: 0x060034A9 RID: 13481 RVA: 0x000183B6 File Offset: 0x000165B6
		internal static void IsNull(string parameterName, object argument)
		{
			if (argument == null)
			{
				throw new ArgumentNullException(parameterName);
			}
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x000183C2 File Offset: 0x000165C2
		internal static void IsInvalidEnumValue<TEnum>(string parameterName, TEnum argument) where TEnum : struct
		{
			if (!Enum.IsDefined(typeof(TEnum), argument))
			{
				throw new InvalidEnumArgumentException(parameterName, Convert.ToInt32(argument), typeof(TEnum));
			}
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x000183F7 File Offset: 0x000165F7
		internal static void IsOutOfRange(string parameterName, int value, int min, int max, string message)
		{
			if (value < min || value > max)
			{
				throw new ArgumentOutOfRangeException(parameterName, value, message);
			}
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x00018410 File Offset: 0x00016610
		internal static void IsOutOfRange(string parameterName, long value, long min, long max, string message)
		{
			if (value < min || value > max)
			{
				throw new ArgumentOutOfRangeException(parameterName, value, message);
			}
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x00018429 File Offset: 0x00016629
		internal static void IsOutOfRange(string parameterName, double value, double min, double max, string message)
		{
			if (value < min || value > max)
			{
				throw new ArgumentOutOfRangeException(parameterName, value, message);
			}
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x00018442 File Offset: 0x00016642
		internal static void DoesntSatisfyCondition(string parameterName, int value, Predicate<int> condition, string message)
		{
			if (!condition(value))
			{
				throw new ArgumentOutOfRangeException(parameterName, value, message);
			}
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x0001845B File Offset: 0x0001665B
		internal static void IsGreaterThan(string parameterName, int value, int reference, string message)
		{
			ThrowIfArgument.IsOutOfRange(parameterName, value, int.MinValue, reference, message);
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x0001846B File Offset: 0x0001666B
		internal static void IsGreaterThan(string parameterName, long value, long reference, string message)
		{
			ThrowIfArgument.IsOutOfRange(parameterName, value, long.MinValue, reference, message);
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x0001847F File Offset: 0x0001667F
		internal static void IsLessThan(string parameterName, int value, int reference, string message)
		{
			ThrowIfArgument.IsOutOfRange(parameterName, value, reference, int.MaxValue, message);
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x0001848F File Offset: 0x0001668F
		internal static void IsLessThan(string parameterName, long value, long reference, string message)
		{
			ThrowIfArgument.IsOutOfRange(parameterName, value, reference, long.MaxValue, message);
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x000184A3 File Offset: 0x000166A3
		internal static void IsLessThan(string parameterName, double value, double reference, string message)
		{
			ThrowIfArgument.IsOutOfRange(parameterName, value, reference, double.MaxValue, message);
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x000184B7 File Offset: 0x000166B7
		internal static void IsNegative(string parameterName, int value, string message)
		{
			ThrowIfArgument.IsLessThan(parameterName, value, 0, message);
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x000184C2 File Offset: 0x000166C2
		internal static void IsNegative(string parameterName, long value, string message)
		{
			ThrowIfArgument.IsLessThan(parameterName, value, 0L, message);
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x000184D5 File Offset: 0x000166D5
		internal static void IsNegative(string parameterName, double value, string message)
		{
			ThrowIfArgument.IsLessThan(parameterName, value, 0.0, message);
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x000184E8 File Offset: 0x000166E8
		internal static void IsNonpositive(string parameterName, int value, string message)
		{
			ThrowIfArgument.IsLessThan(parameterName, value, 1, message);
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x000184F3 File Offset: 0x000166F3
		internal static void IsNonpositive(string parameterName, long value, string message)
		{
			ThrowIfArgument.IsLessThan(parameterName, value, 1L, message);
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x00018506 File Offset: 0x00016706
		internal static void IsNonpositive(string parameterName, double value, string message)
		{
			ThrowIfArgument.IsLessThan(parameterName, value, double.Epsilon, message);
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x00018519 File Offset: 0x00016719
		internal static void IsNullOrWhiteSpaceString(string parameterName, string value, string stringDescription)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentException(stringDescription + " is null or contains white-spaces only.", parameterName);
			}
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x00018535 File Offset: 0x00016735
		internal static void IsInvalidIndex(string parameterName, int index, int collectionSize)
		{
			ThrowIfArgument.IsOutOfRange(parameterName, index, 0, collectionSize, "Index is out of range.");
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x00018545 File Offset: 0x00016745
		internal static void IsEmptyCollection<T>(string parameterName, IEnumerable<T> collection, string message)
		{
			if (!collection.Any<T>())
			{
				throw new ArgumentException(message, parameterName);
			}
		}

		// Token: 0x04000C98 RID: 3224
		private const int MinNonnegativeValue = 0;

		// Token: 0x04000C99 RID: 3225
		private const int MinPositiveValue = 1;
	}
}
