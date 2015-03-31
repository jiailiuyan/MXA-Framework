using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public class SpriteBatch : GraphicsResource {
		public SpriteBatch(GraphicsDevice graphicsDevice) { throw new NotImplementedException( ); }

		public void Begin( ) { throw new NotImplementedException( ); }
		public void Begin(SpriteSortMode sortMode, BlendState blendState) { throw new NotImplementedException( ); }
		public void Begin(SpriteSortMode sortMode, BlendState blendState, SamplerState samplerState, DepthStencilState depthStencilState, RasterizerState rasterizerState) { throw new NotImplementedException( ); }
		public void Begin(SpriteSortMode sortMode, BlendState blendState, SamplerState samplerState, DepthStencilState depthStencilState, RasterizerState rasterizerState, Effect effect) { throw new NotImplementedException( ); }
		public void Begin(SpriteSortMode sortMode, BlendState blendState, SamplerState samplerState, DepthStencilState depthStencilState, RasterizerState rasterizerState, Effect effect, Matrix transformMatrix) { throw new NotImplementedException( ); }
		protected override void Dispose(bool disposing) { throw new NotImplementedException( ); }
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Color color) { throw new NotImplementedException( ); }
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color) { throw new NotImplementedException( ); }
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, SpriteEffects effects, float layerDepth) { throw new NotImplementedException( ); }
		public void Draw(Texture2D texture, Vector2 position, Color color) { throw new NotImplementedException( ); }
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color) { throw new NotImplementedException( ); }
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth) { throw new NotImplementedException( ); }
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth) { throw new NotImplementedException( ); }
		public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color) { throw new NotImplementedException( ); }
		public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth) { throw new NotImplementedException( ); }
		public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth) { throw new NotImplementedException( ); }
		public void DrawString(SpriteFont spriteFont, System.Text.StringBuilder text, Vector2 position, Color color) { throw new NotImplementedException( ); }
		public void DrawString(SpriteFont spriteFont, System.Text.StringBuilder text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth) { throw new NotImplementedException( ); }
		public void DrawString(SpriteFont spriteFont, System.Text.StringBuilder text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth) { throw new NotImplementedException( ); }
		public void End( ) { throw new NotImplementedException( ); }
	}
}
