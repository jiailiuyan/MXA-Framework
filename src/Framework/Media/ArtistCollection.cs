﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Media {
	public sealed class ArtistCollection : IEnumerable<Artist>, IEnumerable, IDisposable {
		public void Dispose( ) { throw new NotImplementedException( ); }
		public IEnumerator<Artist> GetEnumerator( ) { throw new NotImplementedException( ); }
		IEnumerator IEnumerable.GetEnumerator( ) { throw new NotImplementedException( ); }
		public int Count { get { throw new NotImplementedException( ); } }
		public bool IsDisposed { get { throw new NotImplementedException( ); } }
		public Artist this[int index] { get { throw new NotImplementedException( ); } }
	}
}
