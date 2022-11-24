class Program
{
    static void Main(string[] args)
    {
        Queue<int> FruitInput = new Queue<int>();
        Queue<int> FirstCut = new Queue<int>();
        Queue<int> SecondCut = new Queue<int>();

        int Stopper = 1;

        do {
            char FruitSize = char.Parse(Console.ReadLine());

            switch(FruitSize) {
                case 'S':
                case 's': {
                    FruitInput.Push(3);
                    break;
                }
                case 'M': 
                case 'm': {
                    FruitInput.Push(2);

                    for(int i = 1; i <= 3; i++) {
                        FirstCut.Push(3);
                    }
                    break;
                }
                case 'L':
                case 'l': {
                    FruitInput.Push(1);

                    for(int i =1; i <=2; i++) {
                        FirstCut.Push(2);

                        for(int j = 1; j <= 3; j++) {
                            SecondCut.Push(3);
                        }
                    }
                    break;
                }
                default: {
                    Stopper = 0;
                    break;
                }
            }
        } while(Stopper == 1);

        for(int i = 0; i < FruitInput.GetLength(); i++) {
            Console.Write("{0}", FruitInput.Get(i));
        }
        for(int i = 0; i < FirstCut.GetLength(); i++) {
            Console.Write("{0}", FirstCut.Get(i));
        }
        for(int i = 0; i < SecondCut.GetLength(); i++) {
            Console.Write("{0}", SecondCut.Get(i));
        }

    }
}