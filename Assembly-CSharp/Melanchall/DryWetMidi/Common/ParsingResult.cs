using System;

namespace Melanchall.DryWetMidi.Common
{
	// Token: 0x020001DA RID: 474
	internal sealed class ParsingResult
	{
		// Token: 0x06003499 RID: 13465 RVA: 0x00018311 File Offset: 0x00016511
		public ParsingResult(string error) : this(ParsingStatus.FormatError, error)
		{
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x0001831B File Offset: 0x0001651B
		private ParsingResult(ParsingStatus status) : this(status, null)
		{
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x00018325 File Offset: 0x00016525
		private ParsingResult(ParsingStatus status, string error)
		{
			this.Status = status;
			this.Error = error;
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x0600349C RID: 13468 RVA: 0x0001833B File Offset: 0x0001653B
		public ParsingStatus Status { get; }

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600349D RID: 13469 RVA: 0x00018343 File Offset: 0x00016543
		public string Error { get; }

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600349E RID: 13470 RVA: 0x00149390 File Offset: 0x00147590
		public Exception Exception
		{
			get
			{
				switch (this.Status)
				{
				case ParsingStatus.EmptyInputString:
					return new ArgumentException("Input string is null or contains white-spaces only.");
				case ParsingStatus.NotMatched:
					return new FormatException("Input string has invalid format.");
				case ParsingStatus.FormatError:
					return new FormatException(this.Error);
				default:
					return null;
				}
			}
		}

		// Token: 0x04000C82 RID: 3202
		public static readonly ParsingResult Parsed = new ParsingResult(ParsingStatus.Parsed);

		// Token: 0x04000C83 RID: 3203
		public static readonly ParsingResult EmptyInputString = new ParsingResult(ParsingStatus.EmptyInputString);

		// Token: 0x04000C84 RID: 3204
		public static readonly ParsingResult NotMatched = new ParsingResult(ParsingStatus.NotMatched);
	}
}
