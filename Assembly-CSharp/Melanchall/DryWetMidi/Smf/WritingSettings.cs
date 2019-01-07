using System;
using System.Text;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001D6 RID: 470
	public class WritingSettings
	{
		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x0600348E RID: 13454 RVA: 0x000182AB File Offset: 0x000164AB
		// (set) Token: 0x0600348F RID: 13455 RVA: 0x000182B3 File Offset: 0x000164B3
		public CompressionPolicy CompressionPolicy { get; set; }

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06003490 RID: 13456 RVA: 0x000182BC File Offset: 0x000164BC
		// (set) Token: 0x06003491 RID: 13457 RVA: 0x000182C4 File Offset: 0x000164C4
		public EventTypesCollection CustomMetaEventTypes { get; set; }

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06003492 RID: 13458 RVA: 0x000182CD File Offset: 0x000164CD
		// (set) Token: 0x06003493 RID: 13459 RVA: 0x000182D5 File Offset: 0x000164D5
		public Encoding TextEncoding { get; set; } = SmfUtilities.DefaultEncoding;
	}
}
