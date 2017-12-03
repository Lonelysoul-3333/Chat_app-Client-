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
        private Main_Screen main_screen;
        private Event_Handlers_Create_And_Add event_handlers_creator_and_adder;

        // Constructor:
        internal Client_Control (){
            // Create main screen for the client:
            Application.SetCompatibleTextRenderingDefault (false);
            main_screen = new Main_Screen ();

            // Create and add event handlers for main page:
            event_handlers_creator_and_adder = new Event_Handlers_Create_And_Add (this, main_screen);
            event_handlers_creator_and_adder.create_and_add_Event_Handlers (main_screen.Main_page);
            main_screen.Event_handler_added_to_main_page = true;

            // Create and display the form:
            Application.EnableVisualStyles ();
            Application.Run (main_screen);  
        }

        // Event handles:
        internal void Register_Button_Is_Clicked_Event_Handle (object sender, EventArgs e){
            main_screen.Text = "Register";
            if (main_screen.Event_handler_added_to_register_gui == false){
                event_handlers_creator_and_adder.create_and_add_Event_Handlers (main_screen.Register_gui);
                main_screen.Event_handler_added_to_register_gui = true;
            }
            main_screen.Panels_stack.SelectedTab = main_screen.Register_gui; 
        }

        internal void Login_Button_Is_Clicked_Event_Handle (object sender, EventArgs e){
            main_screen.Panels_stack.SelectedTab = main_screen.Login_gui;
        }
    }
}
