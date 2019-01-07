using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200015C RID: 348
	public sealed class ChunkTypesCollection : IEnumerable, IEnumerable<ChunkType>
	{
		// Token: 0x0600321C RID: 12828 RVA: 0x000165DA File Offset: 0x000147DA
		public void Add(Type type, string id)
		{
			this._ids.Add(type, id);
			this._types.Add(id, type);
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x000165F6 File Offset: 0x000147F6
		public bool TryGetType(string id, out Type type)
		{
			return this._types.TryGetValue(id, out type);
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x00016605 File Offset: 0x00014805
		public bool TryGetId(Type type, out string id)
		{
			return this._ids.TryGetValue(type, out id);
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x00016614 File Offset: 0x00014814
		public IEnumerator<ChunkType> GetEnumerator()
		{
			return (from kv in this._ids
			select new ChunkType(kv.Key, kv.Value)).GetEnumerator();
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x00016645 File Offset: 0x00014845
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000AFC RID: 2812
		private readonly Dictionary<Type, string> _ids = new Dictionary<Type, string>();

		// Token: 0x04000AFD RID: 2813
		private readonly Dictionary<string, Type> _types = new Dictionary<string, Type>();
	}
}
