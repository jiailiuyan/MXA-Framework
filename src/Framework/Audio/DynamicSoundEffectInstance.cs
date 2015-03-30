using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Audio {
	public sealed class DynamicSoundEffectInstance : SoundEffectInstance {
		public DynamicSoundEffectInstance(int sampleRate, AudioChannels channels) { throw new NotImplementedException( ); }

		protected override void Dispose(bool disposing) { throw new NotImplementedException( ); }
		public TimeSpan GetSampleDuration(int sizeInBytes) { throw new NotImplementedException( ); }
		public int GetSampleSizeInBytes(TimeSpan duration) { throw new NotImplementedException( ); }
		public override void Play( ) { throw new NotImplementedException( ); }
		public void SubmitBuffer(byte[] buffer) { throw new NotImplementedException( ); }
		public void SubmitBuffer(byte[] buffer, int offset, int count) { throw new NotImplementedException( ); }


		public override bool IsLooped { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public int PendingBufferCount { get { throw new NotImplementedException( ); } }

		public event EventHandler<EventArgs> BufferNeeded;
	}
}
