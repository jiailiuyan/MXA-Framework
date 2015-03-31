using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public interface IEffectFog {
		Vector3 FogColor { get; set; }
		bool FogEnabled { get; set; }
		float FogEnd { get; set; }
		float FogStart { get; set; }
	}
}
