using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001A0 RID: 416
	internal static class EventReaderFactory
	{
		// Token: 0x060033A0 RID: 13216 RVA: 0x00017713 File Offset: 0x00015913
		internal static IEventReader GetReader(byte statusByte)
		{
			if (statusByte == 255)
			{
				return EventReaderFactory._metaEventReader;
			}
			if (statusByte != 247)
			{
				if (statusByte != 240)
				{
					return EventReaderFactory._channelEventReader;
				}
			}
			return EventReaderFactory._sysExEventReader;
		}

		// Token: 0x04000B9C RID: 2972
		private static readonly IEventReader _metaEventReader = new MetaEventReader();

		// Token: 0x04000B9D RID: 2973
		private static readonly IEventReader _channelEventReader = new ChannelEventReader();

		// Token: 0x04000B9E RID: 2974
		private static readonly IEventReader _sysExEventReader = new SysExEventReader();
	}
}
