using System;
using Melanchall.DryWetMidi.Common;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001CA RID: 458
	public sealed class SmpteTimeDivision : TimeDivision
	{
		// Token: 0x06003454 RID: 13396 RVA: 0x00017FC3 File Offset: 0x000161C3
		public SmpteTimeDivision(SmpteFormat format, byte resolution)
		{
			this.Format = format;
			this.Resolution = resolution;
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06003455 RID: 13397 RVA: 0x00017FD9 File Offset: 0x000161D9
		public SmpteFormat Format { get; }

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06003456 RID: 13398 RVA: 0x00017FE1 File Offset: 0x000161E1
		public byte Resolution { get; }

		// Token: 0x06003457 RID: 13399 RVA: 0x00017FE9 File Offset: 0x000161E9
		public static bool operator ==(SmpteTimeDivision timeDivision1, SmpteTimeDivision timeDivision2)
		{
			return timeDivision1 == timeDivision2 || (timeDivision1 != null && timeDivision2 != null && timeDivision1.Format == timeDivision2.Format && timeDivision1.Resolution == timeDivision2.Resolution);
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x00018017 File Offset: 0x00016217
		public static bool operator !=(SmpteTimeDivision timeDivision1, SmpteTimeDivision timeDivision2)
		{
			return !(timeDivision1 == timeDivision2);
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x00018023 File Offset: 0x00016223
		internal override short ToInt16()
		{
			return -DataTypesUtilities.Combine((byte)this.Format, this.Resolution);
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x00018038 File Offset: 0x00016238
		public override TimeDivision Clone()
		{
			return new SmpteTimeDivision(this.Format, this.Resolution);
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x0001804B File Offset: 0x0001624B
		public override string ToString()
		{
			return string.Format("{0} frames / sec, {1} subdivisions / frame", this.Format, this.Resolution);
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x0001806D File Offset: 0x0001626D
		public override bool Equals(object obj)
		{
			return this == obj as SmpteTimeDivision;
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x0014909C File Offset: 0x0014729C
		public override int GetHashCode()
		{
			return this.Format.GetHashCode() ^ this.Resolution.GetHashCode();
		}
	}
}
