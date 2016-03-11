using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PongGamee
{
	public class Powerup : GameObject
	{
		public Powerup (Game1 game, Color color, Vector2 Position) :base (game,color,Position)
		{
			_Texture = game.Content.Load<Texture2D>("Powerup");
			_Speed = new Vector2 (3, 4);
		}
		/*
		public void PowHit(){
			_Speed *= -1;
		}
		public void PowNotHit(){
			_Speed *= 1;
		}
		*/
		public void BoundingBox(){
			if (_Position.X + _Texture.Width > _g.GraphicsDevice.Viewport.Width) {
				_Speed.X *= -1;
			}
			if (_Position.X < 0) {
				_Speed.X *= -1;
			}
			if (_Position.Y < 0) {
				_Speed.Y *= -1;
			}

			if (_Position.Y + _Texture.Height > _g.GraphicsDevice.Viewport.Height) {
				_Speed.Y *= -1;
			}
		}
		public void Draw(SpriteBatch spritebatch){

			spritebatch.Draw(_Texture, _Position, _Color);
		}
	}
}

