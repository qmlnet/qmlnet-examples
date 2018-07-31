namespace Features
{
    public class DynamicModel
    {
        public void InvokeJavascriptFunction(dynamic function, string message)
        {
            function(message);
        }
    }
}