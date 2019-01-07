using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200018F RID: 399
	public sealed class DeviceNameEvent : BaseTextEvent
	{
		// Token: 0x06003318 RID: 13080 RVA: 0x0001707F File Offset: 0x0001527F
		public DeviceNameEvent()
		{
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x00017087 File Offset: 0x00015287
		public DeviceNameEvent(string deviceName) : base(deviceName)
		{
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x000170D8 File Offset: 0x000152D8
		protected override MidiEvent CloneEvent()
		{
			return new DeviceNameEvent(base.Text);
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x000170E5 File Offset: 0x000152E5
		public override string ToString()
		{
			return "Device Name (" + base.Text + ")";
		}
	}
}
