using System;
using System.Text;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200018B RID: 395
	public abstract class BaseTextEvent : MetaEvent
	{
		// Token: 0x06003300 RID: 13056 RVA: 0x00016FCC File Offset: 0x000151CC
		public BaseTextEvent()
		{
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x00016FD4 File Offset: 0x000151D4
		public BaseTextEvent(string text) : this()
		{
			this.Text = text;
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06003302 RID: 13058 RVA: 0x00016FE3 File Offset: 0x000151E3
		// (set) Token: 0x06003303 RID: 13059 RVA: 0x00016FEB File Offset: 0x000151EB
		public string Text { get; set; }

		// Token: 0x06003304 RID: 13060 RVA: 0x00147DE0 File Offset: 0x00145FE0
		protected sealed override void ReadContent(MidiReader reader, ReadingSettings settings, int size)
		{
			if (size <= 0)
			{
				return;
			}
			byte[] bytes = reader.ReadBytes(size);
			Encoding somename = SomeClass.somename;
			Encoding utf = Encoding.UTF8;
			string @string = somename.GetString(bytes);
			if (@string.Contains("Ã"))
			{
				@string = utf.GetString(bytes);
			}
			this.Text = @string;
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x00147E28 File Offset: 0x00146028
		protected sealed override void WriteContent(MidiWriter writer, WritingSettings settings)
		{
			string text = this.Text;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			byte[] bytes = (settings.TextEncoding ?? SmfUtilities.DefaultEncoding).GetBytes(text);
			writer.WriteBytes(bytes);
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x00016FF4 File Offset: 0x000151F4
		protected sealed override int GetContentSize(WritingSettings settings)
		{
			if (string.IsNullOrEmpty(this.Text))
			{
				return 0;
			}
			return (settings.TextEncoding ?? SmfUtilities.DefaultEncoding).GetByteCount(this.Text);
		}
	}
}
