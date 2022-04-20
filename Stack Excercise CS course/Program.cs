namespace Stack_Excercise_CS_course
{

    public class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                var stack = new Stack();
                bool wantsToStoreValOnStack = true;

                Console.Write("Enter a value to store in stack.");
                Console.Write("\nInput: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input)) throw new InvalidOperationException("Cannot add null value to the stack.");
                else { stack.Push(input); }

                Console.WriteLine("\nWould you like to store more values on the stack?");
                Console.Write("Input: ");
                var reply = Console.ReadLine();

                if (IsValid.IsValidReply(reply))
                {
                    switch (reply.Trim().ToLower())
                    {
                        case "yes":
                            {
                                continue;
                            }
                        case "no":
                            {
                                wantsToStoreValOnStack = false;
                                break;
                            }
                    }
                }
                else { throw new InvalidOperationException("Invalid Input"); }


                while (wantsToStoreValOnStack == false)
                {

                    Console.WriteLine("\nWould you like to see (pop) the last element you entered or would you like to clear the stack? (Enter \"Back\" if you wish to enter values in stack\n\nNote: This will clear all the values from the stack");
                    Console.Write("Input: ");
                    var function = Console.ReadLine();
                    if (IsValid.IsValidOperation(function))
                    {
                        switch (function.Trim().ToLower())
                        {
                            case "clear":
                                {
                                    stack.Clear();
                                    break;
                                }

                            case "pop":
                                {
                                    Console.WriteLine($"\nOutput: {stack.Pop()}");
                                    continue;
                                }

                            case "back":
                                {
                                    wantsToStoreValOnStack = true;        
                                    stack.Clear();
                                    Console.Clear();
                                    break;
                                }

                        }
                    }

                    else { throw new InvalidOperationException("Invalid Input"); }
                }

            }
        }
    }
}

