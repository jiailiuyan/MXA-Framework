using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Input {
	public static class GamePad {
		public static GamePadCapabilities GetCapabilities(PlayerIndex playerIndex) { throw new NotImplementedException( ); }
		public static GamePadState GetState(PlayerIndex playerIndex) { throw new NotImplementedException( ); }
		public static GamePadState GetState(PlayerIndex playerIndex, GamePadDeadZone deadZoneMode) { throw new NotImplementedException( ); }
		public static bool SetVibration(PlayerIndex playerIndex, float leftMotor, float rightMotor) { throw new NotImplementedException( ); }
	}
}
