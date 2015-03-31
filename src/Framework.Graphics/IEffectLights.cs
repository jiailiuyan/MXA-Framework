using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public interface IEffectLights {
		void EnableDefaultLighting( );

		Vector3 AmbientLightColor { get; set; }
		DirectionalLight DirectionalLight0 { get; }
		DirectionalLight DirectionalLight1 { get; }
		DirectionalLight DirectionalLight2 { get; }
		bool LightingEnabled { get; set; }
	}
}
