# Piramide

### Consegna
Questo esercizio prevede che, dato un numero di mattoni per costruire una piramide a base quadrata, il programma, usando due funzioni diverse, calcoli quanti piani completi si possono fare con quei mattoni, e quanti sarebbero i mattoni rimanenti dopo la costruzione dell'ultimo piano. Per la risoluzione di questo esercizio si parte dal presupposto che la punta della piramide sia formata da 1 mattone. 

### Soluzione
La soluzione qua pubblicata prevede l'uso di un <b>ciclo for</b>, una variabile contatore <b>i</b> ed una variabile temporanea <b>tmp</b> che memorizza man mano quanti mattoni sono usati per i piani.
Essendo la punta della piramide formata da 1 blocco, ne consegue che nel piano sotto la piramide si avrà un quadrato di mattoni sopra il cui centro vi è la punta della piramide. Il quadrato, tuttavia, circonda la punta della piramide da tutti i lati: ne consegue che il lato del piano sotto la piramide sarà più lungo e più largo di due rispetto alla punta; la sua area, quindi quanti mattoni sono necessari per quel piano, siccome si tratta di una piramide a base quadrata, sarà data da lato^2. Nel caso in cui vi siano 3 piani, il piano subito sotto alla punta sarà come sopra descritto, mentre per quello sulla terra si potrà considerare il piano superiore come punta, e, applicato lo stesso ragionamento, i lati del piano terra saranno di due mattoni più lunghi rispetto a quelli del piano superiore.
<br>
#### Codice della funzione responsabile del numero di piani:
In questo codice, dopo la dichiarazione delle variabili necessarie si entra in un ciclo for nel quale il contatore parte da 1 ed incrementa di 2 ad ogni ciclo: la condizione secondo la quale cicla è che il valore contenuto nella variabile temporanea sommato al nuovo numero di mattoni necessari sia minore o uguale al numero di mattoni forniti: se la condizione si verifica tmp viene aggiornata, ed il tutto si ripete.
Nel caso in cui la condizione non si verifichi, quindi, la quantità di mattoni necessarria una volta aggiunto il nuovo piano è maggiore dei mattoni forniti, il ciclo si interrompe, e la funzione ritorna il numero di piani, che è ottenuto dividendo per 2 i, che, partendo da 1 ed incrementando di 2, tiene conto del doppio e mezzo dei piani; i/2 dà un numero decimale, ma il sistema, che deve ritornare un intero, approssima automaticamente per difetto il risultato dell'operazione.
```C#
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
```



#### Codice della funzione responsabile del numero di mattoni rimanenti:
Questa seconda funzione lavora in maniera completamente uguale alla precedente, l'unica cosa che cambia, è il valore ritornato: questa funzione, che deve restituire la quantità di mattoni rimanenti, nell'istruzione di return sottra e a mattoni la variabile temporanea dove è inserito il numero totale di mattoni da usare per i vari piani della piramide.
```C#
  public static int Rimanenti( int mattoni )
  {
      int tmp = 0;
      for (int i = 1; tmp + (i*i) <= mattoni ; i+=2)
          tmp += (i*i);

      return mattoni - tmp;
  }
```


