// Using namespace members section:
using System;
using Controller;

namespace Entry_Point {
    static class Program {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        // COM threading model: single-threaded apartment:
        [STAThread]
        // Main method:
        static void Main (){

            // Variables declaration:
            Client_Control client_controller;

            // TODO code application logic here:
            client_controller = new Client_Control ();
        }
    }
}
