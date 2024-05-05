using System;
using AljabarLibraries;

class Program
{
    static void Main(String[] args)
    {
        double[] hasilAkar = Aljabar.AkarPersamaanKuadrat([1, -3, -10]);
        foreach (var item in hasilAkar)
        {
            Console.Write(item + ", ");
        }

        Console.WriteLine();

        double[] hasilKuadrat = Aljabar.HasilKuadrat([2, -3]);
        foreach (var item in hasilKuadrat)
        {
            Console.Write(item + ", ");
        }
    }
}