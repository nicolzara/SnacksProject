using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModel
{
    [ServiceContract]
    public interface IServiceSnack
    {
        [OperationContract] CityList GetAllCites();
        [OperationContract] UserList GetAllUsers();
        [OperationContract] SnacksList GetAllSnack();
        [OperationContract] SnacksList GetSnackByUser(User user);
        [OperationContract] UserList GetUserBysnack(Snacks snack);
        [OperationContract] User Login (User user);

        

       
       

    }
}
