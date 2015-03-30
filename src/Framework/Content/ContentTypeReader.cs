using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Content {
	public abstract class ContentTypeReader {
		protected ContentTypeReader(Type targetType) { throw new NotImplementedException( ); }
		protected internal virtual void Initialize(ContentTypeReaderManager manager) { throw new NotImplementedException( ); }
		protected internal abstract object Read(ContentReader input, object existingInstance);

		public virtual bool CanDeserializeIntoExistingObject { get { throw new NotImplementedException( ); } }
		public Type TargetType { get { throw new NotImplementedException( ); } }
		public virtual int TypeVersion { get { throw new NotImplementedException( ); } }
	}
}
