using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000187 RID: 391
	public sealed class EventType
	{
		// Token: 0x060032F3 RID: 13043 RVA: 0x00016EEF File Offset: 0x000150EF
		public EventType(Type type, byte statusByte)
		{
			this.Type = type;
			this.StatusByte = statusByte;
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060032F4 RID: 13044 RVA: 0x00016F05 File Offset: 0x00015105
		public Type Type { get; }

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060032F5 RID: 13045 RVA: 0x00016F0D File Offset: 0x0001510D
		public byte StatusByte { get; }
	}
}
