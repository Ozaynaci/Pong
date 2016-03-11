using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PongGamee
{
	public class Ball: GameObject
	{

		public Ball (Game1 game, Color color, Vector2 Position, Vector2 sp): base(game,color,Position)
		{
			_Texture = game.Content.Load<Texture2D>("ball");
			_Speed = sp;
		}
		/*
		public void Hit(){
			_Speed *= -1;
		}
		public void NotHit(){
			_Speed *= 1;
		}
		*/
			/*
			if (_Position.X = _g.GraphicsDevice.Viewport.Height - _Texture.Height){
				_Speed *= -1;
			}
			*/
		public void BoundingBox(){
			if (_Position.X + _Texture.Width > _g.GraphicsDevice.Viewport.Width) {
				_Position = new Vector2 (300, 300);
				_Speed.X *= -1;
			}
			if (_Position.X < 0) {
				_Position = new Vector2 (300, 300);
				_Speed *= -1;
			}
			if (_Position.Y < 0) {
				_Speed.Y *= -1;
			}

			if (_Position.Y + _Texture.Height > _g.GraphicsDevice.Viewport.Height) {
				_Speed.Y *= -1;
			}
		}
		/*
		public Vector2 BallSpe(){
			return _Speed;
		}
		public Vector2 BallPos(){
			return _Position;
		}
		public Texture2D BallTex(){
			return _Texture;
		}
		*/
		public void Draw(SpriteBatch spritebatch){
			spritebatch.Draw(_Texture, _Position, _Color);
		}
	}
}

