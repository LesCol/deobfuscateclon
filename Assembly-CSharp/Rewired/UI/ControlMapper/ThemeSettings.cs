using System;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200013E RID: 318
	[Serializable]
	public class ThemeSettings : ScriptableObject
	{
		// Token: 0x06003147 RID: 12615 RVA: 0x00145774 File Offset: 0x00143974
		public void Apply(ThemedElement.ElementInfo[] elementInfo)
		{
			if (elementInfo == null)
			{
				return;
			}
			for (int i = 0; i < elementInfo.Length; i++)
			{
				if (elementInfo[i] != null)
				{
					this.Apply(elementInfo[i].themeClass, elementInfo[i].component);
				}
			}
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x001457B0 File Offset: 0x001439B0
		private void Apply(string themeClass, Component component)
		{
			if (component as Selectable != null)
			{
				this.Apply(themeClass, (Selectable)component);
				return;
			}
			if (component as Image != null)
			{
				this.Apply(themeClass, (Image)component);
				return;
			}
			if (component as Text != null)
			{
				this.Apply(themeClass, (Text)component);
				return;
			}
			if (component as UIImageHelper != null)
			{
				this.Apply(themeClass, (UIImageHelper)component);
				return;
			}
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x00145830 File Offset: 0x00143A30
		private void Apply(string themeClass, Selectable item)
		{
			if (item == null)
			{
				return;
			}
			ThemeSettings.SelectableSettings_Base selectableSettings_Base;
			if (item as Button != null)
			{
				if (themeClass == "inputGridField")
				{
					selectableSettings_Base = this._inputGridFieldSettings;
				}
				else
				{
					selectableSettings_Base = this._buttonSettings;
				}
			}
			else if (item as Scrollbar != null)
			{
				selectableSettings_Base = this._scrollbarSettings;
			}
			else if (item as Slider != null)
			{
				selectableSettings_Base = this._sliderSettings;
			}
			else if (item as Toggle != null)
			{
				if (themeClass == "button")
				{
					selectableSettings_Base = this._buttonSettings;
				}
				else
				{
					selectableSettings_Base = this._selectableSettings;
				}
			}
			else
			{
				selectableSettings_Base = this._selectableSettings;
			}
			selectableSettings_Base.Apply(item);
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x001458E0 File Offset: 0x00143AE0
		private void Apply(string themeClass, Image item)
		{
			if (item == null)
			{
				return;
			}
			uint num = <PrivateImplementationDetails>.ComputeStringHash(themeClass);
			if (num <= 2822822017u)
			{
				if (num <= 283896133u)
				{
					if (num != 106194061u)
					{
						if (num != 283896133u)
						{
							return;
						}
						if (!(themeClass == "popupWindow"))
						{
							return;
						}
						this._popupWindowBackground.CopyTo(item);
						return;
					}
					else
					{
						if (!(themeClass == "invertToggleButtonBackground"))
						{
							return;
						}
						this._buttonSettings.imageSettings.CopyTo(item);
						return;
					}
				}
				else if (num != 2601460036u)
				{
					if (num != 2822822017u)
					{
						return;
					}
					if (!(themeClass == "invertToggle"))
					{
						return;
					}
					this._invertToggle.CopyTo(item);
					return;
				}
				else
				{
					if (!(themeClass == "area"))
					{
						return;
					}
					this._areaBackground.CopyTo(item);
					return;
				}
			}
			else if (num <= 3490313510u)
			{
				if (num != 2998767316u)
				{
					if (num != 3490313510u)
					{
						return;
					}
					if (!(themeClass == "calibrationRawValueMarker"))
					{
						return;
					}
					this._calibrationRawValueMarker.CopyTo(item);
					return;
				}
				else
				{
					if (!(themeClass == "mainWindow"))
					{
						return;
					}
					this._mainWindowBackground.CopyTo(item);
					return;
				}
			}
			else if (num != 3776179782u)
			{
				if (num != 3911450241u)
				{
					return;
				}
				if (!(themeClass == "invertToggleBackground"))
				{
					return;
				}
				this._inputGridFieldSettings.imageSettings.CopyTo(item);
				return;
			}
			else
			{
				if (!(themeClass == "calibrationValueMarker"))
				{
					return;
				}
				this._calibrationValueMarker.CopyTo(item);
				return;
			}
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x00145A40 File Offset: 0x00143C40
		private void Apply(string themeClass, Text item)
		{
			if (item == null)
			{
				return;
			}
			ThemeSettings.TextSettings textSettings;
			if (!(themeClass == "button"))
			{
				if (!(themeClass == "inputGridField"))
				{
					textSettings = this._textSettings;
				}
				else
				{
					textSettings = this._inputGridFieldTextSettings;
				}
			}
			else
			{
				textSettings = this._buttonTextSettings;
			}
			if (textSettings.font != null)
			{
				item.font = textSettings.font;
			}
			item.color = textSettings.color;
			item.lineSpacing = textSettings.lineSpacing;
			if (textSettings.sizeMultiplier != 1f)
			{
				item.fontSize = (int)((float)item.fontSize * textSettings.sizeMultiplier);
				item.resizeTextMaxSize = (int)((float)item.resizeTextMaxSize * textSettings.sizeMultiplier);
				item.resizeTextMinSize = (int)((float)item.resizeTextMinSize * textSettings.sizeMultiplier);
			}
			if (textSettings.style != ThemeSettings.FontStyleOverride.Default)
			{
				item.fontStyle = (FontStyle)(textSettings.style - 1);
			}
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x00015C0B File Offset: 0x00013E0B
		private void Apply(string themeClass, UIImageHelper item)
		{
			if (item == null)
			{
				return;
			}
			item.SetEnabledStateColor(this._invertToggle.color);
			item.SetDisabledStateColor(this._invertToggleDisabledColor);
			item.Refresh();
		}

		// Token: 0x04000A88 RID: 2696
		[SerializeField]
		private ThemeSettings.ImageSettings _mainWindowBackground;

		// Token: 0x04000A89 RID: 2697
		[SerializeField]
		private ThemeSettings.ImageSettings _popupWindowBackground;

		// Token: 0x04000A8A RID: 2698
		[SerializeField]
		private ThemeSettings.ImageSettings _areaBackground;

		// Token: 0x04000A8B RID: 2699
		[SerializeField]
		private ThemeSettings.SelectableSettings _selectableSettings;

		// Token: 0x04000A8C RID: 2700
		[SerializeField]
		private ThemeSettings.SelectableSettings _buttonSettings;

		// Token: 0x04000A8D RID: 2701
		[SerializeField]
		private ThemeSettings.SelectableSettings _inputGridFieldSettings;

		// Token: 0x04000A8E RID: 2702
		[SerializeField]
		private ThemeSettings.ScrollbarSettings _scrollbarSettings;

		// Token: 0x04000A8F RID: 2703
		[SerializeField]
		private ThemeSettings.SliderSettings _sliderSettings;

		// Token: 0x04000A90 RID: 2704
		[SerializeField]
		private ThemeSettings.ImageSettings _invertToggle;

		// Token: 0x04000A91 RID: 2705
		[SerializeField]
		private Color _invertToggleDisabledColor;

		// Token: 0x04000A92 RID: 2706
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationValueMarker;

		// Token: 0x04000A93 RID: 2707
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationRawValueMarker;

		// Token: 0x04000A94 RID: 2708
		[SerializeField]
		private ThemeSettings.TextSettings _textSettings;

		// Token: 0x04000A95 RID: 2709
		[SerializeField]
		private ThemeSettings.TextSettings _buttonTextSettings;

		// Token: 0x04000A96 RID: 2710
		[SerializeField]
		private ThemeSettings.TextSettings _inputGridFieldTextSettings;

		// Token: 0x0200013F RID: 319
		[Serializable]
		private abstract class SelectableSettings_Base
		{
			// Token: 0x170003EE RID: 1006
			// (get) Token: 0x0600314E RID: 12622 RVA: 0x00015C42 File Offset: 0x00013E42
			public Selectable.Transition transition
			{
				get
				{
					return this._transition;
				}
			}

			// Token: 0x170003EF RID: 1007
			// (get) Token: 0x0600314F RID: 12623 RVA: 0x00015C4A File Offset: 0x00013E4A
			public ThemeSettings.CustomColorBlock selectableColors
			{
				get
				{
					return this._colors;
				}
			}

			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x06003150 RID: 12624 RVA: 0x00015C52 File Offset: 0x00013E52
			public ThemeSettings.CustomSpriteState spriteState
			{
				get
				{
					return this._spriteState;
				}
			}

			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x06003151 RID: 12625 RVA: 0x00015C5A File Offset: 0x00013E5A
			public ThemeSettings.CustomAnimationTriggers animationTriggers
			{
				get
				{
					return this._animationTriggers;
				}
			}

			// Token: 0x06003152 RID: 12626 RVA: 0x00145B20 File Offset: 0x00143D20
			public virtual void Apply(Selectable item)
			{
				Selectable.Transition transition = this._transition;
				bool flag = item.transition != transition;
				item.transition = transition;
				ICustomSelectable customSelectable = item as ICustomSelectable;
				if (transition == Selectable.Transition.ColorTint)
				{
					ThemeSettings.CustomColorBlock colors = this._colors;
					colors.fadeDuration = 0f;
					item.colors = colors;
					colors.fadeDuration = this._colors.fadeDuration;
					item.colors = colors;
					if (customSelectable != null)
					{
						customSelectable.disabledHighlightedColor = colors.disabledHighlightedColor;
					}
				}
				else if (transition == Selectable.Transition.SpriteSwap)
				{
					item.spriteState = this._spriteState;
					if (customSelectable != null)
					{
						customSelectable.disabledHighlightedSprite = this._spriteState.disabledHighlightedSprite;
					}
				}
				else if (transition == Selectable.Transition.Animation)
				{
					item.animationTriggers.disabledTrigger = this._animationTriggers.disabledTrigger;
					item.animationTriggers.highlightedTrigger = this._animationTriggers.highlightedTrigger;
					item.animationTriggers.normalTrigger = this._animationTriggers.normalTrigger;
					item.animationTriggers.pressedTrigger = this._animationTriggers.pressedTrigger;
					if (customSelectable != null)
					{
						customSelectable.disabledHighlightedTrigger = this._animationTriggers.disabledHighlightedTrigger;
					}
				}
				if (flag)
				{
					item.targetGraphic.CrossFadeColor(item.targetGraphic.color, 0f, true, true);
				}
			}

			// Token: 0x04000A97 RID: 2711
			[SerializeField]
			protected Selectable.Transition _transition;

			// Token: 0x04000A98 RID: 2712
			[SerializeField]
			protected ThemeSettings.CustomColorBlock _colors;

			// Token: 0x04000A99 RID: 2713
			[SerializeField]
			protected ThemeSettings.CustomSpriteState _spriteState;

			// Token: 0x04000A9A RID: 2714
			[SerializeField]
			protected ThemeSettings.CustomAnimationTriggers _animationTriggers;
		}

		// Token: 0x02000140 RID: 320
		[Serializable]
		private class SelectableSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x06003154 RID: 12628 RVA: 0x00015C62 File Offset: 0x00013E62
			public ThemeSettings.ImageSettings imageSettings
			{
				get
				{
					return this._imageSettings;
				}
			}

			// Token: 0x06003155 RID: 12629 RVA: 0x00015C6A File Offset: 0x00013E6A
			public override void Apply(Selectable item)
			{
				if (item == null)
				{
					return;
				}
				base.Apply(item);
				if (this._imageSettings != null)
				{
					this._imageSettings.CopyTo(item.targetGraphic as Image);
				}
			}

			// Token: 0x04000A9B RID: 2715
			[SerializeField]
			private ThemeSettings.ImageSettings _imageSettings;
		}

		// Token: 0x02000141 RID: 321
		[Serializable]
		private class SliderSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x170003F3 RID: 1011
			// (get) Token: 0x06003157 RID: 12631 RVA: 0x00015CA3 File Offset: 0x00013EA3
			public ThemeSettings.ImageSettings handleImageSettings
			{
				get
				{
					return this._handleImageSettings;
				}
			}

			// Token: 0x170003F4 RID: 1012
			// (get) Token: 0x06003158 RID: 12632 RVA: 0x00015CAB File Offset: 0x00013EAB
			public ThemeSettings.ImageSettings fillImageSettings
			{
				get
				{
					return this._fillImageSettings;
				}
			}

			// Token: 0x170003F5 RID: 1013
			// (get) Token: 0x06003159 RID: 12633 RVA: 0x00015CB3 File Offset: 0x00013EB3
			public ThemeSettings.ImageSettings backgroundImageSettings
			{
				get
				{
					return this._backgroundImageSettings;
				}
			}

			// Token: 0x0600315A RID: 12634 RVA: 0x00145C64 File Offset: 0x00143E64
			private void Apply(Slider item)
			{
				if (item == null)
				{
					return;
				}
				if (this._handleImageSettings != null)
				{
					this._handleImageSettings.CopyTo(item.targetGraphic as Image);
				}
				if (this._fillImageSettings != null)
				{
					RectTransform fillRect = item.fillRect;
					if (fillRect != null)
					{
						this._fillImageSettings.CopyTo(fillRect.GetComponent<Image>());
					}
				}
				if (this._backgroundImageSettings != null)
				{
					Transform transform = item.transform.Find("Background");
					if (transform != null)
					{
						this._backgroundImageSettings.CopyTo(transform.GetComponent<Image>());
					}
				}
			}

			// Token: 0x0600315B RID: 12635 RVA: 0x00015CBB File Offset: 0x00013EBB
			public override void Apply(Selectable item)
			{
				base.Apply(item);
				this.Apply(item as Slider);
			}

			// Token: 0x04000A9C RID: 2716
			[SerializeField]
			private ThemeSettings.ImageSettings _handleImageSettings;

			// Token: 0x04000A9D RID: 2717
			[SerializeField]
			private ThemeSettings.ImageSettings _fillImageSettings;

			// Token: 0x04000A9E RID: 2718
			[SerializeField]
			private ThemeSettings.ImageSettings _backgroundImageSettings;
		}

		// Token: 0x02000142 RID: 322
		[Serializable]
		private class ScrollbarSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x170003F6 RID: 1014
			// (get) Token: 0x0600315D RID: 12637 RVA: 0x00015CD0 File Offset: 0x00013ED0
			public ThemeSettings.ImageSettings handle
			{
				get
				{
					return this._handleImageSettings;
				}
			}

			// Token: 0x170003F7 RID: 1015
			// (get) Token: 0x0600315E RID: 12638 RVA: 0x00015CD8 File Offset: 0x00013ED8
			public ThemeSettings.ImageSettings background
			{
				get
				{
					return this._backgroundImageSettings;
				}
			}

			// Token: 0x0600315F RID: 12639 RVA: 0x00145CF8 File Offset: 0x00143EF8
			private void Apply(Scrollbar item)
			{
				if (item == null)
				{
					return;
				}
				if (this._handleImageSettings != null)
				{
					this._handleImageSettings.CopyTo(item.targetGraphic as Image);
				}
				if (this._backgroundImageSettings != null)
				{
					this._backgroundImageSettings.CopyTo(item.GetComponent<Image>());
				}
			}

			// Token: 0x06003160 RID: 12640 RVA: 0x00015CE0 File Offset: 0x00013EE0
			public override void Apply(Selectable item)
			{
				base.Apply(item);
				this.Apply(item as Scrollbar);
			}

			// Token: 0x04000A9F RID: 2719
			[SerializeField]
			private ThemeSettings.ImageSettings _handleImageSettings;

			// Token: 0x04000AA0 RID: 2720
			[SerializeField]
			private ThemeSettings.ImageSettings _backgroundImageSettings;
		}

		// Token: 0x02000143 RID: 323
		[Serializable]
		private class ImageSettings
		{
			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x06003162 RID: 12642 RVA: 0x00015CF5 File Offset: 0x00013EF5
			public Color color
			{
				get
				{
					return this._color;
				}
			}

			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x06003163 RID: 12643 RVA: 0x00015CFD File Offset: 0x00013EFD
			public Sprite sprite
			{
				get
				{
					return this._sprite;
				}
			}

			// Token: 0x170003FA RID: 1018
			// (get) Token: 0x06003164 RID: 12644 RVA: 0x00015D05 File Offset: 0x00013F05
			public Material materal
			{
				get
				{
					return this._materal;
				}
			}

			// Token: 0x170003FB RID: 1019
			// (get) Token: 0x06003165 RID: 12645 RVA: 0x00015D0D File Offset: 0x00013F0D
			public Image.Type type
			{
				get
				{
					return this._type;
				}
			}

			// Token: 0x170003FC RID: 1020
			// (get) Token: 0x06003166 RID: 12646 RVA: 0x00015D15 File Offset: 0x00013F15
			public bool preserveAspect
			{
				get
				{
					return this._preserveAspect;
				}
			}

			// Token: 0x170003FD RID: 1021
			// (get) Token: 0x06003167 RID: 12647 RVA: 0x00015D1D File Offset: 0x00013F1D
			public bool fillCenter
			{
				get
				{
					return this._fillCenter;
				}
			}

			// Token: 0x170003FE RID: 1022
			// (get) Token: 0x06003168 RID: 12648 RVA: 0x00015D25 File Offset: 0x00013F25
			public Image.FillMethod fillMethod
			{
				get
				{
					return this._fillMethod;
				}
			}

			// Token: 0x170003FF RID: 1023
			// (get) Token: 0x06003169 RID: 12649 RVA: 0x00015D2D File Offset: 0x00013F2D
			public float fillAmout
			{
				get
				{
					return this._fillAmout;
				}
			}

			// Token: 0x17000400 RID: 1024
			// (get) Token: 0x0600316A RID: 12650 RVA: 0x00015D35 File Offset: 0x00013F35
			public bool fillClockwise
			{
				get
				{
					return this._fillClockwise;
				}
			}

			// Token: 0x17000401 RID: 1025
			// (get) Token: 0x0600316B RID: 12651 RVA: 0x00015D3D File Offset: 0x00013F3D
			public int fillOrigin
			{
				get
				{
					return this._fillOrigin;
				}
			}

			// Token: 0x0600316C RID: 12652 RVA: 0x00145D48 File Offset: 0x00143F48
			public virtual void CopyTo(Image image)
			{
				if (image == null)
				{
					return;
				}
				image.color = this._color;
				image.sprite = this._sprite;
				image.material = this._materal;
				image.type = this._type;
				image.preserveAspect = this._preserveAspect;
				image.fillCenter = this._fillCenter;
				image.fillMethod = this._fillMethod;
				image.fillAmount = this._fillAmout;
				image.fillClockwise = this._fillClockwise;
				image.fillOrigin = this._fillOrigin;
			}

			// Token: 0x04000AA1 RID: 2721
			[SerializeField]
			private Color _color = Color.white;

			// Token: 0x04000AA2 RID: 2722
			[SerializeField]
			private Sprite _sprite;

			// Token: 0x04000AA3 RID: 2723
			[SerializeField]
			private Material _materal;

			// Token: 0x04000AA4 RID: 2724
			[SerializeField]
			private Image.Type _type;

			// Token: 0x04000AA5 RID: 2725
			[SerializeField]
			private bool _preserveAspect;

			// Token: 0x04000AA6 RID: 2726
			[SerializeField]
			private bool _fillCenter;

			// Token: 0x04000AA7 RID: 2727
			[SerializeField]
			private Image.FillMethod _fillMethod;

			// Token: 0x04000AA8 RID: 2728
			[SerializeField]
			private float _fillAmout;

			// Token: 0x04000AA9 RID: 2729
			[SerializeField]
			private bool _fillClockwise;

			// Token: 0x04000AAA RID: 2730
			[SerializeField]
			private int _fillOrigin;
		}

		// Token: 0x02000144 RID: 324
		[Serializable]
		private struct CustomColorBlock
		{
			// Token: 0x17000402 RID: 1026
			// (get) Token: 0x0600316E RID: 12654 RVA: 0x00015D58 File Offset: 0x00013F58
			// (set) Token: 0x0600316F RID: 12655 RVA: 0x00015D60 File Offset: 0x00013F60
			public float colorMultiplier
			{
				get
				{
					return this.m_ColorMultiplier;
				}
				set
				{
					this.m_ColorMultiplier = value;
				}
			}

			// Token: 0x17000403 RID: 1027
			// (get) Token: 0x06003170 RID: 12656 RVA: 0x00015D69 File Offset: 0x00013F69
			// (set) Token: 0x06003171 RID: 12657 RVA: 0x00015D71 File Offset: 0x00013F71
			public Color disabledColor
			{
				get
				{
					return this.m_DisabledColor;
				}
				set
				{
					this.m_DisabledColor = value;
				}
			}

			// Token: 0x17000404 RID: 1028
			// (get) Token: 0x06003172 RID: 12658 RVA: 0x00015D7A File Offset: 0x00013F7A
			// (set) Token: 0x06003173 RID: 12659 RVA: 0x00015D82 File Offset: 0x00013F82
			public float fadeDuration
			{
				get
				{
					return this.m_FadeDuration;
				}
				set
				{
					this.m_FadeDuration = value;
				}
			}

			// Token: 0x17000405 RID: 1029
			// (get) Token: 0x06003174 RID: 12660 RVA: 0x00015D8B File Offset: 0x00013F8B
			// (set) Token: 0x06003175 RID: 12661 RVA: 0x00015D93 File Offset: 0x00013F93
			public Color highlightedColor
			{
				get
				{
					return this.m_HighlightedColor;
				}
				set
				{
					this.m_HighlightedColor = value;
				}
			}

			// Token: 0x17000406 RID: 1030
			// (get) Token: 0x06003176 RID: 12662 RVA: 0x00015D9C File Offset: 0x00013F9C
			// (set) Token: 0x06003177 RID: 12663 RVA: 0x00015DA4 File Offset: 0x00013FA4
			public Color normalColor
			{
				get
				{
					return this.m_NormalColor;
				}
				set
				{
					this.m_NormalColor = value;
				}
			}

			// Token: 0x17000407 RID: 1031
			// (get) Token: 0x06003178 RID: 12664 RVA: 0x00015DAD File Offset: 0x00013FAD
			// (set) Token: 0x06003179 RID: 12665 RVA: 0x00015DB5 File Offset: 0x00013FB5
			public Color pressedColor
			{
				get
				{
					return this.m_PressedColor;
				}
				set
				{
					this.m_PressedColor = value;
				}
			}

			// Token: 0x17000408 RID: 1032
			// (get) Token: 0x0600317A RID: 12666 RVA: 0x00015DBE File Offset: 0x00013FBE
			// (set) Token: 0x0600317B RID: 12667 RVA: 0x00015DC6 File Offset: 0x00013FC6
			public Color disabledHighlightedColor
			{
				get
				{
					return this.m_DisabledHighlightedColor;
				}
				set
				{
					this.m_DisabledHighlightedColor = value;
				}
			}

			// Token: 0x0600317C RID: 12668 RVA: 0x00145DD8 File Offset: 0x00143FD8
			public static implicit operator ColorBlock(ThemeSettings.CustomColorBlock item)
			{
				return new ColorBlock
				{
					colorMultiplier = item.m_ColorMultiplier,
					disabledColor = item.m_DisabledColor,
					fadeDuration = item.m_FadeDuration,
					highlightedColor = item.m_HighlightedColor,
					normalColor = item.m_NormalColor,
					pressedColor = item.m_PressedColor
				};
			}

			// Token: 0x04000AAB RID: 2731
			[SerializeField]
			private float m_ColorMultiplier;

			// Token: 0x04000AAC RID: 2732
			[SerializeField]
			private Color m_DisabledColor;

			// Token: 0x04000AAD RID: 2733
			[SerializeField]
			private float m_FadeDuration;

			// Token: 0x04000AAE RID: 2734
			[SerializeField]
			private Color m_HighlightedColor;

			// Token: 0x04000AAF RID: 2735
			[SerializeField]
			private Color m_NormalColor;

			// Token: 0x04000AB0 RID: 2736
			[SerializeField]
			private Color m_PressedColor;

			// Token: 0x04000AB1 RID: 2737
			[SerializeField]
			private Color m_DisabledHighlightedColor;
		}

		// Token: 0x02000145 RID: 325
		[Serializable]
		private struct CustomSpriteState
		{
			// Token: 0x17000409 RID: 1033
			// (get) Token: 0x0600317D RID: 12669 RVA: 0x00015DCF File Offset: 0x00013FCF
			// (set) Token: 0x0600317E RID: 12670 RVA: 0x00015DD7 File Offset: 0x00013FD7
			public Sprite disabledSprite
			{
				get
				{
					return this.m_DisabledSprite;
				}
				set
				{
					this.m_DisabledSprite = value;
				}
			}

			// Token: 0x1700040A RID: 1034
			// (get) Token: 0x0600317F RID: 12671 RVA: 0x00015DE0 File Offset: 0x00013FE0
			// (set) Token: 0x06003180 RID: 12672 RVA: 0x00015DE8 File Offset: 0x00013FE8
			public Sprite highlightedSprite
			{
				get
				{
					return this.m_HighlightedSprite;
				}
				set
				{
					this.m_HighlightedSprite = value;
				}
			}

			// Token: 0x1700040B RID: 1035
			// (get) Token: 0x06003181 RID: 12673 RVA: 0x00015DF1 File Offset: 0x00013FF1
			// (set) Token: 0x06003182 RID: 12674 RVA: 0x00015DF9 File Offset: 0x00013FF9
			public Sprite pressedSprite
			{
				get
				{
					return this.m_PressedSprite;
				}
				set
				{
					this.m_PressedSprite = value;
				}
			}

			// Token: 0x1700040C RID: 1036
			// (get) Token: 0x06003183 RID: 12675 RVA: 0x00015E02 File Offset: 0x00014002
			// (set) Token: 0x06003184 RID: 12676 RVA: 0x00015E0A File Offset: 0x0001400A
			public Sprite disabledHighlightedSprite
			{
				get
				{
					return this.m_DisabledHighlightedSprite;
				}
				set
				{
					this.m_DisabledHighlightedSprite = value;
				}
			}

			// Token: 0x06003185 RID: 12677 RVA: 0x00145E3C File Offset: 0x0014403C
			public static implicit operator SpriteState(ThemeSettings.CustomSpriteState item)
			{
				return new SpriteState
				{
					disabledSprite = item.m_DisabledSprite,
					highlightedSprite = item.m_HighlightedSprite,
					pressedSprite = item.m_PressedSprite
				};
			}

			// Token: 0x04000AB2 RID: 2738
			[SerializeField]
			private Sprite m_DisabledSprite;

			// Token: 0x04000AB3 RID: 2739
			[SerializeField]
			private Sprite m_HighlightedSprite;

			// Token: 0x04000AB4 RID: 2740
			[SerializeField]
			private Sprite m_PressedSprite;

			// Token: 0x04000AB5 RID: 2741
			[SerializeField]
			private Sprite m_DisabledHighlightedSprite;
		}

		// Token: 0x02000146 RID: 326
		[Serializable]
		private class CustomAnimationTriggers
		{
			// Token: 0x06003186 RID: 12678 RVA: 0x00015E13 File Offset: 0x00014013
			public CustomAnimationTriggers()
			{
				this.m_DisabledTrigger = string.Empty;
				this.m_HighlightedTrigger = string.Empty;
				this.m_NormalTrigger = string.Empty;
				this.m_PressedTrigger = string.Empty;
				this.m_DisabledHighlightedTrigger = string.Empty;
			}

			// Token: 0x1700040D RID: 1037
			// (get) Token: 0x06003187 RID: 12679 RVA: 0x00015E52 File Offset: 0x00014052
			// (set) Token: 0x06003188 RID: 12680 RVA: 0x00015E5A File Offset: 0x0001405A
			public string disabledTrigger
			{
				get
				{
					return this.m_DisabledTrigger;
				}
				set
				{
					this.m_DisabledTrigger = value;
				}
			}

			// Token: 0x1700040E RID: 1038
			// (get) Token: 0x06003189 RID: 12681 RVA: 0x00015E63 File Offset: 0x00014063
			// (set) Token: 0x0600318A RID: 12682 RVA: 0x00015E6B File Offset: 0x0001406B
			public string highlightedTrigger
			{
				get
				{
					return this.m_HighlightedTrigger;
				}
				set
				{
					this.m_HighlightedTrigger = value;
				}
			}

			// Token: 0x1700040F RID: 1039
			// (get) Token: 0x0600318B RID: 12683 RVA: 0x00015E74 File Offset: 0x00014074
			// (set) Token: 0x0600318C RID: 12684 RVA: 0x00015E7C File Offset: 0x0001407C
			public string normalTrigger
			{
				get
				{
					return this.m_NormalTrigger;
				}
				set
				{
					this.m_NormalTrigger = value;
				}
			}

			// Token: 0x17000410 RID: 1040
			// (get) Token: 0x0600318D RID: 12685 RVA: 0x00015E85 File Offset: 0x00014085
			// (set) Token: 0x0600318E RID: 12686 RVA: 0x00015E8D File Offset: 0x0001408D
			public string pressedTrigger
			{
				get
				{
					return this.m_PressedTrigger;
				}
				set
				{
					this.m_PressedTrigger = value;
				}
			}

			// Token: 0x17000411 RID: 1041
			// (get) Token: 0x0600318F RID: 12687 RVA: 0x00015E96 File Offset: 0x00014096
			// (set) Token: 0x06003190 RID: 12688 RVA: 0x00015E9E File Offset: 0x0001409E
			public string disabledHighlightedTrigger
			{
				get
				{
					return this.m_DisabledHighlightedTrigger;
				}
				set
				{
					this.m_DisabledHighlightedTrigger = value;
				}
			}

			// Token: 0x06003191 RID: 12689 RVA: 0x00015EA7 File Offset: 0x000140A7
			public static implicit operator AnimationTriggers(ThemeSettings.CustomAnimationTriggers item)
			{
				return new AnimationTriggers
				{
					disabledTrigger = item.m_DisabledTrigger,
					highlightedTrigger = item.m_HighlightedTrigger,
					normalTrigger = item.m_NormalTrigger,
					pressedTrigger = item.m_PressedTrigger
				};
			}

			// Token: 0x04000AB6 RID: 2742
			[SerializeField]
			private string m_DisabledTrigger;

			// Token: 0x04000AB7 RID: 2743
			[SerializeField]
			private string m_HighlightedTrigger;

			// Token: 0x04000AB8 RID: 2744
			[SerializeField]
			private string m_NormalTrigger;

			// Token: 0x04000AB9 RID: 2745
			[SerializeField]
			private string m_PressedTrigger;

			// Token: 0x04000ABA RID: 2746
			[SerializeField]
			private string m_DisabledHighlightedTrigger;
		}

		// Token: 0x02000147 RID: 327
		[Serializable]
		private class TextSettings
		{
			// Token: 0x17000412 RID: 1042
			// (get) Token: 0x06003192 RID: 12690 RVA: 0x00015EDE File Offset: 0x000140DE
			public Color color
			{
				get
				{
					return this._color;
				}
			}

			// Token: 0x17000413 RID: 1043
			// (get) Token: 0x06003193 RID: 12691 RVA: 0x00015EE6 File Offset: 0x000140E6
			public Font font
			{
				get
				{
					return this._font;
				}
			}

			// Token: 0x17000414 RID: 1044
			// (get) Token: 0x06003194 RID: 12692 RVA: 0x00015EEE File Offset: 0x000140EE
			public ThemeSettings.FontStyleOverride style
			{
				get
				{
					return this._style;
				}
			}

			// Token: 0x17000415 RID: 1045
			// (get) Token: 0x06003195 RID: 12693 RVA: 0x00015EF6 File Offset: 0x000140F6
			public float lineSpacing
			{
				get
				{
					return this._lineSpacing;
				}
			}

			// Token: 0x17000416 RID: 1046
			// (get) Token: 0x06003196 RID: 12694 RVA: 0x00015EFE File Offset: 0x000140FE
			public float sizeMultiplier
			{
				get
				{
					return this._sizeMultiplier;
				}
			}

			// Token: 0x04000ABB RID: 2747
			[SerializeField]
			private Color _color = Color.white;

			// Token: 0x04000ABC RID: 2748
			[SerializeField]
			private Font _font;

			// Token: 0x04000ABD RID: 2749
			[SerializeField]
			private ThemeSettings.FontStyleOverride _style;

			// Token: 0x04000ABE RID: 2750
			[SerializeField]
			private float _lineSpacing = 1f;

			// Token: 0x04000ABF RID: 2751
			[SerializeField]
			private float _sizeMultiplier = 1f;
		}

		// Token: 0x02000148 RID: 328
		private enum FontStyleOverride
		{
			// Token: 0x04000AC1 RID: 2753
			Default,
			// Token: 0x04000AC2 RID: 2754
			Normal,
			// Token: 0x04000AC3 RID: 2755
			Bold,
			// Token: 0x04000AC4 RID: 2756
			Italic,
			// Token: 0x04000AC5 RID: 2757
			BoldAndItalic
		}
	}
}
