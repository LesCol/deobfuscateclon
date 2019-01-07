using System;
using System.Text;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001C5 RID: 453
	public class ReadingSettings
	{
		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06003437 RID: 13367 RVA: 0x00017EC2 File Offset: 0x000160C2
		// (set) Token: 0x06003438 RID: 13368 RVA: 0x00017ECA File Offset: 0x000160CA
		public UnexpectedTrackChunksCountPolicy UnexpectedTrackChunksCountPolicy { get; set; }

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06003439 RID: 13369 RVA: 0x00017ED3 File Offset: 0x000160D3
		// (set) Token: 0x0600343A RID: 13370 RVA: 0x00017EDB File Offset: 0x000160DB
		public ExtraTrackChunkPolicy ExtraTrackChunkPolicy { get; set; }

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600343B RID: 13371 RVA: 0x00017EE4 File Offset: 0x000160E4
		// (set) Token: 0x0600343C RID: 13372 RVA: 0x00017EEC File Offset: 0x000160EC
		public UnknownChunkIdPolicy UnknownChunkIdPolicy { get; set; }

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x0600343D RID: 13373 RVA: 0x00017EF5 File Offset: 0x000160F5
		// (set) Token: 0x0600343E RID: 13374 RVA: 0x00017EFD File Offset: 0x000160FD
		public MissedEndOfTrackPolicy MissedEndOfTrackPolicy { get; set; }

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x0600343F RID: 13375 RVA: 0x00017F06 File Offset: 0x00016106
		// (set) Token: 0x06003440 RID: 13376 RVA: 0x00017F0E File Offset: 0x0001610E
		public SilentNoteOnPolicy SilentNoteOnPolicy { get; set; }

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06003441 RID: 13377 RVA: 0x00017F17 File Offset: 0x00016117
		// (set) Token: 0x06003442 RID: 13378 RVA: 0x00017F1F File Offset: 0x0001611F
		public InvalidChunkSizePolicy InvalidChunkSizePolicy { get; set; }

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06003443 RID: 13379 RVA: 0x00017F28 File Offset: 0x00016128
		// (set) Token: 0x06003444 RID: 13380 RVA: 0x00017F30 File Offset: 0x00016130
		public UnknownFileFormatPolicy UnknownFileFormatPolicy { get; set; }

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06003445 RID: 13381 RVA: 0x00017F39 File Offset: 0x00016139
		// (set) Token: 0x06003446 RID: 13382 RVA: 0x00017F41 File Offset: 0x00016141
		public InvalidChannelEventParameterValuePolicy InvalidChannelEventParameterValuePolicy { get; set; }

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06003447 RID: 13383 RVA: 0x00017F4A File Offset: 0x0001614A
		// (set) Token: 0x06003448 RID: 13384 RVA: 0x00017F52 File Offset: 0x00016152
		public InvalidMetaEventParameterValuePolicy InvalidMetaEventParameterValuePolicy { get; set; }

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06003449 RID: 13385 RVA: 0x00017F5B File Offset: 0x0001615B
		// (set) Token: 0x0600344A RID: 13386 RVA: 0x00017F63 File Offset: 0x00016163
		public NotEnoughBytesPolicy NotEnoughBytesPolicy { get; set; }

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600344B RID: 13387 RVA: 0x00017F6C File Offset: 0x0001616C
		// (set) Token: 0x0600344C RID: 13388 RVA: 0x00017F74 File Offset: 0x00016174
		public NoHeaderChunkPolicy NoHeaderChunkPolicy { get; set; }

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x0600344D RID: 13389 RVA: 0x00017F7D File Offset: 0x0001617D
		// (set) Token: 0x0600344E RID: 13390 RVA: 0x00017F85 File Offset: 0x00016185
		public ChunkTypesCollection CustomChunkTypes { get; set; }

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600344F RID: 13391 RVA: 0x00017F8E File Offset: 0x0001618E
		// (set) Token: 0x06003450 RID: 13392 RVA: 0x00017F96 File Offset: 0x00016196
		public EventTypesCollection CustomMetaEventTypes { get; set; }

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06003451 RID: 13393 RVA: 0x00017F9F File Offset: 0x0001619F
		// (set) Token: 0x06003452 RID: 13394 RVA: 0x00017FA7 File Offset: 0x000161A7
		public Encoding TextEncoding { get; set; } = SmfUtilities.DefaultEncoding;
	}
}
