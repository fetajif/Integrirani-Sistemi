using System;
using System.Collections.Generic;
using System.Text;

namespace DomasnaIS.Domain.Identity
{
    public class ImportUserDto : UserRegistrationDto
    {
        public Role SelectedRole { get; set; }
    }
}
