using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Excercise_CS_course
{
    public class IsValid
    {
        public static bool IsValidReply(string reply)
        {
            var inputs = new UserInputs();
            return String.Equals(reply, inputs.Yes, StringComparison.CurrentCultureIgnoreCase) || String.Equals(reply, inputs.No, StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool IsValidOperation(string function)
        {
            var functionType = new UserInputs();
            return String.Equals(function, functionType.Clear, StringComparison.CurrentCultureIgnoreCase) || String.Equals(function, functionType.Pop, StringComparison.CurrentCultureIgnoreCase) || String.Equals(function,functionType.Back,StringComparison.CurrentCultureIgnoreCase);
        }

    }

}
