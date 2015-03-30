using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Media {
	public sealed class MediaSource {
		public static IList<MediaSource> GetAvailableMediaSources( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }

		public MediaSourceType MediaSourceType { get { throw new NotImplementedException( ); } }
		public string Name { get { throw new NotImplementedException( ); } }
	}
}
