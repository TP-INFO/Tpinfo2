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
    /// Encode a message using shifting technique
    /// </summary>
    /// <param name="userInput"></param>
    /// <param name="shiftAmount"></param>
    /// <returns></returns>
    private static string Encode(string userInput, int shiftAmount) {
      char[] charMessage = userInput.ToCharArray();
      for(int i = 0; i < charMessage.Length; ++i) {
        Char.ToLower(charMessage[i]);  // TODO: add support to upper case input
        charMessage[i] = (char)((charMessage[i] + shiftAmount - 'a') % 26 + 'a');
      }
      return new string(charMessage); 
    }

    internal static void DecodeDialog() {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Checks if the string contains letters only 
    /// </summary>
    /// <param name="str"><value>string to be tested</value></param>
    /// <returns></returns>
    private static bool IsAlphaOnly(string str) {
      for(int i = 0; i < str.Length; i++) {
        if(!Char.IsLetter(str[i]))
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
