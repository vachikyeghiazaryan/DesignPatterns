using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.Example
{
    public abstract class TwoColorFlag
    {
        public void Draw()
        {
            DrawTopPart();
            DrawBottomPart();
        }

        protected abstract void DrawTopPart();

        protected abstract void DrawBottomPart();
    }

    public class PolandFlag : TwoColorFlag
    {
        protected override void DrawTopPart()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(new string(' ', 7));
            Console.ResetColor();
        }

        protected override void DrawBottomPart()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(new string(' ', 7));
            Console.ResetColor();
        }
    }

    public class UkraineFlag : TwoColorFlag
    {
        protected override void DrawTopPart()
        {
            Console.BackgroundColor  = ConsoleColor.Blue; 
            Console.WriteLine(new string(' ', 7));
            Console.ResetColor();
        }

        protected override void DrawBottomPart()
        {
            Console.BackgroundColor  = ConsoleColor.Yellow;
            Console.WriteLine(new string(' ', 7));
            Console.ResetColor();
        }
    }
}
