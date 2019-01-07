using System;
using System.Runtime.Serialization;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001AD RID: 429
	[Serializable]
	public sealed class InvalidMetaEventParameterValueException : MidiException
	{
		// Token: 0x060033CF RID: 13263 RVA: 0x00017817 File Offset: 0x00015A17
		public InvalidMetaEventParameterValueException()
		{
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x000178F8 File Offset: 0x00015AF8
		public InvalidMetaEventParameterValueException(string message, int value) : base(message)
		{
			this.Value = value;
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x00017908 File Offset: 0x00015B08
		private InvalidMetaEventParameterValueException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.Value = info.GetInt32("Value");
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060033D2 RID: 13266 RVA: 0x00017923 File Offset: 0x00015B23
		public int Value { get; }

		// Token: 0x060033D3 RID: 13267 RVA: 0x0001792B File Offset: 0x00015B2B
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Value", this.Value);
			base.GetObjectData(info, context);
		}

		// Token: 0x04000BA8 RID: 2984
		private const string ValueSerializationPropertyName = "Value";
	}
}
