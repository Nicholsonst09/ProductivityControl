using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProductivityControl.Data;
using ProductivityControl.Interfaces;
using ProductivityControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityControl.Repositories
{
    public class RestrictedAppRepository : RestrictedAppInterface
    {
        private readonly Context context;
        private readonly ILogger<RestrictedAppRepository> logger;

        public RestrictedAppRepository(Context context, ILogger<RestrictedAppRepository> logger)
        {
                this.context = context;
                this.logger = logger;
        }
        public List<RestrictedApp> getAllApps()
        {
            return context.RestrictedApps.ToList();
        }

        public RestrictedApp getAppById(int id)
        {
            var app =  context.RestrictedApps.Find(id);

            if (app == null)
            {
                throw new KeyNotFoundException($"The app with id : {id} was not found");
            }

           return app;
        }


        public void addApp(RestrictedApp app)
        {
            try
            {
                context.RestrictedApps.Add(app);
                context.SaveChanges();
            } catch (DbUpdateException ex){
                Console.WriteLine($"There is an error adding the app: {ex.Message}" );
            }

            
        }

        public void updateApp(RestrictedApp app)
        {
            var appToUpdate = context.RestrictedApps.Find(app.Id);

            if (appToUpdate == null)
            {
                throw new KeyNotFoundException($"The app with id : {app.Id} was not found");
            }

            appToUpdate.Name = app.Name ?? appToUpdate.Name;  //Con el ?? solo lo actualiza en el caso de que el primero no sea null
            appToUpdate.ProcessName = app.ProcessName ?? appToUpdate.ProcessName;
            appToUpdate.Url = app.Url ?? appToUpdate.Url;
            appToUpdate.IsBlocked = app.IsBlocked ?? appToUpdate.IsBlocked;
            appToUpdate.MaxMinsAllowed = app.MaxMinsAllowed ?? appToUpdate.MaxMinsAllowed;
            appToUpdate.type = app.type ?? appToUpdate.type;


            try
            {
                context.RestrictedApps.Update(appToUpdate);
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"There was an error updating the app: {ex.Message}");
            }
            
        }
        void RestrictedAppInterface.deleteApp(int id)
        {
            var app = context.RestrictedApps.Find(id);

            if (app == null)
            {
                throw new KeyNotFoundException($"The app with id : {id} was not found");
            }
            context.RestrictedApps.Remove(app);

            context.SaveChanges();
        }

    }
}
