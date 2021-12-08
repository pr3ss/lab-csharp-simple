using ComplexAlgebra;

namespace Calculus
{
    /// <summary>
    /// A calculator for <see cref="Complex"/> numbers, supporting 2 operations ('+', '-').
    /// The calculator visualizes a single value at a time.
    /// Users may change the currently shown value as many times as they like.
    /// Whenever an operation button is chosen, the calculator memorises the currently shown value and resets it.
    /// Before resetting, it performs any pending operation.
    /// Whenever the final result is requested, all pending operations are performed and the final result is shown.
    /// The calculator also supports resetting.
    /// </summary>
    ///
    /// HINT: model operations as constants
    /// HINT: model the following _public_ properties methods
    /// HINT: - a property/method for the currently shown value
    /// HINT: - a property/method to let the user request the final result
    /// HINT: - a property/method to let the user reset the calculator
    /// HINT: - a property/method to let the user request an operation
    /// HINT: - the usual ToString() method, which is helpful for debugging
    /// HINT: - you may exploit as many _private_ fields/methods/properties as you like
    ///
    /// TODO: implement the calculator class in such a way that the Program below works as expected
    class Calculator
    {
        public const char OperationPlus = '+';
        public const char OperationMinus = '-';
        private char? _operator;
        private Complex Memory { get; set; }
        public Complex Value { get; set; }/* value shown*/

        public char? Operation
        {
            get => _operator;
            set
            {
                Memory = Operation == null ? Value : DoOperation();
                _operator = value;
                Value = null;
               
            }
        }

        private Complex DoOperation() => _operator == OperationPlus ? Memory.Plus(Value) : Memory.Minus(Value);
        

        public void Reset()
        {
            Value = null;
            _operator = null;
        }

        public void ComputeResult()
        {
            Value = DoOperation();
            _operator = null ;

        }

        public override string ToString()
        {
            if (Value is null && Operation == null) return "null, null";
            if (Value is null && Operation != null) return "null, " + Operation;
            if (!(Value is null) && Operation == null) return Value + ", null";
            return Value + ", " + Operation;
        }



        // TODO fill this class
    }
}