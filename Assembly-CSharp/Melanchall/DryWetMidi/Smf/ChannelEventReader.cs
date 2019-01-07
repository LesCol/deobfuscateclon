using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200019F RID: 415
	internal sealed class ChannelEventReader : IEventReader
	{
		// Token: 0x0600339D RID: 13213 RVA: 0x001481BC File Offset: 0x001463BC
		public MidiEvent Read(MidiReader reader, ReadingSettings settings, byte currentStatusByte)
		{
			FourBitNumber head = currentStatusByte.GetHead();
			FourBitNumber tail = currentStatusByte.GetTail();
			string typeName;
			if (!StandardEventTypes.Channel.TryGetType(head, out typeName))
			{
				throw new UnknownChannelEventException(head, tail);
			}
			ChannelEvent @event = this.GetEvent(typeName);
			@event.Read(reader, settings, -1);
			@event.Channel = tail;
			return @event;
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x0014820C File Offset: 0x0014640C
		private ChannelEvent GetEvent(string typeName)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(typeName);
			if (num <= 1945283691u)
			{
				if (num != 173811632u)
				{
					if (num != 863078502u)
					{
						if (num == 1945283691u)
						{
							if (typeName == "ChannelAftertouchEvent")
							{
								return new ChannelAftertouchEvent();
							}
						}
					}
					else if (typeName == "ControlChangeEvent")
					{
						return new ControlChangeEvent();
					}
				}
				else if (typeName == "NoteOnEvent")
				{
					return new NoteOnEvent();
				}
			}
			else if (num <= 3076218765u)
			{
				if (num != 2316233374u)
				{
					if (num == 3076218765u)
					{
						if (typeName == "ProgramChangeEvent")
						{
							return new ProgramChangeEvent();
						}
					}
				}
				else if (typeName == "NoteOffEvent")
				{
					return new NoteOffEvent();
				}
			}
			else if (num != 3127144588u)
			{
				if (num == 3994110234u)
				{
					if (typeName == "PitchBendEvent")
					{
						return new PitchBendEvent();
					}
				}
			}
			else if (typeName == "NoteAftertouchEvent")
			{
				return new NoteAftertouchEvent();
			}
			return null;
		}
	}
}
