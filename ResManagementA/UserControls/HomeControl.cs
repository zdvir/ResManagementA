using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManagement.UserControls
{
    public partial class HomeControl : UserControl
    {
        private String currentUser;

        public HomeControl()
        {
            InitializeComponent();
        }

        public void SetCurrentUser(String user)
        {
            this.currentUser = user;
        }
    }
}
