using System.Windows.Forms;

namespace View {
    internal partial class Main_Screen : Form {
        internal Main_Screen (){

            // Set default values:
            event_handler_added_to_main_page = false;
            event_handler_added_to_register_gui = false;

            InitializeComponent ();
        }
    }
}
