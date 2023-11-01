using System;

internal class Program
{
    static Dictionary<ConsoleKey, int[]> octaveDictionary = new Dictionary<ConsoleKey, int[]>
    {
        { ConsoleKey.F2, new int[] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 } },
        { ConsoleKey.F5, new int[] { 523, 554, 587, 622, 659, 698, 739, 784, 830, 880, 932, 987 } },
        { ConsoleKey.F6, new int[] { 1047, 1109, 1175, 1245, 1319, 1480, 1568, 1661, 1760, 1865, 1976 } }
    };

    static int[] Octave(ConsoleKey oct)
    {
        if (octaveDictionary.TryGetValue(oct, out int[] octave))
        {
            return octave;
        }
        else
        {
            return new int[12];
        }
    }

    static void Main()
    {
        Console.WriteLine("Выбор октавы, F2,F5,F6. \nZ,S,X,D,C,V,G,B,H,N,J,M"); //Z=C, S=C#, X=D, D=D#, C=E, V=F, G=F#, B=G, H=G#, N=A, J=A#, M=H
        ConsoleKey Chooser = ConsoleKey.F2;

        while (true)
        {
            ConsoleKeyInfo Note = Console.ReadKey(true);

            if (Note.Key == ConsoleKey.Z) Beep(0, Chooser);
            else if (Note.Key == ConsoleKey.S) Beep(1, Chooser);
            else if (Note.Key == ConsoleKey.X) Beep(2, Chooser);
            else if (Note.Key == ConsoleKey.D) Beep(3, Chooser);
            else if (Note.Key == ConsoleKey.C) Beep(4, Chooser);
            else if (Note.Key == ConsoleKey.V) Beep(5, Chooser);
            else if (Note.Key == ConsoleKey.G) Beep(6, Chooser);
            else if (Note.Key == ConsoleKey.B) Beep(7, Chooser);
            else if (Note.Key == ConsoleKey.H) Beep(8, Chooser);
            else if (Note.Key == ConsoleKey.N) Beep(9, Chooser);
            else if (Note.Key == ConsoleKey.J) Beep(10, Chooser);
            else if (Note.Key == ConsoleKey.M) Beep(11, Chooser);
            else if (Note.Key == ConsoleKey.Escape) Environment.Exit(0);
            else Chooser = Note.Key;
        }
    }

    static void Beep(short WhatNotePlay, ConsoleKey Choise)
    {
        Console.Clear();
        Console.WriteLine("Играйте!");
        int[] Plaing = Octave(Choise);
        Console.Beep(Plaing[WhatNotePlay], 200);
    }
}