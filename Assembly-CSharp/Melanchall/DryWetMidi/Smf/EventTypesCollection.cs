using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000188 RID: 392
	public sealed class EventTypesCollection : IEnumerable, IEnumerable<EventType>
	{
		// Token: 0x060032F6 RID: 13046 RVA: 0x00016F15 File Offset: 0x00015115
		public void Add(Type type, byte statusByte)
		{
			this._statusBytes.Add(type, statusByte);
			this._types.Add(statusByte, type.Name);
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x00016F36 File Offset: 0x00015136
		public bool TryGetType(byte statusByte, out string type)
		{
			return this._types.TryGetValue(statusByte, out type);
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x00016F45 File Offset: 0x00015145
		public bool TryGetStatusByte(Type type, out byte statusByte)
		{
			return this._statusBytes.TryGetValue(type, out statusByte);
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x00016F54 File Offset: 0x00015154
		public IEnumerator<EventType> GetEnumerator()
		{
			return (from kv in this._statusBytes
			select new EventType(kv.Key, kv.Value)).GetEnumerator();
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x00016F85 File Offset: 0x00015185
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000B6D RID: 2925
		private readonly Dictionary<Type, byte> _statusBytes = new Dictionary<Type, byte>();

		// Token: 0x04000B6E RID: 2926
		private readonly Dictionary<byte, string> _types = new Dictionary<byte, string>();
	}
}
