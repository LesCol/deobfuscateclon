using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200019A RID: 410
	public sealed class SetTempoEvent : MetaEvent
	{
		// Token: 0x0600335D RID: 13149 RVA: 0x000173B1 File Offset: 0x000155B1
		public SetTempoEvent()
		{
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x000173C8 File Offset: 0x000155C8
		public SetTempoEvent(long microsecondsPerQuarterNote) : this()
		{
			this.MicrosecondsPerQuarterNote = microsecondsPerQuarterNote;
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x0600335F RID: 13151 RVA: 0x000173D7 File Offset: 0x000155D7
		// (set) Token: 0x06003360 RID: 13152 RVA: 0x000173DF File Offset: 0x000155DF
		public long MicrosecondsPerQuarterNote
		{
			get
			{
				return this._microsecondsPerBeat;
			}
			set
			{
				this._microsecondsPerBeat = value;
			}
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x000173E8 File Offset: 0x000155E8
		protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size)
		{
			this.MicrosecondsPerQuarterNote = (long)((ulong)reader.Read3ByteDword());
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x000173F7 File Offset: 0x000155F7
		protected override void WriteContent(MidiWriter writer, WritingSettings settings)
		{
			writer.Write3ByteDword((uint)this.MicrosecondsPerQuarterNote);
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x00017406 File Offset: 0x00015606
		protected override int GetContentSize(WritingSettings settings)
		{
			return 3;
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x00017409 File Offset: 0x00015609
		protected override MidiEvent CloneEvent()
		{
			return new SetTempoEvent(this.MicrosecondsPerQuarterNote);
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x00017416 File Offset: 0x00015616
		public override string ToString()
		{
			return string.Format("Set Tempo ({0})", this.MicrosecondsPerQuarterNote);
		}

		// Token: 0x04000B81 RID: 2945
		public const long DefaultTempo = 500000L;

		// Token: 0x04000B82 RID: 2946
		private long _microsecondsPerBeat = 500000L;
	}
}
