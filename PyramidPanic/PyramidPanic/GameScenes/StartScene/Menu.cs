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
    public class Menu
    {
        //Fields

        //Maak een enumaration voor de buttons die op het scherm te zien zijn 
        private enum Buttons { Start, Load, Help, Scores, Quit }

        //maak een variable van het type uttons en geef hem de waarde buttons.start

        private Buttons buttonActive = Buttons.Start;
        
        //maak een variable (reference) van het Image
        private Image start;
        private Image load;
        private Image help;
        private Image scores;
        private Image quit;

        //maak een variable aan activeColor. Dit is de kleur van de actieve knop
        private Color activeColor = Color.Gold;

        // maak een variable (reference) van het type PyramidPanic

        private PyramidPanic game;

        // maak een variable van het type list <Image>
        private List<Image> buttonList;

        //Constructor
        public Menu(PyramidPanic game)
        {
            this.game = game;
            this.Initialize();
        }

        public void Initialize()
        {
            this.LoadContent();
        }

        public void LoadContent()
        {
            //maak een instantie aan van de List<Image> type en stop deze in de variable this.
            this.buttonList = new List<Image>();
            this.buttonList.Add(this.start = new Image(this.game, @"Startscene\Button_start", new Vector2(20f, 440f)));
            this.buttonList.Add(this.load = new Image(this.game, @"Startscene\Button_load", new Vector2(140f, 440f)));
            this.buttonList.Add(this.help = new Image(this.game, @"Startscene\Button_help", new Vector2(260f, 440f)));
            this.buttonList.Add(this.scores = new Image(this.game, @"Startscene\Button_scores", new Vector2(380f, 440f)));
            this.buttonList.Add(this.quit = new Image(this.game, @"Startscene\Button_quit", new Vector2(500f, 440f)));    
        }


        //Update
        public void update(GameTime gameTime)
        {
            
            /* deze if - instructie checked of er op de rechterpijltoets wordt gedrukt.
             * de actie die daarop volgt is het ophogen van de variable buttonActive
             */

            if (Input.EdgeDetectKeyDown(Keys.Right))
            {
                this.buttonActive++;
            }

            if (Input.EdgeDetectKeyDown(Keys.Left))
            {
                this.buttonActive--;
            }

            /* We doorlopen het this.button.list object (type List<Image> this.buttonList met een foreacht instructie
             * en we roepen ieder image-object de propertie Color op en geven deze de
             * waarde Color.White.
             */
            foreach (Image image in this.buttonList)
            {
                image.Color = Color.White;
            }

            //maak een switch case instructie voor de variable buttonActive
            switch (this.buttonActive)
            {
                case Buttons.Start:
                    this.start.Color = this.activeColor;
                    break;
                case Buttons.Load:
                    this.load.Color = this.activeColor;
                    break;
                case Buttons.Help:
                    this.help.Color = this.activeColor;
                    break;
                case Buttons.Scores:
                    this.scores.Color = this.activeColor;
                    break;
                case Buttons.Quit:
                    this.quit.Color = this.activeColor;
                    break;
               }
        }

        //Draw
        public void draw(GameTime gameTime)
        {
            this.start.Draw(gameTime);
            this.load.Draw(gameTime);
            this.help.Draw(gameTime);
            this.scores.Draw(gameTime);
            this.quit.Draw(gameTime);
        }

    }
}
