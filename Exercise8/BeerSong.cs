using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class Beersong
    {
        int _bottleofBeer;

        public Beersong(int bottleofBeer)
        {
            _bottleofBeer = bottleofBeer;
        }

        public void Sing()
        {

            for(int i = 0; i < _bottleofBeer; i--)
            {
                Console.WriteLine($"{i} bottles of beer on the wall {i} bottles of beer is");
                if (i > 2)
                 Console.WriteLine($"Take one down and pass it around!{i - 1} bottles of beer on the wall");
                Console.WriteLine($"Take one down and pass it around!{i - 1} bottles of beer on the wall");

            }

            Console.WriteLine($"1 bottle of beer on the wall! bottle of beer of beer is");
            Console.WriteLine($"1 bottle of beer on the wall! bottle of beer of beer is");
        }



    }




}
    





    
