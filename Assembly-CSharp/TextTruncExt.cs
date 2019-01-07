using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000C3 RID: 195
public class TextTruncExt : Text
{
	// Token: 0x060026B3 RID: 9907 RVA: 0x00129E14 File Offset: 0x00128014
	protected virtual void vmethod_0(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 475f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 8);
			this.string_0 += "%y";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026B4 RID: 9908 RVA: 0x00129EA0 File Offset: 0x001280A0
	protected virtual void vmethod_1(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 1348f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 6);
			this.string_0 += "custom";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026B5 RID: 9909 RVA: 0x00129F2C File Offset: 0x0012812C
	protected virtual void vmethod_2(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 1215f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 2);
			this.string_0 += "Unknown Charter";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026B6 RID: 9910 RVA: 0x00129FB8 File Offset: 0x001281B8
	protected virtual void vmethod_3(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 279f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 3);
			this.string_0 += "[\\-\\+]?\\d+(\\.\\d+)?";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026B7 RID: 9911 RVA: 0x0012A044 File Offset: 0x00128244
	protected virtual void vmethod_4(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 851f)
		{
			this.string_0 = base.text.Substring(1, base.cachedTextGenerator.characterCount - 2);
			this.string_0 += "%s%n%a%n%c";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026B8 RID: 9912 RVA: 0x0012A0D0 File Offset: 0x001282D0
	protected virtual void vmethod_5(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 1590f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 1);
			this.string_0 += ", Vel: ";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026B9 RID: 9913 RVA: 0x0012A15C File Offset: 0x0012835C
	protected virtual void vmethod_6(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 4f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 1);
			this.string_0 += "No NetworkStartPositions exist!";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026BA RID: 9914 RVA: 0x0012A1E8 File Offset: 0x001283E8
	protected virtual void vmethod_7(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 1392f)
		{
			this.string_0 = base.text.Substring(1, base.cachedTextGenerator.characterCount - 1);
			this.string_0 += "mute_volume";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026BB RID: 9915 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_0()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026BC RID: 9916 RVA: 0x0012A274 File Offset: 0x00128474
	protected virtual void vmethod_8(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 1619f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 6);
			this.string_0 += "";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026BD RID: 9917 RVA: 0x0012A300 File Offset: 0x00128500
	protected virtual void vmethod_9(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 1719f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 6);
			this.string_0 += "video";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026BE RID: 9918 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_1()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026BF RID: 9919 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void Update()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026C0 RID: 9920 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_2()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026C1 RID: 9921 RVA: 0x0012A38C File Offset: 0x0012858C
	protected virtual void vmethod_10(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 419f)
		{
			this.string_0 = base.text.Substring(1, base.cachedTextGenerator.characterCount - 2);
			this.string_0 += "video";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026C3 RID: 9923 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_3()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026C4 RID: 9924 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_4()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026C5 RID: 9925 RVA: 0x0012A418 File Offset: 0x00128618
	protected virtual void vmethod_11(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 297f)
		{
			this.string_0 = base.text.Substring(1, base.cachedTextGenerator.characterCount - 3);
			this.string_0 += "preview_start_time";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026C6 RID: 9926 RVA: 0x0012A4A4 File Offset: 0x001286A4
	protected virtual void vmethod_12(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 587f)
		{
			this.string_0 = base.text.Substring(1, base.cachedTextGenerator.characterCount - 7);
			this.string_0 += "offsets";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026C7 RID: 9927 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_5()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026C8 RID: 9928 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_6()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026C9 RID: 9929 RVA: 0x0012A530 File Offset: 0x00128730
	protected virtual void vmethod_13(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 1521f)
		{
			this.string_0 = base.text.Substring(1, base.cachedTextGenerator.characterCount - 7);
			this.string_0 += "You must restart, settings were changed";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026CA RID: 9930 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_7()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026CB RID: 9931 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_8()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026CC RID: 9932 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_9()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026CD RID: 9933 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_10()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026CE RID: 9934 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_11()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026CF RID: 9935 RVA: 0x0012A5BC File Offset: 0x001287BC
	protected virtual void vmethod_14(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 480f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 7);
			this.string_0 += " (";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026D0 RID: 9936 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_12()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026D1 RID: 9937 RVA: 0x0012A648 File Offset: 0x00128848
	protected virtual void vmethod_15(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 15f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 3);
			this.string_0 += "Overwrite";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026D2 RID: 9938 RVA: 0x0012A6D4 File Offset: 0x001288D4
	protected virtual void vmethod_16(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 490f)
		{
			this.string_0 = base.text.Substring(1, base.cachedTextGenerator.characterCount - 6);
			this.string_0 += "None";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026D3 RID: 9939 RVA: 0x0012A760 File Offset: 0x00128960
	protected virtual void vmethod_17(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 1033f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 0);
			this.string_0 += "All HOPO's";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026D4 RID: 9940 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_13()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026D5 RID: 9941 RVA: 0x0012A7EC File Offset: 0x001289EC
	protected virtual void vmethod_18(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 761f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 1);
			this.string_0 += "<color=#FFA300>";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026D6 RID: 9942 RVA: 0x0012A878 File Offset: 0x00128A78
	protected override void OnPopulateMesh(VertexHelper vh)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 1f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 4);
			this.string_0 += "...";
		}
		base.OnPopulateMesh(vh);
	}

	// Token: 0x060026D7 RID: 9943 RVA: 0x0012A904 File Offset: 0x00128B04
	protected virtual void vmethod_19(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 805f)
		{
			this.string_0 = base.text.Substring(1, base.cachedTextGenerator.characterCount - 3);
			this.string_0 += "</color>";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026D8 RID: 9944 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_14()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026D9 RID: 9945 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_15()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026DA RID: 9946 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_16()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026DB RID: 9947 RVA: 0x0012A990 File Offset: 0x00128B90
	protected virtual void vmethod_20(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 918f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 2);
			this.string_0 += "genre";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026DC RID: 9948 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_17()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026DD RID: 9949 RVA: 0x0012AA1C File Offset: 0x00128C1C
	protected virtual void vmethod_21(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 128f)
		{
			this.string_0 = base.text.Substring(1, base.cachedTextGenerator.characterCount - 5);
			this.string_0 += "keys";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026DE RID: 9950 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_18()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026DF RID: 9951 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_19()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026E0 RID: 9952 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_20()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026E1 RID: 9953 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_21()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026E2 RID: 9954 RVA: 0x0012AAA8 File Offset: 0x00128CA8
	protected virtual void vmethod_22(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 46f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 8);
			this.string_0 += "notes.mid";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026E3 RID: 9955 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_22()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026E4 RID: 9956 RVA: 0x0012AB34 File Offset: 0x00128D34
	protected virtual void vmethod_23(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 203f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 2);
			this.string_0 += "Note Shuffle";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026E5 RID: 9957 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_23()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026E6 RID: 9958 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_24()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026E7 RID: 9959 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_25()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026E8 RID: 9960 RVA: 0x0012ABC0 File Offset: 0x00128DC0
	protected virtual void vmethod_24(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 904f)
		{
			this.string_0 = base.text.Substring(1, base.cachedTextGenerator.characterCount - 7);
			this.string_0 += "video";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026E9 RID: 9961 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_26()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026EA RID: 9962 RVA: 0x0012AC4C File Offset: 0x00128E4C
	protected virtual void vmethod_25(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 447f)
		{
			this.string_0 = base.text.Substring(1, base.cachedTextGenerator.characterCount - 4);
			this.string_0 += "%";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026EB RID: 9963 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_27()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026EC RID: 9964 RVA: 0x0012ACD8 File Offset: 0x00128ED8
	protected virtual void vmethod_26(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 123f)
		{
			this.string_0 = base.text.Substring(1, base.cachedTextGenerator.characterCount - 7);
			this.string_0 += "Controller";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026ED RID: 9965 RVA: 0x0012AD64 File Offset: 0x00128F64
	protected virtual void vmethod_27(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 301f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 8);
			this.string_0 += "Rename Setlist";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026EE RID: 9966 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_28()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026EF RID: 9967 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_29()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026F0 RID: 9968 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_30()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026F1 RID: 9969 RVA: 0x0012ADF0 File Offset: 0x00128FF0
	protected virtual void vmethod_28(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 1154f)
		{
			this.string_0 = base.text.Substring(0, base.cachedTextGenerator.characterCount - 6);
			this.string_0 += "custom";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026F2 RID: 9970 RVA: 0x0012AE7C File Offset: 0x0012907C
	protected virtual void vmethod_29(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 463f)
		{
			this.string_0 = base.text.Substring(1, base.cachedTextGenerator.characterCount - 3);
			this.string_0 += "volume";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026F3 RID: 9971 RVA: 0x0012AF08 File Offset: 0x00129108
	protected virtual void vmethod_30(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 1385f)
		{
			this.string_0 = base.text.Substring(1, base.cachedTextGenerator.characterCount - 2);
			this.string_0 += "notes_ripple_up_01";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026F4 RID: 9972 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_31()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026F5 RID: 9973 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_32()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026F6 RID: 9974 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_33()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026F7 RID: 9975 RVA: 0x0012AF94 File Offset: 0x00129194
	protected virtual void vmethod_31(VertexHelper vertexHelper_0)
	{
		Vector2 size = base.rectTransform.rect.size;
		TextGenerationSettings generationSettings = base.GetGenerationSettings(size);
		base.cachedTextGenerator.Populate(base.text, generationSettings);
		if (size.x / this.preferredWidth < 418f)
		{
			this.string_0 = base.text.Substring(1, base.cachedTextGenerator.characterCount - 3);
			this.string_0 += "video";
		}
		base.OnPopulateMesh(vertexHelper_0);
	}

	// Token: 0x060026F8 RID: 9976 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_34()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026F9 RID: 9977 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_35()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026FA RID: 9978 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_36()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x060026FB RID: 9979 RVA: 0x00010B5B File Offset: 0x0000ED5B
	private void method_37()
	{
		if (this.string_0 != string.Empty && this.string_0 != base.text)
		{
			base.text = this.string_0;
		}
	}

	// Token: 0x040005FE RID: 1534
	private string string_0 = string.Empty;
}
