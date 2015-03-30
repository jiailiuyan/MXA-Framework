using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Input {
	public struct GamePadButtons {
		public GamePadButtons(Buttons buttons) { throw new NotImplementedException( ); }

		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }

		public static bool operator !=(GamePadButtons left, GamePadButtons right) { throw new NotImplementedException( ); }
		public static bool operator ==(GamePadButtons left, GamePadButtons right) { throw new NotImplementedException( ); }

		public ButtonState A { get { throw new NotImplementedException( ); } }
		public ButtonState B { get { throw new NotImplementedException( ); } }
		public ButtonState Back { get { throw new NotImplementedException( ); } }
		public ButtonState BigButton { get { throw new NotImplementedException( ); } }
		public ButtonState LeftShoulder { get { throw new NotImplementedException( ); } }
		public ButtonState LeftStick { get { throw new NotImplementedException( ); } }
		public ButtonState RightShoulder { get { throw new NotImplementedException( ); } }
		public ButtonState RightStick { get { throw new NotImplementedException( ); } }
		public ButtonState Start { get { throw new NotImplementedException( ); } }
		public ButtonState X { get { throw new NotImplementedException( ); } }
		public ButtonState Y { get { throw new NotImplementedException( ); } }
	}
}
