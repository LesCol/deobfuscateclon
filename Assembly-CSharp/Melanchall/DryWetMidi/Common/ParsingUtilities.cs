using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Melanchall.DryWetMidi.Common
{
	// Token: 0x020001DC RID: 476
	internal static class ParsingUtilities
	{
		// Token: 0x060034A0 RID: 13472 RVA: 0x0001836E File Offset: 0x0001656E
		public static string GetNumberGroup(string groupName)
		{
			return "(?<" + groupName + ">\\d+)";
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x001493DC File Offset: 0x001475DC
		public static Match Match(string input, IEnumerable<string> patterns)
		{
			return (from p in patterns
			select Regex.Match(input.Trim(), "^" + p + "$")).FirstOrDefault((Match m) => m.Success);
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x0014942C File Offset: 0x0014762C
		public static bool ParseInt(Match match, string groupName, int defaultValue, out int value)
		{
			value = defaultValue;
			Group group = match.Groups[groupName];
			return !group.Success || int.TryParse(group.Value, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, null, out value);
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x00149464 File Offset: 0x00147664
		public static bool ParseLong(Match match, string groupName, long defaultValue, out long value)
		{
			value = defaultValue;
			Group group = match.Groups[groupName];
			return !group.Success || long.TryParse(group.Value, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, null, out value);
		}

		// Token: 0x04000C8C RID: 3212
		private const NumberStyles NumberStyle = NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite;
	}
}
