using System;
using UnityEngine;

// Token: 0x02000045 RID: 69
public class GameSetting
{
	// Token: 0x1700002F RID: 47
	// (get) Token: 0x06000C86 RID: 3206 RVA: 0x00007151 File Offset: 0x00005351
	// (set) Token: 0x06000C54 RID: 3156 RVA: 0x000070C3 File Offset: 0x000052C3
	public int CurrentValue
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = Mathf.Clamp(value, this.int_2, this.int_1);
		}
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x000070DD File Offset: 0x000052DD
	public bool method_0()
	{
		return this.int_0 == this.int_3;
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x000070ED File Offset: 0x000052ED
	public string method_1()
	{
		return this.int_0 + "Unknown Charter";
	}

	// Token: 0x17000028 RID: 40
	// (set) Token: 0x06000C57 RID: 3159 RVA: 0x00007104 File Offset: 0x00005304
	public int Int32_0
	{
		set
		{
			this.int_1 = value;
			this.method_22();
		}
	}

	// Token: 0x06000C58 RID: 3160 RVA: 0x00007113 File Offset: 0x00005313
	public void method_2()
	{
		this.int_0 += this.int_4;
		this.method_20();
	}

	// Token: 0x06000C59 RID: 3161 RVA: 0x000070C3 File Offset: 0x000052C3
	public void method_3(int int_5)
	{
		this.int_0 = Mathf.Clamp(int_5, this.int_2, this.int_1);
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0000712E File Offset: 0x0000532E
	public GClass10.GEnum7 GEnum7_0
	{
		get
		{
			return (GClass10.GEnum7)this.int_0;
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000C5B RID: 3163 RVA: 0x00007137 File Offset: 0x00005337
	public int Int32_2
	{
		get
		{
			return (int)(this.Single_1 * 100f);
		}
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x00007146 File Offset: 0x00005346
	public bool method_4()
	{
		return this.int_0 == 0;
	}

	// Token: 0x06000C5D RID: 3165 RVA: 0x00007151 File Offset: 0x00005351
	public int method_5()
	{
		return this.int_0;
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x000070DD File Offset: 0x000052DD
	public bool method_6()
	{
		return this.int_0 == this.int_3;
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00007159 File Offset: 0x00005359
	public float Single_2
	{
		get
		{
			return (float)this.int_0 / 1000f;
		}
	}

	// Token: 0x06000C60 RID: 3168 RVA: 0x00007168 File Offset: 0x00005368
	public void method_7()
	{
		this.int_0 += this.int_4;
		this.method_22();
	}

	// Token: 0x06000C61 RID: 3169 RVA: 0x00007146 File Offset: 0x00005346
	public static bool smethod_0(GameSetting gclass5_0)
	{
		return gclass5_0.int_0 == 0;
	}

	// Token: 0x06000C62 RID: 3170 RVA: 0x00007183 File Offset: 0x00005383
	public int method_8()
	{
		return (int)(this.Single_1 * 134f);
	}

	// Token: 0x06000C63 RID: 3171 RVA: 0x00007192 File Offset: 0x00005392
	public string method_9()
	{
		return GClass4.gclass4_0.method_11((this.int_0 == 0) ? "No Part" : "Game Manager");
	}

	// Token: 0x06000C64 RID: 3172 RVA: 0x00007146 File Offset: 0x00005346
	public static bool smethod_1(GameSetting gclass5_0)
	{
		return gclass5_0.int_0 == 0;
	}

	// Token: 0x17000029 RID: 41
	// (set) Token: 0x06000C65 RID: 3173 RVA: 0x000071B3 File Offset: 0x000053B3
	public int Int32_1
	{
		set
		{
			this.int_2 = value;
			this.method_22();
		}
	}

	// Token: 0x06000C66 RID: 3174 RVA: 0x000071C2 File Offset: 0x000053C2
	public GameSetting(int int_5, int int_6, int int_7, int int_8, int int_9)
	{
		this.int_0 = int_5;
		this.int_3 = int_6;
		this.int_2 = int_7;
		this.int_1 = int_8;
		this.int_4 = int_9;
		this.method_22();
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x000071F5 File Offset: 0x000053F5
	public string method_10()
	{
		return GClass4.gclass4_0.method_38((this.int_0 == 1) ? "/preview" : "/");
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x0000712E File Offset: 0x0000532E
	public GClass10.GEnum7 method_11()
	{
		return (GClass10.GEnum7)this.int_0;
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x00007216 File Offset: 0x00005416
	public void method_12(int int_5)
	{
		this.int_1 = int_5;
		this.method_13();
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x06000C6A RID: 3178 RVA: 0x000070DD File Offset: 0x000052DD
	public bool Boolean_0
	{
		get
		{
			return this.int_0 == this.int_3;
		}
	}

	// Token: 0x06000C6B RID: 3179 RVA: 0x00007225 File Offset: 0x00005425
	public static bool smethod_2(GameSetting gclass5_0)
	{
		return gclass5_0.int_0 == 1;
	}

	// Token: 0x06000C6C RID: 3180 RVA: 0x00007230 File Offset: 0x00005430
	public GameSetting(bool bool_0, bool bool_1)
	{
		this.int_0 = (bool_0 ? 1 : 0);
		this.int_3 = (bool_1 ? 1 : 0);
		this.int_2 = 0;
		this.int_1 = 1;
		this.int_4 = 1;
	}

	// Token: 0x06000C6D RID: 3181 RVA: 0x00007267 File Offset: 0x00005467
	public void method_13()
	{
		this.int_0 = Mathf.Clamp(this.int_0, this.int_2, this.int_1);
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000C6E RID: 3182 RVA: 0x00007286 File Offset: 0x00005486
	public float Single_1
	{
		get
		{
			return (float)Math.Pow((double)this.int_0 / 100.0, 1.53);
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000C6F RID: 3183 RVA: 0x000072A8 File Offset: 0x000054A8
	public float Single_0
	{
		get
		{
			return (float)this.int_0 / 100f;
		}
	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x00007225 File Offset: 0x00005425
	public bool method_14()
	{
		return this.int_0 == 1;
	}

	// Token: 0x06000C71 RID: 3185 RVA: 0x000072B7 File Offset: 0x000054B7
	public void method_15()
	{
		this.int_0 -= this.int_4;
		this.method_22();
	}

	// Token: 0x06000C72 RID: 3186 RVA: 0x00007216 File Offset: 0x00005416
	public void method_16(int int_5)
	{
		this.int_1 = int_5;
		this.method_13();
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x06000C73 RID: 3187 RVA: 0x000072D2 File Offset: 0x000054D2
	public string String_2
	{
		get
		{
			return this.int_0.ToString();
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x06000C74 RID: 3188 RVA: 0x000072DF File Offset: 0x000054DF
	public string String_1
	{
		get
		{
			return this.int_0 + "%";
		}
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x000072F6 File Offset: 0x000054F6
	public void method_17()
	{
		this.int_0 = this.int_3;
		this.method_22();
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x0000730A File Offset: 0x0000550A
	public int method_18()
	{
		return (int)(this.Single_1 * 179f);
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00007225 File Offset: 0x00005425
	public bool Boolean_1
	{
		get
		{
			return this.int_0 == 1;
		}
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x00007319 File Offset: 0x00005519
	public void method_19()
	{
		this.int_0 -= this.int_4;
		this.method_13();
	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x00007267 File Offset: 0x00005467
	public void method_20()
	{
		this.int_0 = Mathf.Clamp(this.int_0, this.int_2, this.int_1);
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x00007334 File Offset: 0x00005534
	public void method_21(int int_5)
	{
		this.int_2 = int_5;
		this.method_20();
	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x00007225 File Offset: 0x00005425
	public static bool smethod_3(GameSetting gclass5_0)
	{
		return gclass5_0.int_0 == 1;
	}

	// Token: 0x06000C7C RID: 3196 RVA: 0x00007146 File Offset: 0x00005346
	public static bool smethod_4(GameSetting gclass5_0)
	{
		return gclass5_0.int_0 == 0;
	}

	// Token: 0x06000C7D RID: 3197 RVA: 0x00007267 File Offset: 0x00005467
	public void method_22()
	{
		this.int_0 = Mathf.Clamp(this.int_0, this.int_2, this.int_1);
	}

	// Token: 0x06000C7E RID: 3198 RVA: 0x000070DD File Offset: 0x000052DD
	public bool method_23()
	{
		return this.int_0 == this.int_3;
	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x00007343 File Offset: 0x00005543
	public float method_24()
	{
		return (float)Math.Pow((double)this.int_0 / 625.0, 93.0);
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x00007225 File Offset: 0x00005425
	public static bool smethod_5(GameSetting gclass5_0)
	{
		return gclass5_0.int_0 == 1;
	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x00007151 File Offset: 0x00005351
	public int method_25()
	{
		return this.int_0;
	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x00007365 File Offset: 0x00005565
	public string method_26()
	{
		return this.int_0 + "version";
	}

	// Token: 0x06000C83 RID: 3203 RVA: 0x000072B7 File Offset: 0x000054B7
	public void method_27()
	{
		this.int_0 -= this.int_4;
		this.method_22();
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000C84 RID: 3204 RVA: 0x0000737C File Offset: 0x0000557C
	public string String_3
	{
		get
		{
			return this.int_0 + "ms";
		}
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x00007393 File Offset: 0x00005593
	public string method_28()
	{
		return this.int_0 + "^\\s*\\d+ = S 2 \\d+$";
	}

	// Token: 0x06000C87 RID: 3207 RVA: 0x00007168 File Offset: 0x00005368
	public void method_29()
	{
		this.int_0 += this.int_4;
		this.method_22();
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x06000C88 RID: 3208 RVA: 0x000073AA File Offset: 0x000055AA
	public string String_0
	{
		get
		{
			return GClass4.gclass4_0.method_13((this.int_0 == 1) ? "Enabled" : "Disabled");
		}
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x00007225 File Offset: 0x00005425
	public bool method_30()
	{
		return this.int_0 == 1;
	}

	// Token: 0x04000206 RID: 518
	private int int_0;

	// Token: 0x04000207 RID: 519
	private int int_1;

	// Token: 0x04000208 RID: 520
	private int int_2;

	// Token: 0x04000209 RID: 521
	private int int_3;

	// Token: 0x0400020A RID: 522
	private int int_4;
}
