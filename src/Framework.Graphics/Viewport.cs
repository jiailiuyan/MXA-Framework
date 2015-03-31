using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public struct Viewport {
		public Viewport(int x, int y, int width, int height) { throw new NotImplementedException( ); }
		public Viewport(Rectangle bounds) { throw new NotImplementedException( ); }

		public Vector3 Project(Vector3 source, Matrix projection, Matrix view, Matrix world) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public Vector3 Unproject(Vector3 source, Matrix projection, Matrix view, Matrix world) { throw new NotImplementedException( ); }

		public float AspectRatio { get { throw new NotImplementedException( ); } }
		public Rectangle Bounds { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public int Height { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float MaxDepth { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float MinDepth { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Rectangle TitleSafeArea { get { throw new NotImplementedException( ); } }
		public int Width { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public int X { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public int Y { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
	}
}
