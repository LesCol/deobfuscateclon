using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000178 RID: 376
	public abstract class MetaEvent : MidiEvent
	{
		// Token: 0x060032AF RID: 12975 RVA: 0x00016C1F File Offset: 0x00014E1F
		internal sealed override void Read(MidiReader reader, ReadingSettings settings, int size)
		{
			this.ReadContent(reader, settings, size);
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x00016C2A File Offset: 0x00014E2A
		internal sealed override void Write(MidiWriter writer, WritingSettings settings)
		{
			this.WriteContent(writer, settings);
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x00016C34 File Offset: 0x00014E34
		internal sealed override int GetSize(WritingSettings settings)
		{
			return this.GetContentSize(settings);
		}

		// Token: 0x060032B2 RID: 12978
		protected abstract void ReadContent(MidiReader reader, ReadingSettings settings, int size);

		// Token: 0x060032B3 RID: 12979
		protected abstract void WriteContent(MidiWriter writer, WritingSettings settings);

		// Token: 0x060032B4 RID: 12980
		protected abstract int GetContentSize(WritingSettings settings);
	}
}
