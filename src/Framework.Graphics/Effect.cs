using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public class Effect : GraphicsResource {
		protected Effect(Effect cloneSource) { throw new NotImplementedException( ); }
		public Effect(GraphicsDevice graphicsDevice, byte[] effectCode) { throw new NotImplementedException( ); }

		public virtual Effect Clone( ) { throw new NotImplementedException( ); }
		protected override void Dispose(bool disposing) { throw new NotImplementedException( ); }
		protected internal virtual void OnApply( ) { throw new NotImplementedException( ); }

		public EffectTechnique CurrentTechnique { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public EffectParameterCollection Parameters { get { throw new NotImplementedException( ); } }
		public EffectTechniqueCollection Techniques { get { throw new NotImplementedException( ); } }
	}
}
