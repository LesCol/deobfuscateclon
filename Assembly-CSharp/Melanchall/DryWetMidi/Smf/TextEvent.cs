using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200019C RID: 412
	public sealed class TextEvent : BaseTextEvent
	{
		// Token: 0x0600337F RID: 13183 RVA: 0x0001707F File Offset: 0x0001527F
		public TextEvent()
		{
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x00017087 File Offset: 0x00015287
		public TextEvent(string text) : base(text)
		{
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x0001759F File Offset: 0x0001579F
		protected override MidiEvent CloneEvent()
		{
			return new TextEvent(base.Text);
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x000175AC File Offset: 0x000157AC
		public override string ToString()
		{
			return "Text (" + base.Text + ")";
		}
	}
}
