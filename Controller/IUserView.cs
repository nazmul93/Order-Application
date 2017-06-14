using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;

namespace Controller
{
    public interface IUserView
    {
        void SetController(UserController controller);
        void ClearGrid();
        void AddUserToGrid(User user);

        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNo { get; set; }
        string Email { get; set; }
        string Address { get; set; }
    }

}
