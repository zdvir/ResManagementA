using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManagement.Classes
{
    interface MenuInterface
    {
        void GetOrRefreshData();
        void SetNumericMaxValue();
        void SetNumericValue();
        void ClearNumericValues();
        bool NewOrder();
        void SetTableNumber(int tableNumber);
        void SetCurrentMode(String currentMode);
        bool UpdateOrder();
        void DeleteOrder();
        void SetCurrentUser(String user);
    }
}
