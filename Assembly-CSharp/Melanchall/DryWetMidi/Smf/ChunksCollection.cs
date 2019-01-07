using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000171 RID: 369
	public sealed class ChunksCollection : IEnumerable, IEnumerable<MidiChunk>
	{
		// Token: 0x1700043D RID: 1085
		public MidiChunk this[int index]
		{
			get
			{
				return this._chunks[index];
			}
			set
			{
				this._chunks[index] = value;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06003273 RID: 12915 RVA: 0x000168EA File Offset: 0x00014AEA
		public int Count
		{
			get
			{
				return this._chunks.Count;
			}
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x000168F7 File Offset: 0x00014AF7
		public void Add(MidiChunk chunk)
		{
			this._chunks.Add(chunk);
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x00016905 File Offset: 0x00014B05
		public void AddRange(IEnumerable<MidiChunk> chunks)
		{
			this._chunks.AddRange(from c in chunks
			where c != null
			select c);
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x00016937 File Offset: 0x00014B37
		public void Insert(int index, MidiChunk chunk)
		{
			this._chunks.Insert(index, chunk);
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x00016946 File Offset: 0x00014B46
		public void InsertRange(int index, IEnumerable<MidiChunk> chunks)
		{
			this._chunks.InsertRange(index, from c in chunks
			where c != null
			select c);
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x00016979 File Offset: 0x00014B79
		public bool Remove(MidiChunk chunk)
		{
			return this._chunks.Remove(chunk);
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x00016987 File Offset: 0x00014B87
		public void RemoveAt(int index)
		{
			this._chunks.RemoveAt(index);
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x00016995 File Offset: 0x00014B95
		public int RemoveAll(Predicate<MidiChunk> match)
		{
			return this._chunks.RemoveAll(match);
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x000169A3 File Offset: 0x00014BA3
		public int IndexOf(MidiChunk chunk)
		{
			return this._chunks.IndexOf(chunk);
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x000169B1 File Offset: 0x00014BB1
		public void Clear()
		{
			this._chunks.Clear();
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x000169BE File Offset: 0x00014BBE
		public IEnumerator<MidiChunk> GetEnumerator()
		{
			return this._chunks.GetEnumerator();
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x000169BE File Offset: 0x00014BBE
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this._chunks.GetEnumerator();
		}

		// Token: 0x04000B26 RID: 2854
		private readonly List<MidiChunk> _chunks = new List<MidiChunk>(15);
	}
}
