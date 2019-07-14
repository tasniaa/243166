using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using MobileHandsetFormsApp.Model;
using MobileHandsetFormsApp.Repository;

namespace MobileHandsetFormsApp.BLL
{
    public class MobileHandsetManager
    {
        MobileRepository _mobileRepository = new MobileRepository();
        public int Insertmobile(MoblieHandset moblieHandset)
        {
            return _mobileRepository.Insertmobile(moblieHandset);
        }
    
        public DataTable SearchbyIMEI(MoblieHandset moblieHandset)
        {
            return _mobileRepository.SearchByIMEI(moblieHandset);
        }
        public DataTable SearchbyPrice(MoblieHandset mobileHandset)
        {
            return _mobileRepository.SearchbyPrice(mobileHandset);
        }
    }
}
