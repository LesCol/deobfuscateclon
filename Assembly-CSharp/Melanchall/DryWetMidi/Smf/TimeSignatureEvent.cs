using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200019D RID: 413
	public sealed class TimeSignatureEvent : MetaEvent
	{
		// Token: 0x06003383 RID: 13187 RVA: 0x000175C3 File Offset: 0x000157C3
		public TimeSignatureEvent()
		{
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x000175E8 File Offset: 0x000157E8
		public TimeSignatureEvent(byte numerator, byte denominator) : this(numerator, denominator, 24, 8)
		{
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x000175F5 File Offset: 0x000157F5
		public TimeSignatureEvent(byte numerator, byte denominator, byte clocksPerClick, byte numberOf32ndNotesPerBeat) : this()
		{
			this.Numerator = numerator;
			this.Denominator = denominator;
			this.ClocksPerClick = clocksPerClick;
			this.NumberOf32ndNotesPerBeat = numberOf32ndNotesPerBeat;
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06003386 RID: 13190 RVA: 0x0001761A File Offset: 0x0001581A
		// (set) Token: 0x06003387 RID: 13191 RVA: 0x00017622 File Offset: 0x00015822
		public byte Numerator { get; set; } = 4;

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06003388 RID: 13192 RVA: 0x0001762B File Offset: 0x0001582B
		// (set) Token: 0x06003389 RID: 13193 RVA: 0x00017633 File Offset: 0x00015833
		public byte Denominator
		{
			get
			{
				return this._denominator;
			}
			set
			{
				this._denominator = value;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x0600338A RID: 13194 RVA: 0x0001763C File Offset: 0x0001583C
		// (set) Token: 0x0600338B RID: 13195 RVA: 0x00017644 File Offset: 0x00015844
		public byte ClocksPerClick { get; set; } = 24;

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x0600338C RID: 13196 RVA: 0x0001764D File Offset: 0x0001584D
		// (set) Token: 0x0600338D RID: 13197 RVA: 0x00017655 File Offset: 0x00015855
		public byte NumberOf32ndNotesPerBeat { get; set; } = 8;

		// Token: 0x0600338E RID: 13198 RVA: 0x001480A0 File Offset: 0x001462A0
		protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size)
		{
			this.Numerator = reader.ReadByte();
			this.Denominator = (byte)Math.Pow(2.0, (double)reader.ReadByte());
			if (size >= 4)
			{
				this.ClocksPerClick = reader.ReadByte();
				this.NumberOf32ndNotesPerBeat = reader.ReadByte();
			}
		}

		// Token: 0x0600338F RID: 13199 RVA: 0x001480F4 File Offset: 0x001462F4
		protected override void WriteContent(MidiWriter writer, WritingSettings settings)
		{
			writer.WriteByte(this.Numerator);
			writer.WriteByte((byte)Math.Log((double)this.Denominator, 2.0));
			writer.WriteByte(this.ClocksPerClick);
			writer.WriteByte(this.NumberOf32ndNotesPerBeat);
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x0001765E File Offset: 0x0001585E
		protected override int GetContentSize(WritingSettings settings)
		{
			return 4;
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x00017661 File Offset: 0x00015861
		protected override MidiEvent CloneEvent()
		{
			return new TimeSignatureEvent(this.Numerator, this.Denominator, this.ClocksPerClick, this.NumberOf32ndNotesPerBeat);
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x00148144 File Offset: 0x00146344
		public override string ToString()
		{
			return string.Format("Time Signature ({0}/{1}, {2} clock/click, {3} 32nd/beat)", new object[]
			{
				this.Numerator,
				this.Denominator,
				this.ClocksPerClick,
				this.NumberOf32ndNotesPerBeat
			});
		}

		// Token: 0x04000B92 RID: 2962
		public const byte DefaultNumerator = 4;

		// Token: 0x04000B93 RID: 2963
		public const byte DefaultDenominator = 4;

		// Token: 0x04000B94 RID: 2964
		public const byte DefaultClocksPerClick = 24;

		// Token: 0x04000B95 RID: 2965
		public const byte Default32ndNotesPerBeat = 8;

		// Token: 0x04000B96 RID: 2966
		private byte _denominator = 4;
	}
}
