using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public class DualTextureEffect : Effect, IEffectMatrices, IEffectFog {
		protected DualTextureEffect(DualTextureEffect cloneSource) : base(cloneSource) { throw new NotImplementedException( ); }
		public DualTextureEffect(GraphicsDevice device) : base(device, new byte[0]) { throw new NotImplementedException( ); }

		public override Effect Clone( ) { throw new NotImplementedException( ); }
		protected internal override void OnApply( ) { throw new NotImplementedException( ); }

		public float Alpha { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Vector3 DiffuseColor { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Vector3 FogColor { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public bool FogEnabled { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float FogEnd { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float FogStart { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Matrix Projection { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Texture2D Texture { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Texture2D Texture2 { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public bool VertexColorEnabled { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Matrix View { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Matrix World { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
	}
}
