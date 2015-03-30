using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Content {
	public abstract class ContentTypeReader<T> : ContentTypeReader {
		protected ContentTypeReader( ) : base(typeof(T)) { throw new NotImplementedException( ); }
		protected internal override object Read(ContentReader input, object existingInstance) { throw new NotImplementedException( ); }
		protected internal abstract T Read(ContentReader input, T existingInstance);
	}
}
