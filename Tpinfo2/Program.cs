using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message {
  class Program {
    static void Main(string[] args) {

      if(args.Length != 1) {
        Utils.DisplayMessage(Utils.HelpMessage);
        System.Environment.Exit(0);
      }

      // 
      switch(args[0].ToUpper()) {
        case "ENCODE":
          Utils.EncodeDialog(); 
          break;
        case "DECODE":
          Utils.DecodeDialog();
          break;
        default:
          Utils.DisplayMessage("Unknowd command\n" + Utils.HelpMessage); 
          break;
      }




    }
  }
}
