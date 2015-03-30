using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Audio {
	public sealed class Microphone {
		public readonly string Name;

		public int GetData(byte[] buffer) { throw new NotImplementedException( ); }
		public int GetData(byte[] buffer, int offset, int count) { throw new NotImplementedException( ); }
		public TimeSpan GetSampleDuration(int sizeInBytes) { throw new NotImplementedException( ); }
		public int GetSampleSizeInBytes(TimeSpan duration) { throw new NotImplementedException( ); }
		public void Start( ) { throw new NotImplementedException( ); }
		public void Stop( ) { throw new NotImplementedException( ); }

		public static ReadOnlyCollection<Microphone> All { get { throw new NotImplementedException( ); } }
		public TimeSpan BufferDuration { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public static Microphone Default { get { throw new NotImplementedException( ); } }
		public int SampleRate { get { throw new NotImplementedException( ); } }
		public MicrophoneState State { get { throw new NotImplementedException( ); } }

		public event EventHandler<EventArgs> BufferReady;
	}
}
