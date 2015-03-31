using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public interface IGraphicsDeviceService {
		GraphicsDevice GraphicsDevice { get; }

		event EventHandler<EventArgs> DeviceCreated;
		event EventHandler<EventArgs> DeviceDisposing;
		event EventHandler<EventArgs> DeviceReset;
		event EventHandler<EventArgs> DeviceResetting;
	}
}
