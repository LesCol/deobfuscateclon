using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001A3 RID: 419
	internal sealed class SysExEventReader : IEventReader
	{
		// Token: 0x060033A7 RID: 13223 RVA: 0x00148610 File Offset: 0x00146810
		public MidiEvent Read(MidiReader reader, ReadingSettings settings, byte currentStatusByte)
		{
			int size = reader.ReadVlqNumber();
			string typeName;
			SysExEvent sysExEvent = StandardEventTypes.SysEx.TryGetType(currentStatusByte, out typeName) ? this.GetEvent(typeName) : null;
			sysExEvent.Read(reader, settings, size);
			return sysExEvent;
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x0001776E File Offset: 0x0001596E
		private SysExEvent GetEvent(string typeName)
		{
			if (typeName == "EscapeSysExEvent")
			{
				return new EscapeSysExEvent();
			}
			if (!(typeName == "NormalSysExEvent"))
			{
				return null;
			}
			return new NormalSysExEvent();
		}
	}
}
