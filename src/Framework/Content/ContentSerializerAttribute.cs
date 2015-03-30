using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Content {
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class ContentSerializerAttribute : Attribute {
		public ContentSerializerAttribute( ) { throw new NotImplementedException( ); }

		public ContentSerializerAttribute Clone( ) { throw new NotImplementedException( ); }

		public bool AllowNull { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public string CollectionItemName { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public string ElementName { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public bool FlattenContent { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public bool HasCollectionItemName { get { throw new NotImplementedException( ); } }
		public bool Optional { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public bool SharedResource { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
	}
}
