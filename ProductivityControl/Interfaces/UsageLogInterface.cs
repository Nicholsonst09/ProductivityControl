using ProductivityControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityControl.Interfaces
{
    public interface UsageLogInterface
    {
        public void startLog(int restrictedAppId);
        void endLog(int logId);
        List<UsageLog> getAllLogs(DateTime? start , DateTime? end); //Agregar el null si no funciona
    }
}
