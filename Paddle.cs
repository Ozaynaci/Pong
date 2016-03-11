
using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace PongGamee
{
	public class Paddle: GameObject
	{
		private string _string;

		public Paddle (Game1 game, Color color, Vector2 Position, string player) : base (game, color, Position)
		{
			_Texture = game.Content.Load<Texture2D>("paddle");
			_Speed = new Vector2 (0, 6);
			_string = player;
		}
		public void Update ()
		{
			KeyboardState keyboardState = Keyboard.GetState ();

			if (_string == "Player") {

			if (keyboardState.IsKeyDown (Keys.W)) {
				_Position -= _Speed;
			}
			if (keyboardState.IsKeyDown (Keys.S)) {
				_Position += _Speed;
			}
			}
			if (_string == "Enemy") {

				if (keyboardState.IsKeyDown (Keys.Up)) {
					_Position -= _Speed;
				}
				if (keyboardState.IsKeyDown (Keys.Down)) {
					_Position += _Speed;
				}
			}
			if (_Position.Y < 0) {
				_Position.Y = 0; 
			}
			if (_Position.Y + _Texture.Height >_g.GraphicsDevice.Viewport.Height ) {
				_Position.Y = _g.GraphicsDevice.Viewport.Height - _Texture.Height; 
			}
		}
		/*
		public Vector2 PadPos(){
			return _Position;
		}
		public Texture2D PadTex(){
			return _Texture;
		}

		public Vector2 EnemyPos(){
			return _EnemyPos;
		}
		public Texture2D EnemyTex(){
			return _Texture;
		}
		*/
		public void Draw(SpriteBatch spritebatch){
			spritebatch.Draw(_Texture, _Position, _Color);
		}


	}
}

