using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Media {
	public sealed class MediaQueue {
		public Song ActiveSong { get { throw new NotImplementedException( ); } }
		public int ActiveSongIndex { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public int Count { get { throw new NotImplementedException( ); } }
		public Song this[int index] { get { throw new NotImplementedException( ); } }
	}
}
