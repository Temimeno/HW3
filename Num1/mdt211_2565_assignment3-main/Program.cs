class Program
{
    static void Main(string[] args)
    {
        Queue<char> Steering_Wheel = new Queue<char>();

        int Stopper = 1;

        do {
            char Input = char.Parse(Console.ReadLine());

            switch(Input) {
                case 'J':
                case 'j': {
                    Steering_Wheel.Push('J');
                    break;
                }
                case 'G': 
                case 'g': {
                    Steering_Wheel.Push('G');
                    break;
                }
                case 'O':
                case 'o': {
                    Steering_Wheel.Push('O');
                    break;
                }
                case 'R':
                case 'r': {
                    Steering_Wheel.Push('R');
                    break;
                }
                default: {
                    Stopper = 0;
                    break;
                }
            }
        } while(Stopper == 1);

        for(int i = 0; i < Steering_Wheel.GetLength(); i++) {
            Console.Write("{0}", Steering_Wheel.Get(i));
        }
    }
}