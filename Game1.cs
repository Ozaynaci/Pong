using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

namespace PongGamee
{
	public class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;
		private World _World;

		private Paddle _Paddle;
		private Ball _Ball;


		public Game1 ()
		{
			graphics = new GraphicsDeviceManager (this);
			Content.RootDirectory = "Content";	            
			graphics.IsFullScreen = false;	
			graphics.PreferredBackBufferWidth = 800;
			graphics.PreferredBackBufferHeight = 600;
		}


		protected override void Initialize ()
		{
			// TODO: Add your initialization logic here
			base.Initialize ();

			_World = new World (this);

			Settings.UseMusic = false;
			Settings.UseSound = true;
			/*
		int Optellen = Calculator.OpTellen (3, 5);
			Console.WriteLine (Optellen + " is de uitkomst");

		int Aftrekken = Calculator.OpTellen (20, 3);
			Console.WriteLine (Aftrekken + " is de uitkomst");

		int Delen = Calculator.Delen (10, 2);
			Console.WriteLine (Delen + " is de uitkomst");

		int Vermenigvuldigen = Calculator.Vermenigvuldigen (3, 6);
			Console.WriteLine (Vermenigvuldigen + " is de uitkomst");
		*/
		}
		protected override void LoadContent()
		{
			spriteBatch = new SpriteBatch(GraphicsDevice);
		}
		protected override void Update (GameTime gameTime)
		{
			_World.Update ();
		}
		protected override void Draw (GameTime gameTime)
		{
			graphics.GraphicsDevice.Clear (Color.IndianRed);
			spriteBatch.Begin();
			_World.Draw(spriteBatch);
			spriteBatch.End();
			base.Draw (gameTime);
		}
	}
}

