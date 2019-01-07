using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200015B RID: 347
	public sealed class ChunkType
	{
		// Token: 0x06003219 RID: 12825 RVA: 0x000165B4 File Offset: 0x000147B4
		public ChunkType(Type type, string id)
		{
			this.Type = type;
			this.Id = id;
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600321A RID: 12826 RVA: 0x000165CA File Offset: 0x000147CA
		public Type Type { get; }

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600321B RID: 12827 RVA: 0x000165D2 File Offset: 0x000147D2
		public string Id { get; }
	}
}
