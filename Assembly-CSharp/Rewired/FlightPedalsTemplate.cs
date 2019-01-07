using System;

namespace Rewired
{
	// Token: 0x020000E9 RID: 233
	public sealed class FlightPedalsTemplate : ControllerTemplate, IControllerTemplate, IFlightPedalsTemplate
	{
		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06002C3C RID: 11324 RVA: 0x00011DFF File Offset: 0x0000FFFF
		IControllerTemplateAxis IFlightPedalsTemplate.leftPedal
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(0);
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06002C3D RID: 11325 RVA: 0x00011E08 File Offset: 0x00010008
		IControllerTemplateAxis IFlightPedalsTemplate.rightPedal
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(1);
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06002C3E RID: 11326 RVA: 0x00011E11 File Offset: 0x00010011
		IControllerTemplateAxis IFlightPedalsTemplate.slide
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(2);
			}
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x00011DE5 File Offset: 0x0000FFE5
		public FlightPedalsTemplate(object payload) : base(payload)
		{
		}

		// Token: 0x04000809 RID: 2057
		public static readonly Guid typeGuid = new Guid("f6fe76f8-be2a-4db2-b853-9e3652075913");

		// Token: 0x0400080A RID: 2058
		public const int elementId_leftPedal = 0;

		// Token: 0x0400080B RID: 2059
		public const int elementId_rightPedal = 1;

		// Token: 0x0400080C RID: 2060
		public const int elementId_slide = 2;
	}
}
