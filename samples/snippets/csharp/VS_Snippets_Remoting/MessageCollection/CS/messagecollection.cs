﻿// System.Web.Services.Description.MessageCollection.CopyTo;
// System.Web.Services.Description.MessageCollection.Item Property(Int32);
// System.Web.Services.Description.MessageCollection.Item Property (String);
// System.Web.Services.Description.MessageCollection.Contains;
// System.Web.Services.Description.MessageCollection.IndexOf;
// System.Web.Services.Description.MessageCollection.Remove;

/* The program reads a WSDL document "MathService.wsdl" and gets a ServiceDescription instance.
   A MessageCollection instance is then retrieved from this ServiceDescription instance and it's
   members are demonstrated.
*/

using System;
using System.Web.Services.Description;
using System.Collections;
using System.Xml;

class MyClass1
{
   public static void Main()
   {
      ServiceDescription myServiceDescription = ServiceDescription.Read("MathService_1.wsdl");
      Console.WriteLine("");
      Console.WriteLine("MessageCollection Sample");
      Console.WriteLine("========================");
      Console.WriteLine("");
// <Snippet2>
      // Get Message Collection.
      MessageCollection myMessageCollection = myServiceDescription.Messages;
      Console.WriteLine("Total Messages in the document = " + myServiceDescription.Messages.Count);
      Console.WriteLine("");
      Console.WriteLine("Enumerating Messages...");
      Console.WriteLine("");
      // Print messages to console.
      for(int i =0; i < myMessageCollection.Count; ++i)
      {
         Console.WriteLine("Message Name : " + myMessageCollection[i].Name);
      }
// </Snippet2>
// <Snippet1>
      // Create a Message Array.
      Message[] myMessages = new Message[myServiceDescription.Messages.Count];
      // Copy MessageCollection to an array.
      myServiceDescription.Messages.CopyTo(myMessages,0);
      Console.WriteLine("");
      Console.WriteLine("Displaying Messages that were copied to Messagearray ...");
      Console.WriteLine("");
      for(int i=0;i < myServiceDescription.Messages.Count; ++i)
      {
         Console.WriteLine("Message Name : " + myMessages[i].Name);
      }
// </Snippet1>

// <Snippet3>
// <Snippet4>
// <Snippet5>
// <Snippet6>
      // Get Message by Name = "AddSoapIn".
      Message myMessage = myServiceDescription.Messages["AddSoapIn"];
      Console.WriteLine("");
      Console.WriteLine("Getting Message = 'AddSoapIn' {by Name}");
      if (myMessageCollection.Contains(myMessage))
      {
         Console.WriteLine("");
         // Get Message Name = "AddSoapIn" Index.
         Console.WriteLine("Message 'AddSoapIn' was found in Message Collection.");
         Console.WriteLine("Index of 'AddSoapIn' in Message Collection = " + myMessageCollection.IndexOf(myMessage));
         Console.WriteLine("Deleting Message from Message Collection...");
         myMessageCollection.Remove(myMessage);
         if(myMessageCollection.IndexOf(myMessage) == -1)
         {
            Console.WriteLine("Message 'AddSoapIn' was successfully removed from Message Collection.");
         }
      }
// </Snippet6>
// </Snippet5>
// </Snippet4>
// </Snippet3>
   }
}