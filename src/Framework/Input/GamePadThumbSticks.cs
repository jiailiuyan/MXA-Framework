using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Input {
	public struct GamePadThumbSticks {
		public GamePadThumbSticks(Vector2 leftThumbstick, Vector2 rightThumbstick) { throw new NotImplementedException( ); }

		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }

		public static bool operator !=(GamePadThumbSticks left, GamePadThumbSticks right) { throw new NotImplementedException( ); }
		public static bool operator ==(GamePadThumbSticks left, GamePadThumbSticks right) { throw new NotImplementedException( ); }

		public Vector2 Left { get { throw new NotImplementedException( ); } }
		public Vector2 Right { get { throw new NotImplementedException( ); } }
	}
}
