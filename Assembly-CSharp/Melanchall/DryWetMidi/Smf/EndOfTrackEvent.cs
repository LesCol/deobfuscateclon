using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000190 RID: 400
	internal sealed class EndOfTrackEvent : MetaEvent
	{
		// Token: 0x0600331C RID: 13084 RVA: 0x00002C8A File Offset: 0x00000E8A
		protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size)
		{
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x00002C8A File Offset: 0x00000E8A
		protected override void WriteContent(MidiWriter writer, WritingSettings settings)
		{
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		protected override int GetContentSize(WritingSettings settings)
		{
			return 0;
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x000170FC File Offset: 0x000152FC
		protected override MidiEvent CloneEvent()
		{
			return new EndOfTrackEvent();
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x00017103 File Offset: 0x00015303
		public override string ToString()
		{
			return "End Of Track";
		}
	}
}
