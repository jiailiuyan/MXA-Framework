using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Input {
	public struct GamePadTriggers {
		public GamePadTriggers(float leftTrigger, float rightTrigger) { throw new NotImplementedException( ); }

		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }

		public static bool operator !=(GamePadTriggers left, GamePadTriggers right) { throw new NotImplementedException( ); }
		public static bool operator ==(GamePadTriggers left, GamePadTriggers right) { throw new NotImplementedException( ); }

		public float Left { get { throw new NotImplementedException( ); } }
		public float Right { get { throw new NotImplementedException( ); } }
	}
}
