using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Content {
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public sealed class ContentSerializerTypeVersionAttribute : Attribute {
		public ContentSerializerTypeVersionAttribute(int typeVersion) { throw new NotImplementedException( ); }

		public int TypeVersion { get { throw new NotImplementedException( ); } }
	}
}
