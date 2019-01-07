using System;
using Melanchall.DryWetMidi.Common;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001D2 RID: 466
	public static class NoteUtilities
	{
		// Token: 0x06003482 RID: 13442 RVA: 0x00018223 File Offset: 0x00016423
		public static NoteName GetNoteName(this NoteEvent noteEvent)
		{
			return NoteUtilities.GetNoteName(noteEvent.NoteNumber);
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x00018230 File Offset: 0x00016430
		public static int GetNoteOctave(this NoteEvent noteEvent)
		{
			return NoteUtilities.GetNoteOctave(noteEvent.NoteNumber);
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x0001823D File Offset: 0x0001643D
		public static void SetNoteNumber(this NoteEvent noteEvent, NoteName noteName, int octave)
		{
			noteEvent.NoteNumber = NoteUtilities.GetNoteNumber(noteName, octave);
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x0001824C File Offset: 0x0001644C
		public static NoteName GetNoteName(SevenBitNumber noteNumber)
		{
			return (NoteName)(noteNumber % 12);
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x00018257 File Offset: 0x00016457
		public static int GetNoteOctave(SevenBitNumber noteNumber)
		{
			return (int)(noteNumber / 12 - 1);
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x001492B4 File Offset: 0x001474B4
		public static SevenBitNumber GetNoteNumber(NoteName noteName, int octave)
		{
			int num = (int)((octave + 1) * 12 + noteName);
			if (num < (int)SevenBitNumber.MinValue || num > (int)SevenBitNumber.MaxValue)
			{
				throw new ArgumentException("Note number is out of range for the specified note name and octave.", "octave");
			}
			return (SevenBitNumber)((byte)num);
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x001492FC File Offset: 0x001474FC
		internal static bool IsNoteValid(NoteName noteName, int octave)
		{
			int num = (int)((octave + 1) * 12 + noteName);
			return num >= (int)SevenBitNumber.MinValue && num <= (int)SevenBitNumber.MaxValue;
		}

		// Token: 0x04000C0B RID: 3083
		private const int OctaveSize = 12;

		// Token: 0x04000C0C RID: 3084
		private const int OctaveOffset = 1;
	}
}
