using System;
using System.Windows.Forms;
using View;

namespace Controller {
    class Event_Handlers_Create_And_Add{

        // Variables declaration:
        private Client_Control client_controller;
        private Main_Screen main_screen;
        private EventHandler button_is_clicked;

        internal Event_Handlers_Create_And_Add (Client_Control client_controller, Main_Screen main_screen){
            this.client_controller = client_controller;
            this.main_screen = main_screen;
        }

        internal void create_and_add_Event_Handlers (TabPage need_adding_event_handler_page){
            switch (need_adding_event_handler_page.Name) {
                case "main_page":
                    button_is_clicked = new EventHandler (client_controller.Register_Button_Is_Clicked_Event_Handle);
                    main_screen.Register_button.Click += button_is_clicked;
                    button_is_clicked = new EventHandler (client_controller.Login_Button_Is_Clicked_Event_Handle);
                    main_screen.Login_button.Click += button_is_clicked;
                    break;
            }
        }
    }
}
