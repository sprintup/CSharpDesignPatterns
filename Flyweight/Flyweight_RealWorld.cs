using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class Flyweight_RealWorld
    {
        public static void Run()
        {
            Console.WriteLine("This real-world code demonstrates the Flyweight pattern in which a relatively small number of Character objects is shared many times by a document that has potentially many characters.");
            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            int pointSize = 10;

            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }
            /*
                A (pointsize 11)
                A (pointsize 12)
                Z (pointsize 13)
                Z (pointsize 14)
                B (pointsize 15)
                B (pointsize 16)
                Z (pointsize 17)
                B (pointsize 18)
             */
        }
        class CharacterFactory
        {
            private Dictionary<char, Character> _characters = new Dictionary<char, Character>();

            public Character GetCharacter(char key)
            {
                Character character = null;
                if (_characters.ContainsKey(key))
                {
                    character = _characters[key];
                }
                else
                {
                    switch (key)
                    {
                        case 'A': character = new CharacterA(); break;
                        case 'B': character = new CharacterB(); break;
                        case 'Z': character = new CharacterZ(); break;
                    }
                    _characters.Add(key, character);
                }
                return character;
            }
        }

        abstract class Character
        {
            protected char symbol;
            protected int width;
            protected int height;
            protected int ascent;
            protected int descent;
            protected int pointSize;

            public abstract void Display(int pointSize);
        }

        class CharacterA : Character
        {
            public CharacterA()
            {
                this.symbol = 'A';
                this.height = 100;
                this.width = 120;
                this.ascent = 70;
                this.descent = 0;
            }

            public override void Display(int pointSize)
            {
                this.pointSize = pointSize;
                Console.WriteLine(this.symbol + " (pointsize " + this.pointSize + ")");
            }
        }

        class CharacterB : Character
        {
            public CharacterB()
            {
                this.symbol = 'B';
                this.height = 100;
                this.width = 140;
                this.ascent = 72;
                this.descent = 0;
            }

            public override void Display(int pointSize)
            {
                this.pointSize = pointSize;
                Console.WriteLine(this.symbol + " (pointsize " + this.pointSize + ")");
            }
        }

        class CharacterZ : Character
        {
            public CharacterZ()
            {
                this.symbol = 'Z';
                this.height = 100;
                this.width = 100;
                this.ascent = 68;
                this.descent = 0;
            }

            public override void Display(int pointSize)
            {
                this.pointSize = pointSize;
                Console.WriteLine(this.symbol + " (pointsize " + this.pointSize + ")");
            }
        }
    }
}
