﻿

/* Напишите алгоритм, пределяющий наличие выхода из лабиринта и выводящий
           * на экран координаты точки выхода если таковые имеются. */

using Labyrynth;

int[,] labirynth = new int[,]
{
                {1, 1, 1, 1, 1, 1, 1, 1 },
                {1, 0, 0, 0, 0, 0, 0, 1 },
                {1, 0, 1, 1, 1, 1, 0, 1 },
                {0, 0, 0, 0, 1, 1, 0, 2 },
                {1, 1, 0, 0, 1, 1, 1, 1 },
                {1, 1, 1, 1, 1, 1, 1, 1 },
                {1, 1, 1, 1, 1, 1, 1, 1 }
};

Console.WriteLine(new Labirint().HasExit(0, 3, labirynth));



