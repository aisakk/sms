// See https://aka.ms/new-console-template for more information
using Azure.Communication;
using Azure.Communication.Sms;

//Falta incorporar el token o string de Azure
string connectionString = <your-connection-string>;
SmsClient smsClient = new SmsClient(connectionString);

smsClient.Send(
   from: new PhoneNumber("<leased-phone-number>"),
   to: new PhoneNumber("<to-phone-number>"),
   message: "Hello World via SMS"
);

//Ejecutar dotnet run 
Console.WriteLine("Hello, World!");
//Pagina tutorial: https://learn.microsoft.com/en-us/training/modules/communication-service-send-sms-console-app/3-exercise-send