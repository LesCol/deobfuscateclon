using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001A7 RID: 423
	internal static class EventWriterFactory
	{
		// Token: 0x060033B5 RID: 13237 RVA: 0x000177CD File Offset: 0x000159CD
		internal static IEventWriter GetWriter(MidiEvent midiEvent)
		{
			if (midiEvent is MetaEvent)
			{
				return EventWriterFactory._metaEventWriter;
			}
			if (midiEvent is ChannelEvent)
			{
				return EventWriterFactory._channelEventWriter;
			}
			return EventWriterFactory._sysExEventWriter;
		}

		// Token: 0x04000B9F RID: 2975
		private static readonly IEventWriter _metaEventWriter = new MetaEventWriter();

		// Token: 0x04000BA0 RID: 2976
		private static readonly IEventWriter _channelEventWriter = new ChannelEventWriter();

		// Token: 0x04000BA1 RID: 2977
		private static readonly IEventWriter _sysExEventWriter = new SysExEventWriter();
	}
}
