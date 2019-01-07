using System;
using System.Collections.Generic;

// Token: 0x020001E9 RID: 489
public class SPActivations
{
	// Token: 0x04000CA1 RID: 3233
	public static List<double> activateTimes = new List<double>();

	// Token: 0x04000CA2 RID: 3234
	public static List<double> squeezeTimes = new List<double>();

	// Token: 0x04000CA3 RID: 3235
	public static List<double> activateNoSqueeze = new List<double>();

	// Token: 0x04000CA4 RID: 3236
	public static List<double> lateHitBitch = new List<double>();

	// Token: 0x04000CA5 RID: 3237
	public static List<double> increaseWindow = new List<double>();

	// Token: 0x04000CA6 RID: 3238
	public static List<double> decreaseWindow = new List<double>();

	// Token: 0x04000CA7 RID: 3239
	public static int squeezeNumber = 0;

	// Token: 0x04000CA8 RID: 3240
	public static int totalDecreaseWindows = 0;

	// Token: 0x04000CA9 RID: 3241
	public static int totalIncreaseWindows = 0;

	// Token: 0x04000CAA RID: 3242
	public static int totalLateHitBitches = 0;

	// Token: 0x04000CAB RID: 3243
	public static int totalActivateNoSqueezes = 0;

	// Token: 0x04000CAC RID: 3244
	public static int totalActivations = 0;

	// Token: 0x04000CAD RID: 3245
	public static int totalSqueezes = 0;
}
