using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000173 RID: 371
	public sealed class EventsCollection : IEnumerable, IEnumerable<MidiEvent>
	{
		// Token: 0x06003284 RID: 12932 RVA: 0x000169F7 File Offset: 0x00014BF7
		internal EventsCollection()
		{
		}

		// Token: 0x1700043F RID: 1087
		public MidiEvent this[int index]
		{
			get
			{
				return this._events[index];
			}
			set
			{
				this._events[index] = value;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06003287 RID: 12935 RVA: 0x00016A2C File Offset: 0x00014C2C
		public int Count
		{
			get
			{
				return this._events.Count;
			}
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x00016A39 File Offset: 0x00014C39
		public void Add(MidiEvent midiEvent)
		{
			this._events.Add(midiEvent);
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x00016A47 File Offset: 0x00014C47
		public void AddRange(IEnumerable<MidiEvent> events)
		{
			this._events.AddRange(from e in events
			where e != null
			select e);
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x00016A79 File Offset: 0x00014C79
		public void Insert(int index, MidiEvent midiEvent)
		{
			this._events.Insert(index, midiEvent);
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x00016A88 File Offset: 0x00014C88
		public void InsertRange(int index, IEnumerable<MidiEvent> midiEvents)
		{
			this._events.InsertRange(index, midiEvents);
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x00016A97 File Offset: 0x00014C97
		public bool Remove(MidiEvent midiEvent)
		{
			return this._events.Remove(midiEvent);
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x00016AA5 File Offset: 0x00014CA5
		public void RemoveAt(int index)
		{
			this._events.RemoveAt(index);
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x00016AB3 File Offset: 0x00014CB3
		public int RemoveAll(Predicate<MidiEvent> match)
		{
			return this._events.RemoveAll(match);
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x00016AC1 File Offset: 0x00014CC1
		public int IndexOf(MidiEvent midiEvent)
		{
			return this._events.IndexOf(midiEvent);
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x00016ACF File Offset: 0x00014CCF
		public void Clear()
		{
			this._events.Clear();
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x00016ADC File Offset: 0x00014CDC
		public IEnumerator<MidiEvent> GetEnumerator()
		{
			return this._events.GetEnumerator();
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x00016ADC File Offset: 0x00014CDC
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this._events.GetEnumerator();
		}

		// Token: 0x04000B2A RID: 2858
		private readonly List<MidiEvent> _events = new List<MidiEvent>(10000);
	}
}
