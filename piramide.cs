using System;
namespace Piramide{
    public static class Piramide {
        public static int Piani( int mattoni )
        {
            int tmp = 0;
            int i = 0;

            //Nel ciclo for viene fatto il controllo per il valore di i successivo: se il valore di i^2 + tmp è
            //minore di mattoni, aggiunge a tutti gli effetti quel calcolo a tmp
            for (i = 1; tmp + (i*i) <= mattoni ; i+=2)
                tmp += (i*i);
            
            return i/2;
        }
        public static int Rimanenti( int mattoni )
        {
            int tmp = 0;
            for (int i = 1; tmp + (i*i) <= mattoni ; i+=2)
                tmp += (i*i);

            return mattoni - tmp;
        }

    }
}