namespace ClassLibrary1
{
    public class Class1
    {
        string Message { get; set; }=String.Empty;
        public Class1(string messageString) {
                Message = messageString; 
        }
        
        public void printMessage()
        {

            Console.WriteLine( Message);
        }
    }
}
