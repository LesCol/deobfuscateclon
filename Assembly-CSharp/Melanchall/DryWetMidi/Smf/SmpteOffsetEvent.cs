using System;
using System.Collections.Generic;
using System.Linq;
using Melanchall.DryWetMidi.Common;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200019B RID: 411
	public sealed class SmpteOffsetEvent : MetaEvent
	{
		// Token: 0x06003366 RID: 13158 RVA: 0x00016FCC File Offset: 0x000151CC
		public SmpteOffsetEvent()
		{
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x0001742D File Offset: 0x0001562D
		public SmpteOffsetEvent(SmpteFormat format, byte hours, byte minutes, byte seconds, byte frames, byte subFrames) : this()
		{
			this.Format = format;
			this.Hours = hours;
			this.Minutes = minutes;
			this.Seconds = seconds;
			this.Frames = frames;
			this.SubFrames = subFrames;
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06003368 RID: 13160 RVA: 0x00017462 File Offset: 0x00015662
		// (set) Token: 0x06003369 RID: 13161 RVA: 0x0001746A File Offset: 0x0001566A
		public SmpteFormat Format { get; set; }

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600336A RID: 13162 RVA: 0x00017473 File Offset: 0x00015673
		// (set) Token: 0x0600336B RID: 13163 RVA: 0x0001747B File Offset: 0x0001567B
		public byte Hours
		{
			get
			{
				return this._hours;
			}
			set
			{
				this._hours = value;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x0600336C RID: 13164 RVA: 0x00017484 File Offset: 0x00015684
		// (set) Token: 0x0600336D RID: 13165 RVA: 0x0001748C File Offset: 0x0001568C
		public byte Minutes
		{
			get
			{
				return this._minutes;
			}
			set
			{
				this._minutes = value;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x0600336E RID: 13166 RVA: 0x00017495 File Offset: 0x00015695
		// (set) Token: 0x0600336F RID: 13167 RVA: 0x0001749D File Offset: 0x0001569D
		public byte Seconds
		{
			get
			{
				return this._seconds;
			}
			set
			{
				this._seconds = value;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06003370 RID: 13168 RVA: 0x000174A6 File Offset: 0x000156A6
		// (set) Token: 0x06003371 RID: 13169 RVA: 0x000174AE File Offset: 0x000156AE
		public byte Frames
		{
			get
			{
				return this._frames;
			}
			set
			{
				byte b = SmpteOffsetEvent.MaxFrames[this.Format];
				this._frames = value;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06003372 RID: 13170 RVA: 0x000174C8 File Offset: 0x000156C8
		// (set) Token: 0x06003373 RID: 13171 RVA: 0x000174D0 File Offset: 0x000156D0
		public byte SubFrames
		{
			get
			{
				return this._subFrames;
			}
			set
			{
				this._subFrames = value;
			}
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x000174D9 File Offset: 0x000156D9
		private static SmpteFormat GetFormat(byte formatAndHours)
		{
			return SmpteOffsetEvent.Formats[(formatAndHours & 96) >> 5];
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x000174EB File Offset: 0x000156EB
		private static byte GetHours(byte formatAndHours)
		{
			return formatAndHours & 31;
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x00147ED0 File Offset: 0x001460D0
		private byte GetFormatAndHours()
		{
			return (byte)(SmpteOffsetEvent.Formats.First((KeyValuePair<int, SmpteFormat> f) => f.Value == this.Format).Key << 5 & (int)this.Hours);
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x000174F2 File Offset: 0x000156F2
		private static byte ProcessValue(byte value, string property, byte max, InvalidMetaEventParameterValuePolicy policy)
		{
			if (value <= max)
			{
				return value;
			}
			if (policy == InvalidMetaEventParameterValuePolicy.Abort)
			{
				throw new InvalidMetaEventParameterValueException(string.Format("{0} is invalid value for the {1} of a SMPTE Offset event.", value, property), (int)value);
			}
			if (policy != InvalidMetaEventParameterValuePolicy.SnapToLimits)
			{
				return value;
			}
			return Math.Min(value, max);
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x00147F08 File Offset: 0x00146108
		protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size)
		{
			InvalidMetaEventParameterValuePolicy invalidMetaEventParameterValuePolicy = settings.InvalidMetaEventParameterValuePolicy;
			byte formatAndHours = reader.ReadByte();
			this.Format = SmpteOffsetEvent.GetFormat(formatAndHours);
			this.Hours = SmpteOffsetEvent.ProcessValue(SmpteOffsetEvent.GetHours(formatAndHours), "Hours", 23, invalidMetaEventParameterValuePolicy);
			this.Minutes = SmpteOffsetEvent.ProcessValue(reader.ReadByte(), "Minutes", 59, invalidMetaEventParameterValuePolicy);
			this.Seconds = SmpteOffsetEvent.ProcessValue(reader.ReadByte(), "Seconds", 59, invalidMetaEventParameterValuePolicy);
			this.Frames = SmpteOffsetEvent.ProcessValue(reader.ReadByte(), "Frames", SmpteOffsetEvent.MaxFrames[this.Format], invalidMetaEventParameterValuePolicy);
			this.SubFrames = SmpteOffsetEvent.ProcessValue(reader.ReadByte(), "SubFrames", 99, invalidMetaEventParameterValuePolicy);
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x00017522 File Offset: 0x00015722
		protected override void WriteContent(MidiWriter writer, WritingSettings settings)
		{
			writer.WriteByte(this.GetFormatAndHours());
			writer.WriteByte(this.Minutes);
			writer.WriteByte(this.Seconds);
			writer.WriteByte(this.Frames);
			writer.WriteByte(this.SubFrames);
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x00017560 File Offset: 0x00015760
		protected override int GetContentSize(WritingSettings settings)
		{
			return 5;
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x00017563 File Offset: 0x00015763
		protected override MidiEvent CloneEvent()
		{
			return new SmpteOffsetEvent(this.Format, this.Hours, this.Minutes, this.Seconds, this.Frames, this.SubFrames);
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x00147FBC File Offset: 0x001461BC
		public override string ToString()
		{
			return string.Format("SMPTE Offset ({0}, {1}:{2}:{3}:{4}:{5})", new object[]
			{
				this.Format,
				this.Hours,
				this.Minutes,
				this.Seconds,
				this.Frames,
				this.SubFrames
			});
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x00148030 File Offset: 0x00146230
		// Note: this type is marked as 'beforefieldinit'.
		static SmpteOffsetEvent()
		{
			Dictionary<SmpteFormat, byte> dictionary = new Dictionary<SmpteFormat, byte>();
			dictionary[SmpteFormat.TwentyFour] = 23;
			dictionary[SmpteFormat.TwentyFive] = 24;
			dictionary[SmpteFormat.ThirtyDrop] = 28;
			dictionary[SmpteFormat.Thirty] = 29;
			SmpteOffsetEvent.MaxFrames = dictionary;
			Dictionary<int, SmpteFormat> dictionary2 = new Dictionary<int, SmpteFormat>();
			dictionary2[0] = SmpteFormat.TwentyFour;
			dictionary2[1] = SmpteFormat.TwentyFive;
			dictionary2[2] = SmpteFormat.ThirtyDrop;
			dictionary2[3] = SmpteFormat.Thirty;
			SmpteOffsetEvent.Formats = dictionary2;
		}

		// Token: 0x04000B83 RID: 2947
		public const byte MaxHours = 23;

		// Token: 0x04000B84 RID: 2948
		public const byte MaxMinutes = 59;

		// Token: 0x04000B85 RID: 2949
		public const byte MaxSeconds = 59;

		// Token: 0x04000B86 RID: 2950
		public const byte MaxSubFrames = 99;

		// Token: 0x04000B87 RID: 2951
		private static readonly Dictionary<SmpteFormat, byte> MaxFrames;

		// Token: 0x04000B88 RID: 2952
		private const int FormatMask = 96;

		// Token: 0x04000B89 RID: 2953
		private const int FormatOffset = 5;

		// Token: 0x04000B8A RID: 2954
		private const int HoursMask = 31;

		// Token: 0x04000B8B RID: 2955
		private static readonly Dictionary<int, SmpteFormat> Formats;

		// Token: 0x04000B8C RID: 2956
		private byte _hours;

		// Token: 0x04000B8D RID: 2957
		private byte _minutes;

		// Token: 0x04000B8E RID: 2958
		private byte _seconds;

		// Token: 0x04000B8F RID: 2959
		private byte _frames;

		// Token: 0x04000B90 RID: 2960
		private byte _subFrames;
	}
}
