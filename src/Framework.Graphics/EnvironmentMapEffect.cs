using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public class EnvironmentMapEffect : Effect, IEffectMatrices, IEffectLights, IEffectFog {
		protected EnvironmentMapEffect(EnvironmentMapEffect cloneSource) : base(cloneSource) { throw new NotImplementedException( ); }
		public EnvironmentMapEffect(GraphicsDevice device) : base(device, new byte[0]) { throw new NotImplementedException( ); }

		public override Effect Clone( ) { throw new NotImplementedException( ); }
		public void EnableDefaultLighting( ) { throw new NotImplementedException( ); }
		protected internal override void OnApply( ) { throw new NotImplementedException( ); }

		public float Alpha { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Vector3 AmbientLightColor { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Vector3 DiffuseColor { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public DirectionalLight DirectionalLight0 { get { throw new NotImplementedException( ); } }
		public DirectionalLight DirectionalLight1 { get { throw new NotImplementedException( ); } }
		public DirectionalLight DirectionalLight2 { get { throw new NotImplementedException( ); } }
		public Vector3 EmissiveColor { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public TextureCube EnvironmentMap { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float EnvironmentMapAmount { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Vector3 EnvironmentMapSpecular { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Vector3 FogColor { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public bool FogEnabled { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float FogEnd { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float FogStart { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float FresnelFactor { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		bool IEffectLights.LightingEnabled { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Matrix Projection { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Texture2D Texture { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Matrix View { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Matrix World { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
	}
}
