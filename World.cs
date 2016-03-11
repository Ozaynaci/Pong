using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace PongGamee
{

	public class World
	{
		private Paddle _Paddle;
		private Paddle _Paddle2;
		private List<Ball> _gameBalls = new List<Ball> ();
		private Random r = new Random ();
		private Powerup _Pow;
		private Game1 _game;


		public World (Game1 g)
		{
			_Paddle = new Paddle (g, Color.White, new Vector2(30, 190), "Player");
			_Paddle2 = new Paddle (g, Color.White, new Vector2 (755, 190), "Enemy");
			_Pow = new Powerup (g, Color.White, new Vector2 (200, 400));

			_game = g;
			for (int i = 0; i < 1; i++) {
				Ballcreation ();
			}
		}
			
		public void Ballcreation(){
			for (int i = 0; i < 1; i++) {

				int intxspeed = r.Next(150,200) - 5;
				int intyspeed = r.Next(150,150);

				float xfloat = intxspeed / 40f;
				float yfloat = intyspeed / 40f;		
				_gameBalls.Add (new Ball (_game, Color.White, new Vector2(100, 100),new Vector2 (xfloat, yfloat)));
			}
		}

		public void Update ()
		{
			_Paddle.Update();
			_Paddle2.Update ();
			_Pow.Update ();

			/*
			Vector2 padPos = _Paddle.PadPos();
			Texture2D padTex = _Paddle.PadTex ();
			Vector2 padPos2 = _Paddle2.EnemyPos ();
			Texture2D padTex2 = _Paddle.EnemyTex ();
			Vector2 balPos = _gameBalls.BallPos ();
			Texture2D balTex = _gameBalls.BallTex ();
			Vector2 balPos2 = _Ball2.BallPos ();
			if (balPos.X < padPos.X + padTex.Width){
				_gameBalls.Hit ();
			}
			if (balPos.Y > padPos.Y - padTex.Height){
				_gameBalls.NotHit ();
			}
			*/

			if (_Pow.Box().Intersects(_Paddle.Box())) {
				//_Pow.PowHit ();
				Ballcreation ();
				Console.WriteLine ("Powerup has been hit!");
			}

			if (_Pow.Box().Intersects(_Paddle2.Box())) {
				//_Pow.PowHit ();
				Ballcreation ();
				Console.WriteLine ("Powerup has been hit!");
			}
			/*	
			if (balPos2.X < padPos.X + padTex.Width) {
				_Ball2.Hit ();
			}
			if (balPos2.Y > balPos2.Y - padTex.Height) {
				_Ball2.NotHit ();
			}
			*/
			foreach(Ball b in _gameBalls){
				b.Update();
				b.BoundingBox ();
				if (_Paddle.Box().Intersects(b.Box())) { 
					b.Bounce();
				}
				if (_Paddle2.Box().Intersects(b.Box())) { b.Bounce(); }
			}

			_Pow.BoundingBox ();

			if (_Paddle.Box().Intersects(_Pow.Box())) { _Pow.Bounce(); }
			if (_Paddle2.Box().Intersects(_Pow.Box())) { _Pow.Bounce(); }
		}
		public void Draw(SpriteBatch spritebatch){
			foreach(Ball b in _gameBalls){
				b.Draw(spritebatch);
			}
			_Paddle.Draw (spritebatch);
			_Paddle2.Draw (spritebatch);
			_Pow.Draw (spritebatch);
		}

	}
}
