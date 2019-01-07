using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000180 RID: 384
	public sealed class NoteOnEvent : NoteEvent
	{
		// Token: 0x060032E4 RID: 13028 RVA: 0x00016DDF File Offset: 0x00014FDF
		public NoteOnEvent()
		{
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x00016DE7 File Offset: 0x00014FE7
		public NoteOnEvent(SevenBitNumber noteNumber, SevenBitNumber velocity) : base(noteNumber, velocity)
		{
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x00016E1E File Offset: 0x0001501E
		public override string ToString()
		{
			return string.Format("Note On [{0}] ({1}, {2})", base.Channel, base.NoteNumber, base.Velocity);
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060032E7 RID: 13031 RVA: 0x00016E4B File Offset: 0x0001504B
		// (set) Token: 0x060032E8 RID: 13032 RVA: 0x00016E53 File Offset: 0x00015053
		public NoteOffEvent OffEvent
		{
			get
			{
				return this._offNote;
			}
			set
			{
				this._offNote = value;
			}
		}

		// Token: 0x04000B49 RID: 2889
		private NoteOffEvent _offNote;
	}
}
