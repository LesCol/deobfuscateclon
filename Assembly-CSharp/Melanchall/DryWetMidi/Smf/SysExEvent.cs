using System;
using System.Linq;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200017A RID: 378
	public abstract class SysExEvent : MidiEvent
	{
		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060032C0 RID: 12992 RVA: 0x00147B48 File Offset: 0x00145D48
		public bool Completed
		{
			get
			{
				byte[] data = this.Data;
				byte? b = (data != null) ? new byte?(data.LastOrDefault<byte>()) : null;
				int? num = (b != null) ? new int?((int)b.GetValueOrDefault()) : null;
				return num.GetValueOrDefault() == 247 & num != null;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060032C1 RID: 12993 RVA: 0x00016C7B File Offset: 0x00014E7B
		// (set) Token: 0x060032C2 RID: 12994 RVA: 0x00016C83 File Offset: 0x00014E83
		public byte[] Data { get; set; }

		// Token: 0x060032C3 RID: 12995 RVA: 0x00016C8C File Offset: 0x00014E8C
		internal sealed override void Read(MidiReader reader, ReadingSettings settings, int size)
		{
			this.Data = reader.ReadBytes(size);
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x00147BB0 File Offset: 0x00145DB0
		internal sealed override void Write(MidiWriter writer, WritingSettings settings)
		{
			byte[] data = this.Data;
			if (data != null)
			{
				writer.WriteBytes(data);
			}
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x00016C9B File Offset: 0x00014E9B
		internal sealed override int GetSize(WritingSettings settings)
		{
			byte[] data = this.Data;
			if (data == null)
			{
				return 0;
			}
			return data.Length;
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x00016CAB File Offset: 0x00014EAB
		protected sealed override MidiEvent CloneEvent()
		{
			SysExEvent sysExEvent = (SysExEvent)Activator.CreateInstance(base.GetType());
			byte[] data = this.Data;
			sysExEvent.Data = (((data != null) ? data.Clone() : null) as byte[]);
			return sysExEvent;
		}

		// Token: 0x04000B3C RID: 2876
		private const byte EndOfEventByte = 247;
	}
}
