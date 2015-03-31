using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public sealed class SpriteFont {
		public Vector2 MeasureString(string text) { throw new NotImplementedException( ); }
		public Vector2 MeasureString(StringBuilder text) { throw new NotImplementedException( ); }

		public ReadOnlyCollection<char> Characters { get { throw new NotImplementedException( ); } }
		public char? DefaultCharacter { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public int LineSpacing { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float Spacing { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
	}
}
