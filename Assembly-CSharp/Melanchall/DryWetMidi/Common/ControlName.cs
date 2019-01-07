using System;

namespace Melanchall.DryWetMidi.Common
{
	// Token: 0x020001D7 RID: 471
	public enum ControlName : byte
	{
		// Token: 0x04000C1B RID: 3099
		BankSelect,
		// Token: 0x04000C1C RID: 3100
		Modulation,
		// Token: 0x04000C1D RID: 3101
		BreathController,
		// Token: 0x04000C1E RID: 3102
		FootController = 4,
		// Token: 0x04000C1F RID: 3103
		PortamentoTime,
		// Token: 0x04000C20 RID: 3104
		DataEntryMsb,
		// Token: 0x04000C21 RID: 3105
		ChannelVolume,
		// Token: 0x04000C22 RID: 3106
		Balance,
		// Token: 0x04000C23 RID: 3107
		Pan = 10,
		// Token: 0x04000C24 RID: 3108
		ExpressionController,
		// Token: 0x04000C25 RID: 3109
		EffectControl1,
		// Token: 0x04000C26 RID: 3110
		EffectControl2,
		// Token: 0x04000C27 RID: 3111
		GeneralPurposeController1 = 16,
		// Token: 0x04000C28 RID: 3112
		GeneralPurposeController2,
		// Token: 0x04000C29 RID: 3113
		GeneralPurposeController3,
		// Token: 0x04000C2A RID: 3114
		GeneralPurposeController4,
		// Token: 0x04000C2B RID: 3115
		LsbForBankSelect = 32,
		// Token: 0x04000C2C RID: 3116
		LsbForModulation,
		// Token: 0x04000C2D RID: 3117
		LsbForBreathController,
		// Token: 0x04000C2E RID: 3118
		LsbForController3,
		// Token: 0x04000C2F RID: 3119
		LsbForFootController,
		// Token: 0x04000C30 RID: 3120
		LsbForPortamentoTime,
		// Token: 0x04000C31 RID: 3121
		LsbForDataEntry,
		// Token: 0x04000C32 RID: 3122
		LsbForChannelVolume,
		// Token: 0x04000C33 RID: 3123
		LsbForBalance,
		// Token: 0x04000C34 RID: 3124
		LsbForController9,
		// Token: 0x04000C35 RID: 3125
		LsbForPan,
		// Token: 0x04000C36 RID: 3126
		LsbForExpressionController,
		// Token: 0x04000C37 RID: 3127
		LsbForEffectControl1,
		// Token: 0x04000C38 RID: 3128
		LsbForEffectControl2,
		// Token: 0x04000C39 RID: 3129
		LsbForController14,
		// Token: 0x04000C3A RID: 3130
		LsbForController15,
		// Token: 0x04000C3B RID: 3131
		LsbForGeneralPurposeController1,
		// Token: 0x04000C3C RID: 3132
		LsbForGeneralPurposeController2,
		// Token: 0x04000C3D RID: 3133
		LsbForGeneralPurposeController3,
		// Token: 0x04000C3E RID: 3134
		LsbForGeneralPurposeController4,
		// Token: 0x04000C3F RID: 3135
		LsbForController20,
		// Token: 0x04000C40 RID: 3136
		LsbForController21,
		// Token: 0x04000C41 RID: 3137
		LsbForController22,
		// Token: 0x04000C42 RID: 3138
		LsbForController23,
		// Token: 0x04000C43 RID: 3139
		LsbForController24,
		// Token: 0x04000C44 RID: 3140
		LsbForController25,
		// Token: 0x04000C45 RID: 3141
		LsbForController26,
		// Token: 0x04000C46 RID: 3142
		LsbForController27,
		// Token: 0x04000C47 RID: 3143
		LsbForController28,
		// Token: 0x04000C48 RID: 3144
		LsbForController29,
		// Token: 0x04000C49 RID: 3145
		LsbForController30,
		// Token: 0x04000C4A RID: 3146
		LsbForController31,
		// Token: 0x04000C4B RID: 3147
		DamperPedal,
		// Token: 0x04000C4C RID: 3148
		Portamento,
		// Token: 0x04000C4D RID: 3149
		Sostenuto,
		// Token: 0x04000C4E RID: 3150
		SoftPedal,
		// Token: 0x04000C4F RID: 3151
		LegatoFootswitch,
		// Token: 0x04000C50 RID: 3152
		Hold2,
		// Token: 0x04000C51 RID: 3153
		SoundController1,
		// Token: 0x04000C52 RID: 3154
		SoundController2,
		// Token: 0x04000C53 RID: 3155
		SoundController3,
		// Token: 0x04000C54 RID: 3156
		SoundController4,
		// Token: 0x04000C55 RID: 3157
		SoundController5,
		// Token: 0x04000C56 RID: 3158
		SoundController6,
		// Token: 0x04000C57 RID: 3159
		SoundController7,
		// Token: 0x04000C58 RID: 3160
		SoundController8,
		// Token: 0x04000C59 RID: 3161
		SoundController9,
		// Token: 0x04000C5A RID: 3162
		SoundController10,
		// Token: 0x04000C5B RID: 3163
		GeneralPurposeController5,
		// Token: 0x04000C5C RID: 3164
		GeneralPurposeController6,
		// Token: 0x04000C5D RID: 3165
		GeneralPurposeController7,
		// Token: 0x04000C5E RID: 3166
		GeneralPurposeController8,
		// Token: 0x04000C5F RID: 3167
		PortamentoControl,
		// Token: 0x04000C60 RID: 3168
		HighResolutionVelocityPrefix = 88,
		// Token: 0x04000C61 RID: 3169
		Effects1Depth = 91,
		// Token: 0x04000C62 RID: 3170
		Effects2Depth,
		// Token: 0x04000C63 RID: 3171
		Effects3Depth,
		// Token: 0x04000C64 RID: 3172
		Effects4Depth,
		// Token: 0x04000C65 RID: 3173
		Effects5Depth,
		// Token: 0x04000C66 RID: 3174
		DataIncrement,
		// Token: 0x04000C67 RID: 3175
		DataDecrement,
		// Token: 0x04000C68 RID: 3176
		NonRegisteredParameterNumberLsb,
		// Token: 0x04000C69 RID: 3177
		NonRegisteredParameterNumberMsb,
		// Token: 0x04000C6A RID: 3178
		RegisteredParameterNumberLsb,
		// Token: 0x04000C6B RID: 3179
		RegisteredParameterNumberMsb,
		// Token: 0x04000C6C RID: 3180
		AllSoundOff = 120,
		// Token: 0x04000C6D RID: 3181
		ResetAllControllers,
		// Token: 0x04000C6E RID: 3182
		LocalControl,
		// Token: 0x04000C6F RID: 3183
		AllNotesOff,
		// Token: 0x04000C70 RID: 3184
		OmniModeOff,
		// Token: 0x04000C71 RID: 3185
		OmniModeOn,
		// Token: 0x04000C72 RID: 3186
		MonoModeOn,
		// Token: 0x04000C73 RID: 3187
		PolyModeOn,
		// Token: 0x04000C74 RID: 3188
		Undefined = 255
	}
}
