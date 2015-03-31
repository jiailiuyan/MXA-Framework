using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Input {
	public struct MouseState {
		public MouseState(int x, int y, int scrollWheel, ButtonState leftButton, ButtonState middleButton, ButtonState rightButton, ButtonState xButton1, ButtonState xButton2) { throw new NotImplementedException( ); }

		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }

		public ButtonState LeftButton { get { throw new NotImplementedException( ); } }
		public ButtonState MiddleButton { get { throw new NotImplementedException( ); } }
		public ButtonState RightButton { get { throw new NotImplementedException( ); } }
		public int ScrollWheelValue { get { throw new NotImplementedException( ); } }
		public int X { get { throw new NotImplementedException( ); } }
		public ButtonState XButton1 { get { throw new NotImplementedException( ); } }
		public ButtonState XButton2 { get { throw new NotImplementedException( ); } }
		public int Y { get { throw new NotImplementedException( ); } }
	}
}
