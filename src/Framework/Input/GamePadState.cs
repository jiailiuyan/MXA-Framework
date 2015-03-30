using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Input {
	public struct GamePadState {
		public GamePadState(GamePadThumbSticks thumbSticks, GamePadTriggers triggers, GamePadButtons buttons, GamePadDPad dPad) { throw new NotImplementedException( ); }
		public GamePadState(Vector2 leftThumbStick, Vector2 rightThumbStick, float leftTrigger, float rightTrigger, params Buttons[] buttons) { throw new NotImplementedException( ); }

		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public bool IsButtonDown(Buttons button) { throw new NotImplementedException( ); }
		public bool IsButtonUp(Buttons button) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }

		public static bool operator !=(GamePadState left, GamePadState right) { throw new NotImplementedException( ); }
		public static bool operator ==(GamePadState left, GamePadState right) { throw new NotImplementedException( ); }

		public GamePadButtons Buttons { get { throw new NotImplementedException( ); } }
		public GamePadDPad DPad { get { throw new NotImplementedException( ); } }
		public bool IsConnected { get { throw new NotImplementedException( ); } }
		public int PacketNumber { get { throw new NotImplementedException( ); } }
		public GamePadThumbSticks ThumbSticks { get { throw new NotImplementedException( ); } }
		public GamePadTriggers Triggers { get { throw new NotImplementedException( ); } }
	}
}
