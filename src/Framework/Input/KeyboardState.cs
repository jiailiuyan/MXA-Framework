using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Input {
	public struct KeyboardState {
		public KeyboardState(params Keys[] keys) { throw new NotImplementedException( ); }

		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public Keys[] GetPressedKeys( ) { throw new NotImplementedException( ); }
		public bool IsKeyDown(Keys key) { throw new NotImplementedException( ); }
		public bool IsKeyUp(Keys key) { throw new NotImplementedException( ); }

		public static bool operator !=(KeyboardState a, KeyboardState b) { throw new NotImplementedException( ); }
		public static bool operator ==(KeyboardState a, KeyboardState b) { throw new NotImplementedException( ); }

		public KeyState this[Keys key] { get { throw new NotImplementedException( ); } }
	}
}
