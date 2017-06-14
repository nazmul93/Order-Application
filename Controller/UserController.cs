using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Collections;

namespace Controller
{
    public class UserController : SystemException
    {
        IUserView _view;
        IList _users;
        User _selectedUser;
        

        public UserController(IUserView view, IList users)
        {
            _view = view;
            _users = users;
            view.SetController(this);
        }

        
        public IList Users
        {
            get { return ArrayList.ReadOnly(_users); }
        }


        private void updateUserWithViewValues(User usr)
        {
            usr.FirstName = _view.FirstName;
            usr.LastName = _view.LastName;
            usr.PhoneNo = _view.PhoneNo;
            usr.Email = _view.Email;
            usr.Address = _view.Address;
        }


        public void LoadView()
        {
            _view.ClearGrid();
            foreach (User usr in _users)
                _view.AddUserToGrid(usr);

        }
        
        public void Save()
        {
            _selectedUser = new User(""/*firstname*/,
                                    "" /*lastname*/,
                                    ""  /*phone*/,
                                    "" /*Email*/,
                                    "" /*address*/);
            updateUserWithViewValues(_selectedUser);

            // Add new user
            this._users.Add(_selectedUser);
            this._view.AddUserToGrid(_selectedUser);

        }
    }
}

