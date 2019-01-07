using System;
using System.Runtime.Serialization;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001AB RID: 427
	[Serializable]
	public sealed class InvalidChannelEventParameterValueException : MidiException
	{
		// Token: 0x060033C4 RID: 13252 RVA: 0x00017817 File Offset: 0x00015A17
		public InvalidChannelEventParameterValueException()
		{
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x0001781F File Offset: 0x00015A1F
		public InvalidChannelEventParameterValueException(string message, byte value) : base(message)
		{
			this.Value = value;
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x0001782F File Offset: 0x00015A2F
		private InvalidChannelEventParameterValueException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.Value = info.GetByte("Value");
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060033C7 RID: 13255 RVA: 0x0001784A File Offset: 0x00015A4A
		public byte Value { get; }

		// Token: 0x060033C8 RID: 13256 RVA: 0x00017852 File Offset: 0x00015A52
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Value", this.Value);
			base.GetObjectData(info, context);
		}

		// Token: 0x04000BA2 RID: 2978
		private const string ValueSerializationPropertyName = "Value";
	}
}
