using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Input {
	public static class Mouse {
		public static MouseState GetState( ) { throw new NotImplementedException( ); }
		public static void SetPosition(int x, int y) { throw new NotImplementedException( ); }

		public static IntPtr WindowHandle { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
	}
}
