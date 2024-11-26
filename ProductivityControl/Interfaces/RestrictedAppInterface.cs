using ProductivityControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityControl.Interfaces
{
    public interface RestrictedAppInterface
    {
        public List<RestrictedApp> getAllApps();
        public RestrictedApp getAppById(int id);
        public void addApp(RestrictedApp app);
        public void updateApp(RestrictedApp app);
        public void deleteApp(int id);
    }
}
