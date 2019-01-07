using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000177 RID: 375
	public abstract class ChannelEvent : MidiEvent
	{
		// Token: 0x060032A6 RID: 12966 RVA: 0x00016BC9 File Offset: 0x00014DC9
		protected ChannelEvent(int parametersCount)
		{
			if (parametersCount < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			this._parameters = new SevenBitNumber[parametersCount];
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060032A7 RID: 12967 RVA: 0x00016BE7 File Offset: 0x00014DE7
		// (set) Token: 0x060032A8 RID: 12968 RVA: 0x00016BEF File Offset: 0x00014DEF
		public FourBitNumber Channel { get; set; }

		// Token: 0x17000442 RID: 1090
		protected SevenBitNumber this[int index]
		{
			get
			{
				return this._parameters[index];
			}
			set
			{
				this._parameters[index] = value;
			}
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x00147A34 File Offset: 0x00145C34
		internal sealed override void Read(MidiReader reader, ReadingSettings settings, int size)
		{
			for (int i = 0; i < this._parameters.Length; i++)
			{
				byte b = reader.ReadByte();
				if (b > SevenBitNumber.MaxValue)
				{
					switch (settings.InvalidChannelEventParameterValuePolicy)
					{
					case InvalidChannelEventParameterValuePolicy.Abort:
						throw new InvalidChannelEventParameterValueException(string.Format("{0} is invalid value for channel event's parameter.", b), b);
					case InvalidChannelEventParameterValuePolicy.ReadValid:
						b &= SevenBitNumber.MaxValue;
						break;
					case InvalidChannelEventParameterValuePolicy.SnapToLimits:
						b = SevenBitNumber.MaxValue;
						break;
					}
				}
				this._parameters[i] = (SevenBitNumber)b;
			}
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x00147ACC File Offset: 0x00145CCC
		internal sealed override void Write(MidiWriter writer, WritingSettings settings)
		{
			foreach (SevenBitNumber number in this._parameters)
			{
				writer.WriteByte(number);
			}
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x00016C15 File Offset: 0x00014E15
		internal sealed override int GetSize(WritingSettings settings)
		{
			return this._parameters.Length;
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x00147B04 File Offset: 0x00145D04
		protected sealed override MidiEvent CloneEvent()
		{
			ChannelEvent channelEvent = (ChannelEvent)Activator.CreateInstance(base.GetType());
			channelEvent.Channel = this.Channel;
			Array.Copy(this._parameters, channelEvent._parameters, this._parameters.Length);
			return channelEvent;
		}

		// Token: 0x04000B37 RID: 2871
		private readonly SevenBitNumber[] _parameters;
	}
}
