namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj2 = serializer.Deserialize<Message>(xml);
            Console.WriteLine("Hello World!");
        }
    }
}


[XmlRoot("Status")]
public class Status{

    [XmlElement("transactionId")]
    public string TransactionId { get; set; }

    [XmlElement("messageId")]
    public string MessageId { get; set; }
    
    [XmlElement("successIndicator")]
    public string SuccessIndicator { get; set; }

    [XmlElement("application")]
    public string Application { get; set; }

    [XmlElement("messages")] 
    public string FirstMessage { get; set; }

}