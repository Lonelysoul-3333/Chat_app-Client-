// Using namespace members section:
using System;
using System.Windows.Forms;
using View;

/* This namespace contains everything related to:
 * > Controller components of the Client.
 */
namespace Controller {
    class Client_Control {

        // Variables declaration:
        Main_Screen main_screen;

        // Constructor:
        internal Client_Control (){
            // Create main screen for the client:
            Application.SetCompatibleTextRenderingDefault (false);
            main_screen = new Main_Screen ();

            // Create and display the form:
            Application.EnableVisualStyles ();
            Application.Run (main_screen);  
        }

        // Event handles:
        internal void Register_Button_Is_Clicked_Event_Handle (object sender, EventArgs e){

        }
    }
}
