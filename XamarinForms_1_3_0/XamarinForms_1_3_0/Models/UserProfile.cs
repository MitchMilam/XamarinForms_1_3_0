using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms_1_3_0
{
    public class UserProfile
    {
        public string Name { get; set; }
        public string Email { get; set; }

        // TODO: Add encryption
        public string Password { get; set; }
    }
}
