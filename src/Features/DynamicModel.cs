namespace Features
{
    public class DynamicModel
    {
        public void InvokeJavascriptFunction(dynamic function, string message)
        {
            function(message);
        }

        public void Add(dynamic source, dynamic destination)
        {
            destination.computedResult = source.value1 + source.value2;
        }
    }
}