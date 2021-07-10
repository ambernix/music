using System;
using System.Collections.Generic;

namespace MusicApp
{
    
    class Program
    {
        /// <summary> Program will intake lines of music (notes written out for now) and the key.
        /// Then will use the key to scale and then will translate notes to shapenote names.
        /// Later plans:
        /// Conduct key changes
        /// Print shapes
        /// Take more complex keys with different patterns
        /// Take more complex lines (not just the 7 note scale)
        /// Explore MIDI files and if they be used here.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Current TODOs:
            // 1. Break out of main program and build classes/interfaces 
            // 2. Build scale depending on key - use pattern Root Whole W Half W W W H/R

            // Main array from which values will print out
            string[] shapeNotes = { "do", "re", "me", "fa", "so", "la", "ti"};

            // Array of notes that will be manipulated depending on the key
            //string[] allNotes = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

            // Values that will eventually become input from user/file

            //string key = "C" - build out so key can be changed; will change order of keyScale array

            string[] keyScale = { "C", "D", "E", "F", "G", "A", "B" };
            string[] line = { "G", "C", "A", "B", "C", "D", "C" };
            string[] outputLine = new string[line.Length];
            
            for (int i = 0; i < line.Length; i++)
            {
                // Switch to making the scale and shapeNotes key/value pairs?
                outputLine[i] = shapeNotes[Array.IndexOf(keyScale, line[i])];
                Console.Write(outputLine[i] + " ");
            }

        }
    }
}
