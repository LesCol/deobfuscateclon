using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001B8 RID: 440
	public sealed class MidiFile
	{
		// Token: 0x06003405 RID: 13317 RVA: 0x00017C25 File Offset: 0x00015E25
		public MidiFile()
		{
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x00017C43 File Offset: 0x00015E43
		public MidiFile(IEnumerable<MidiChunk> chunks)
		{
			this.Chunks.AddRange(chunks);
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x00017C6D File Offset: 0x00015E6D
		public MidiFile(params MidiChunk[] chunks) : this(chunks)
		{
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06003408 RID: 13320 RVA: 0x00017C76 File Offset: 0x00015E76
		// (set) Token: 0x06003409 RID: 13321 RVA: 0x00017C7E File Offset: 0x00015E7E
		public TimeDivision TimeDivision { get; set; } = new TicksPerQuarterNoteTimeDivision();

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600340A RID: 13322 RVA: 0x00017C87 File Offset: 0x00015E87
		public ChunksCollection Chunks { get; } = new ChunksCollection();

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600340B RID: 13323 RVA: 0x00148804 File Offset: 0x00146A04
		public MidiFileFormat OriginalFormat
		{
			get
			{
				if (this._originalFormat == null)
				{
					throw new InvalidOperationException("Unable to get original format of the file.");
				}
				ushort value = this._originalFormat.Value;
				if (!Enum.IsDefined(typeof(MidiFileFormat), value))
				{
					throw new UnknownFileFormatException(string.Format("File format {0} is unknown.", value), value);
				}
				return (MidiFileFormat)value;
			}
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x00017C8F File Offset: 0x00015E8F
		public static MidiFile Read(string filePath, ReadingSettings settings = null)
		{
			return MidiFile.Read(FileUtilities.OpenFileForRead(filePath), settings);
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x00148864 File Offset: 0x00146A64
		public void Write(string filePath, bool overwriteFile = false, MidiFileFormat format = MidiFileFormat.MultiTrack, WritingSettings settings = null)
		{
			using (FileStream fileStream = FileUtilities.OpenFileForWrite(filePath, overwriteFile))
			{
				this.Write(fileStream, format, settings);
			}
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x001488A0 File Offset: 0x00146AA0
		public static MidiFile Read(Stream stream, ReadingSettings settings = null)
		{
			if (settings == null)
			{
				settings = new ReadingSettings
				{
					InvalidChannelEventParameterValuePolicy = InvalidChannelEventParameterValuePolicy.SnapToLimits,
					InvalidChunkSizePolicy = InvalidChunkSizePolicy.Ignore,
					NotEnoughBytesPolicy = NotEnoughBytesPolicy.Ignore,
					InvalidMetaEventParameterValuePolicy = InvalidMetaEventParameterValuePolicy.SnapToLimits,
					UnexpectedTrackChunksCountPolicy = UnexpectedTrackChunksCountPolicy.Ignore,
					TextEncoding = Encoding.UTF8
				};
			}
			MidiFile midiFile = new MidiFile();
			int? num = null;
			int num2 = 0;
			bool flag = false;
			try
			{
				using (MidiReader midiReader = new MidiReader(stream))
				{
					long? num3 = null;
					string text = midiReader.ReadString("RIFF".Length);
					if (text == "RIFF")
					{
						midiReader.Position += 12L;
						uint num4 = midiReader.ReadDword();
						num3 = new long?(midiReader.Position + (long)((ulong)num4));
					}
					else
					{
						midiReader.Position -= (long)text.Length;
					}
					while (!midiReader.EndReached)
					{
						if (num3 != null)
						{
							long position = midiReader.Position;
							long? num5 = num3;
							if (!(position < num5.GetValueOrDefault() & num5 != null))
							{
								break;
							}
						}
						MidiChunk midiChunk = MidiFile.ReadChunk(midiReader, settings, num2, num);
						if (midiChunk != null)
						{
							HeaderChunk headerChunk = midiChunk as HeaderChunk;
							if (headerChunk != null)
							{
								if (!flag)
								{
									num = new int?((int)headerChunk.TracksNumber);
									midiFile.TimeDivision = headerChunk.TimeDivision;
									midiFile._originalFormat = new ushort?(headerChunk.FileFormat);
								}
								flag = true;
							}
							else
							{
								if (midiChunk is TrackChunk)
								{
									num2++;
								}
								midiFile.Chunks.Add(midiChunk);
							}
						}
					}
					if (num != null)
					{
						int num6 = num2;
						int? num7 = num;
						if (!(num6 == num7.GetValueOrDefault() & num7 != null))
						{
							MidiFile.ReactOnUnexpectedTrackChunksCount(settings.UnexpectedTrackChunksCountPolicy, num2, num.Value);
						}
					}
					if (!flag)
					{
						midiFile.TimeDivision = null;
						if (settings.NoHeaderChunkPolicy == NoHeaderChunkPolicy.Abort)
						{
							throw new NoHeaderChunkException();
						}
					}
				}
			}
			catch (NotEnoughBytesException exception)
			{
				MidiFile.ReactOnNotEnoughBytes(settings.NotEnoughBytesPolicy, exception);
			}
			catch (EndOfStreamException exception2)
			{
				MidiFile.ReactOnNotEnoughBytes(settings.NotEnoughBytesPolicy, exception2);
			}
			return midiFile;
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x00148AE4 File Offset: 0x00146CE4
		public void Write(Stream stream, MidiFileFormat format = MidiFileFormat.MultiTrack, WritingSettings settings = null)
		{
			if (this.TimeDivision == null)
			{
				throw new InvalidOperationException("Time division is null.");
			}
			if (!stream.CanWrite)
			{
				throw new ArgumentException("Stream doesn't support writing.", "stream");
			}
			if (settings == null)
			{
				settings = new WritingSettings();
			}
			using (MidiWriter midiWriter = new MidiWriter(stream))
			{
				IEnumerable<MidiChunk> enumerable = ChunksConverterFactory.GetConverter(format).Convert(this.Chunks);
				int num = enumerable.Count((MidiChunk c) => c is TrackChunk);
				if (num > 65535)
				{
					throw new TooManyTrackChunksException(string.Format("Count of track chunks to be written ({0}) is greater than the valid maximum ({1}).", num, ushort.MaxValue), num);
				}
				new HeaderChunk
				{
					FileFormat = (ushort)format,
					TimeDivision = this.TimeDivision,
					TracksNumber = (ushort)num
				}.Write(midiWriter, settings);
				foreach (MidiChunk midiChunk in enumerable)
				{
					if (!settings.CompressionPolicy.HasFlag(CompressionPolicy.DeleteUnknownChunks) || !(midiChunk is UnknownChunk))
					{
						midiChunk.Write(midiWriter, settings);
					}
				}
			}
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x00148C28 File Offset: 0x00146E28
		private static MidiChunk ReadChunk(MidiReader reader, ReadingSettings settings, int actualTrackChunksCount, int? expectedTrackChunksCount)
		{
			MidiChunk midiChunk = null;
			try
			{
				string text = reader.ReadString(4);
				if (text.Length < 4)
				{
					NotEnoughBytesPolicy notEnoughBytesPolicy = settings.NotEnoughBytesPolicy;
					if (notEnoughBytesPolicy == NotEnoughBytesPolicy.Abort)
					{
						throw new NotEnoughBytesException("Chunk ID cannot be read since the reader's underlying stream doesn't have enough bytes.", 4L, (long)text.Length);
					}
					if (notEnoughBytesPolicy == NotEnoughBytesPolicy.Ignore)
					{
						return null;
					}
				}
				if (!(text == "MThd"))
				{
					if (!(text == "MTrk"))
					{
						midiChunk = MidiFile.TryCreateChunk(text, settings.CustomChunkTypes);
					}
					else
					{
						midiChunk = new TrackChunk();
					}
				}
				else
				{
					midiChunk = new HeaderChunk();
				}
				if (midiChunk == null)
				{
					switch (settings.UnknownChunkIdPolicy)
					{
					case UnknownChunkIdPolicy.ReadAsUnknownChunk:
						midiChunk = new UnknownChunk(text);
						break;
					case UnknownChunkIdPolicy.Skip:
					{
						uint num = reader.ReadDword();
						reader.Position += (long)((ulong)num);
						return null;
					}
					case UnknownChunkIdPolicy.Abort:
						throw new UnknownChunkException("'" + text + "' chunk ID is unknown.", text);
					}
				}
				if (midiChunk is TrackChunk && expectedTrackChunksCount != null)
				{
					int? num2 = expectedTrackChunksCount;
					if (actualTrackChunksCount >= num2.GetValueOrDefault() & num2 != null)
					{
						MidiFile.ReactOnUnexpectedTrackChunksCount(settings.UnexpectedTrackChunksCountPolicy, actualTrackChunksCount, expectedTrackChunksCount.Value);
						ExtraTrackChunkPolicy extraTrackChunkPolicy = settings.ExtraTrackChunkPolicy;
						if (extraTrackChunkPolicy != ExtraTrackChunkPolicy.Read && extraTrackChunkPolicy == ExtraTrackChunkPolicy.Skip)
						{
							uint num3 = reader.ReadDword();
							reader.Position += (long)((ulong)num3);
							return null;
						}
					}
				}
				midiChunk.Read(reader, settings);
			}
			catch (NotEnoughBytesException exception)
			{
				MidiFile.ReactOnNotEnoughBytes(settings.NotEnoughBytesPolicy, exception);
			}
			catch (EndOfStreamException exception2)
			{
				MidiFile.ReactOnNotEnoughBytes(settings.NotEnoughBytesPolicy, exception2);
			}
			return midiChunk;
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x00017C9D File Offset: 0x00015E9D
		private static void ReactOnUnexpectedTrackChunksCount(UnexpectedTrackChunksCountPolicy policy, int actualTrackChunksCount, int expectedTrackChunksCount)
		{
			if (policy != UnexpectedTrackChunksCountPolicy.Ignore && policy == UnexpectedTrackChunksCountPolicy.Abort)
			{
				throw new UnexpectedTrackChunksCountException(string.Format("Count of track chunks is {0} while {1} expected.", actualTrackChunksCount, expectedTrackChunksCount), actualTrackChunksCount, expectedTrackChunksCount);
			}
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x00017CC4 File Offset: 0x00015EC4
		private static void ReactOnNotEnoughBytes(NotEnoughBytesPolicy policy, Exception exception)
		{
			if (policy == NotEnoughBytesPolicy.Abort)
			{
				throw new NotEnoughBytesException("MIDI file cannot be read since the reader's underlying stream doesn't have enough bytes.", exception);
			}
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x00148DE0 File Offset: 0x00146FE0
		private static MidiChunk TryCreateChunk(string chunkId, ChunkTypesCollection chunksTypes)
		{
			Type type = null;
			if (chunksTypes != null && chunksTypes.TryGetType(chunkId, out type) && MidiFile.IsChunkType(type))
			{
				return (MidiChunk)Activator.CreateInstance(type);
			}
			return null;
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x00017CD5 File Offset: 0x00015ED5
		private static bool IsChunkType(Type type)
		{
			return type != null && type.IsSubclassOf(typeof(MidiChunk)) && type.GetConstructor(Type.EmptyTypes) != null;
		}

		// Token: 0x04000BBC RID: 3004
		private const string RiffChunkId = "RIFF";

		// Token: 0x04000BBD RID: 3005
		private const int RmidPreambleSize = 12;

		// Token: 0x04000BBE RID: 3006
		private ushort? _originalFormat;
	}
}
