using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001CB RID: 459
	public sealed class TicksPerQuarterNoteTimeDivision : TimeDivision
	{
		// Token: 0x0600345E RID: 13406 RVA: 0x0001807B File Offset: 0x0001627B
		public TicksPerQuarterNoteTimeDivision()
		{
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x0001808B File Offset: 0x0001628B
		public TicksPerQuarterNoteTimeDivision(short ticksPerQuarterNote)
		{
			this.TicksPerQuarterNote = ticksPerQuarterNote;
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06003460 RID: 13408 RVA: 0x000180A2 File Offset: 0x000162A2
		// (set) Token: 0x06003461 RID: 13409 RVA: 0x000180AA File Offset: 0x000162AA
		public short TicksPerQuarterNote { get; set; } = 96;

		// Token: 0x06003462 RID: 13410 RVA: 0x000180B3 File Offset: 0x000162B3
		public static bool operator ==(TicksPerQuarterNoteTimeDivision timeDivision1, TicksPerQuarterNoteTimeDivision timeDivision2)
		{
			return timeDivision1 == timeDivision2 || (timeDivision1 != null && timeDivision2 != null && timeDivision1.TicksPerQuarterNote == timeDivision2.TicksPerQuarterNote);
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x000180D1 File Offset: 0x000162D1
		public static bool operator !=(TicksPerQuarterNoteTimeDivision timeDivision1, TicksPerQuarterNoteTimeDivision timeDivision2)
		{
			return !(timeDivision1 == timeDivision2);
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x000180DD File Offset: 0x000162DD
		internal override short ToInt16()
		{
			return this.TicksPerQuarterNote;
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x000180E5 File Offset: 0x000162E5
		public override TimeDivision Clone()
		{
			return new TicksPerQuarterNoteTimeDivision(this.TicksPerQuarterNote);
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x000180F2 File Offset: 0x000162F2
		public override string ToString()
		{
			return string.Format("{0} ticks/qnote", this.TicksPerQuarterNote);
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x00018109 File Offset: 0x00016309
		public override bool Equals(object obj)
		{
			return this == obj as TicksPerQuarterNoteTimeDivision;
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x001490CC File Offset: 0x001472CC
		public override int GetHashCode()
		{
			return this.TicksPerQuarterNote.GetHashCode();
		}

		// Token: 0x04000C03 RID: 3075
		public const short DefaultTicksPerQuarterNote = 96;
	}
}
