using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using DomainLayer.Interfaces;
using RepositoryLayer.Repositories;
using ServiceLayer.Services;

namespace OnionArchitectureApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // Register all your components with the container here
            // It is NOT necessary to register your controllers

            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<IStudentService, StudentService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
