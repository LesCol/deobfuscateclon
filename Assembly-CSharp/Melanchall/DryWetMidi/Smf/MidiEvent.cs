using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000179 RID: 377
	public abstract class MidiEvent
	{
		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x00016C45 File Offset: 0x00014E45
		// (set) Token: 0x060032B7 RID: 12983 RVA: 0x00016C4D File Offset: 0x00014E4D
		public long DeltaTime
		{
			get
			{
				return this._deltaTime;
			}
			set
			{
				this._deltaTime = value;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x00016C56 File Offset: 0x00014E56
		// (set) Token: 0x060032B9 RID: 12985 RVA: 0x00016C5E File Offset: 0x00014E5E
		public long AbsoluteTime
		{
			get
			{
				return this._absTime;
			}
			set
			{
				this._absTime = value;
			}
		}

		// Token: 0x060032BA RID: 12986
		internal abstract void Read(MidiReader reader, ReadingSettings settings, int size);

		// Token: 0x060032BB RID: 12987
		internal abstract void Write(MidiWriter writer, WritingSettings settings);

		// Token: 0x060032BC RID: 12988
		internal abstract int GetSize(WritingSettings settings);

		// Token: 0x060032BD RID: 12989
		protected abstract MidiEvent CloneEvent();

		// Token: 0x060032BE RID: 12990 RVA: 0x00016C67 File Offset: 0x00014E67
		public MidiEvent Clone()
		{
			MidiEvent midiEvent = this.CloneEvent();
			midiEvent.DeltaTime = this.DeltaTime;
			return midiEvent;
		}

		// Token: 0x04000B39 RID: 2873
		public const int UnknownContentSize = -1;

		// Token: 0x04000B3A RID: 2874
		private long _deltaTime;

		// Token: 0x04000B3B RID: 2875
		private long _absTime;
	}
}
