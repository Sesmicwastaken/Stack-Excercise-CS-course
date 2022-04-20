namespace Stack_Excercise_CS_course
{
    public class Stack
    {

       
        readonly static private List<object> _stack = new List<object>();

        public void Push(object input)
        {
            //if (input == null) throw new InvalidOperationException();


            if (_stack.Count <= 0)
            {
                _stack.Add(input);
            }
            else
            {
                _stack.Insert(0, input);
            }
        }

        public object Pop()
        {
            if (_stack.Count <= 0) throw new InvalidOperationException();

            else
            {
             
                
                var temp = new object();
                //temp = null;
                temp = _stack[0];
                _stack.Remove(_stack[0]); //Removes element having index of 0
                _stack.Sort();
                return temp;
            }

            
        }

        public void Clear()
        {
            if (_stack.Count <= 0) throw new InvalidOperationException("There are no values to be cleared.");

            else
            {
                _stack.Clear();
                Console.WriteLine("Cleared all the objects from the stack.");
            }
        }
    }
}
