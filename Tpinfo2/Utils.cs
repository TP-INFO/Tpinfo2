using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message {
  static class Utils {

    static public string HelpMessage = "Utilisation: \n" +
                                "message encode/decode\n";



    /// <summary>
    /// Starts a session of encoding. Prompts the user to enter a message 
    /// and calls encoding subroutine 
    /// </summary>
    public static void EncodeDialog() {
      int shiftAmount = 5;  //
      string userInput = null;
      bool validInput = false;
      try {
        while(!validInput) {

          Console.WriteLine("Please enter a message to be encoded: ");
          userInput = Console.ReadLine();

          // check if string contains letter only 
          if(IsAlphaOnly(userInput)) {
            string encodedMessage = Encode(userInput, shiftAmount);
            Console.WriteLine("The encoded message: ");
            Console.WriteLine(encodedMessage);
            // TODO : Add possiblity for multiple message decoding session 

          }
          else {// not valid input 
            Console.WriteLine("input not valid. Try again. Enter 0 to quit ");
            userInput = Console.ReadLine();
            if(userInput == "0")
              validInput = true;  
          }

        }

      }
      catch(Exception e) {
        Console.WriteLine("Unknown input");
      }




    }


    /// <summary>
    /// Encode a message using shifting technique. 
    /// for now the encoding supports letters only 
    /// </summary>
    /// <param name="userInput"></param>
    /// <param name="shiftAmount"></param>
    /// <returns></returns>
    private static string Encode(string userInput, int shiftAmount) {
      char[] charMessage = userInput.ToCharArray();
      for(int i = 0; i < charMessage.Length; ++i) {
        char c = charMessage[i];
        if(c == ' ') {
          // just pass
          charMessage[i] = '?';  // TODO : we can radomize this 
        }
        else if(c == Char.ToLower(c)) {// c is a lower case 
          charMessage[i] = (char)((c + shiftAmount - 'a') % 26 + 'a');
        }
        else {
          charMessage[i] = (char)((c + shiftAmount - 'A') % 26 + 'A');
        }
      }
      return new string(charMessage); 
    }

    internal static void DecodeDialog() {

      string userInput = null;
      try {
        Console.WriteLine("Please enter the message to be decoded: ");
        userInput = Console.ReadLine();
        if(!IsAlphaOnly(userInput)) {
          throw new FormatException("The encoder supports messages containing letters only!");
        }
        // try all the shift and prints the results to user 
        // the user will recongnise its message
        Console.WriteLine("Possibilities");
        for(int i = 0; i < 25; i++) {
          
          Console.WriteLine(String.Format("{0,5}: {1}", i + 1, Encode(userInput, i)));
        }



      }
      catch(FormatException fe) {
        Console.WriteLine(fe.Message);
      }
      catch(Exception) {
        Console.WriteLine("Unknown error occured while reading the message");
      }





    }

    /// <summary>
    /// Checks if the string contains letters only 
    /// </summary>
    /// <param name="str"><value>string to be tested</value></param>
    /// <returns></returns>
    private static bool IsAlphaOnly(string str) {
      for(int i = 0; i < str.Length; i++) {
        if(!Char.IsLetter(str[i]) && str[i] != ' ')
          return false;
      }
      return true; 
    }


    /// <summary>
    /// Displays a help message on the console 
    /// </summary>
    /// <param name="msg"><value> message to be displaye</value></param>
    public static void DisplayMessage(string msg) {
      Console.WriteLine(msg);
    }







  }// Utils
}
