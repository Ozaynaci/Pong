using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace PongGamee
{
	public class GameObject
	{
		protected Color _Color;
		protected Texture2D _Texture;
		protected Vector2 _Position;
		protected Vector2 _Speed;
		protected Game1 _g;

		public GameObject (Game1 game, Color color, Vector2 Position){

			_Color = color;
			_Position = Position;
			_g = game;
		}
		public void Update(){

			_Position += _Speed;
		}
		public void Bounce()
		{
			_Speed.X *= -1;
		}
		public Rectangle Box()
		{
			Rectangle rectangle = new Rectangle((int)_Position.X, (int)_Position.Y, _Texture.Width, _Texture.Height);

			return rectangle;
		}
	}
}

