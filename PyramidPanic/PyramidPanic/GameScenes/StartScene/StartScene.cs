// Met using kan je een XNA codebibliotheek toevoegen en gebruiken in je class
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidPanic
{
    public class StartScene : IState // De class StartScene implementeert de interface IState
    {
        //Fields van de class StartScene
        private PyramidPanic game;
        
        //maak een variable (reference) aan van de Image class genaamd background
        private Image background, title;

        //Maak een variable (reference) aan van de Menu class genaamd menu
        private Menu menu;

        // Constructor van de StartScene-class krijgt een object game mee van het type PyramidPanic
        public StartScene(PyramidPanic game)
        {
            this.game = game;
            //roep de initialize methode aan
            this.Initialize();
        }

        // Initialize methode. Deze methode initialiseert (geeft startwaarden aan variabelen).
        // Void wil zeggen dat er niets teruggegeven wordt.
        public void Initialize()
        {
            // roept de load content method aan
            this.LoadContent();
        }

        // LoadContent methode. Deze methode maakt nieuwe objecten aan van de verschillende
        // classes.
        public void LoadContent()
        {
            //Nu maken we twee object (instantie) van de class Image
            this.background = new Image(this.game, @"Startscene\Background", new Vector2(0f, 0f));
            this.title = new Image(this.game, @"Startscene\Title",new Vector2(100f, 30f));
            this.menu = new Menu(this.game);
        }

        // Update methode. Deze methode wordt normaal 60 maal per seconde aangeroepen.
        // en update alle variabelen, methods enz.......
        public void Update(GameTime gameTime)
        {
            this.menu.update(gameTime);
       
        }

        // Draw methode. Deze methode wordt normaal 60 maal per seconde aangeroepen en
        // tekent de textures op het canvas
        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.Purple);
            //roep de draw method aan van het background object
            this.background.Draw(gameTime);

            //roep de draw method aan van het title object
            this.title.Draw(gameTime);

            //roep de draw method aan van het method subject
            this.menu.draw(gameTime);
        }
    }
}
