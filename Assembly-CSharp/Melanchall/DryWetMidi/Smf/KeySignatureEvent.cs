using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000192 RID: 402
	public sealed class KeySignatureEvent : MetaEvent
	{
		// Token: 0x06003326 RID: 13094 RVA: 0x00016FCC File Offset: 0x000151CC
		public KeySignatureEvent()
		{
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x0001712E File Offset: 0x0001532E
		public KeySignatureEvent(sbyte key, byte scale) : this()
		{
			this.Key = key;
			this.Scale = scale;
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06003328 RID: 13096 RVA: 0x00017144 File Offset: 0x00015344
		// (set) Token: 0x06003329 RID: 13097 RVA: 0x0001714C File Offset: 0x0001534C
		public sbyte Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x0600332A RID: 13098 RVA: 0x00017155 File Offset: 0x00015355
		// (set) Token: 0x0600332B RID: 13099 RVA: 0x0001715D File Offset: 0x0001535D
		public byte Scale
		{
			get
			{
				return this._scale;
			}
			set
			{
				this._scale = value;
			}
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x00017166 File Offset: 0x00015366
		private static int ProcessValue(int value, string property, int min, int max, InvalidMetaEventParameterValuePolicy policy)
		{
			if (value >= min && value <= max)
			{
				return value;
			}
			if (policy == InvalidMetaEventParameterValuePolicy.Abort)
			{
				throw new InvalidMetaEventParameterValueException(string.Format("{0} is invalid value for the {1} of a Key Signature event.", value, property), value);
			}
			if (policy != InvalidMetaEventParameterValuePolicy.SnapToLimits)
			{
				return value;
			}
			return Math.Min(Math.Max(value, min), max);
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x00147E64 File Offset: 0x00146064
		protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size)
		{
			InvalidMetaEventParameterValuePolicy invalidMetaEventParameterValuePolicy = settings.InvalidMetaEventParameterValuePolicy;
			this.Key = (sbyte)KeySignatureEvent.ProcessValue((int)reader.ReadSByte(), "Key", -7, 7, invalidMetaEventParameterValuePolicy);
			this.Scale = (byte)KeySignatureEvent.ProcessValue((int)reader.ReadByte(), "Scale", 0, 1, invalidMetaEventParameterValuePolicy);
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x000171A2 File Offset: 0x000153A2
		protected override void WriteContent(MidiWriter writer, WritingSettings settings)
		{
			writer.WriteSByte(this.Key);
			writer.WriteByte(this.Scale);
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x000171BC File Offset: 0x000153BC
		protected override int GetContentSize(WritingSettings settings)
		{
			return 2;
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x000171BF File Offset: 0x000153BF
		protected override MidiEvent CloneEvent()
		{
			return new KeySignatureEvent(this.Key, this.Scale);
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x000171D2 File Offset: 0x000153D2
		public override string ToString()
		{
			return string.Format("Key Signature ({0}, {1})", this.Key, this.Scale);
		}

		// Token: 0x04000B76 RID: 2934
		public const sbyte DefaultKey = 0;

		// Token: 0x04000B77 RID: 2935
		public const byte DefaultScale = 0;

		// Token: 0x04000B78 RID: 2936
		private const sbyte MinKey = -7;

		// Token: 0x04000B79 RID: 2937
		private const sbyte MaxKey = 7;

		// Token: 0x04000B7A RID: 2938
		private const byte MinScale = 0;

		// Token: 0x04000B7B RID: 2939
		private const byte MaxScale = 1;

		// Token: 0x04000B7C RID: 2940
		private sbyte _key;

		// Token: 0x04000B7D RID: 2941
		private byte _scale;
	}
}
