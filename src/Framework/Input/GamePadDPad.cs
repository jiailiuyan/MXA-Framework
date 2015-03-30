using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Input {
	public struct GamePadDPad {
		public GamePadDPad(ButtonState upValue, ButtonState downValue, ButtonState leftValue, ButtonState rightValue) { throw new NotImplementedException( ); }

		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }

		public static bool operator !=(GamePadDPad left, GamePadDPad right) { throw new NotImplementedException( ); }
		public static bool operator ==(GamePadDPad left, GamePadDPad right) { throw new NotImplementedException( ); }

		public ButtonState Down { get { throw new NotImplementedException( ); } }
		public ButtonState Left { get { throw new NotImplementedException( ); } }
		public ButtonState Right { get { throw new NotImplementedException( ); } }
		public ButtonState Up { get { throw new NotImplementedException( ); } }
	}
}
