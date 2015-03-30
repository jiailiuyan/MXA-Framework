using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Content {
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ContentSerializerCollectionItemNameAttribute : Attribute {
		public ContentSerializerCollectionItemNameAttribute(string collectionItemName) { throw new NotImplementedException( ); }

		public string CollectionItemName { get { throw new NotImplementedException( ); } }
	}
}
