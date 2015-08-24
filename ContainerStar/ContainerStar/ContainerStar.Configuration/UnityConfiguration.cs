﻿using System.Configuration;
using ContainerStar.Contracts;
using ContainerStar.Contracts.Services;
using ContainerStar.Lib.Data;
using ContainerStar.Lib.Services;
using Microsoft.Practices.Unity;
using ContainerStar.Contracts.SaveActors;
using ContainerStar.Lib.Data.SaveActors;
using ContainerStar.Lib.DuplicateCheckers;
using ContainerStar.Contracts.Managers;
using ContainerStar.Lib.Managers;

namespace ContainerStar.Configuration
{
    public static partial class UnityConfiguration
    {
        public static void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<IContainerStarEntities, ContainerStarEntities>(new PerRequestLifetimeManager(),
                new InjectionConstructor(new ResolvedParameter<IContainerStarSaveActorManager>(), ConfigurationManager.ConnectionStrings["ContainerStarEntities"].ConnectionString));

            container.RegisterType<IContainerStarSaveActorManager, ContainerStarSaveActorManager>(new PerRequestLifetimeManager());

            container.RegisterType<IPrinterManager, PrinterManager>(new PerRequestLifetimeManager());

            RegisterDuplicateCheckers(container);
            RegisterManagers(container);
        }

        private static void RegisterDuplicateCheckers(IUnityContainer container)
        {
            container.RegisterType<IContainerStarSaveActor, ContainerStarDuplicateCheckerSaveActor>("masterDataDuplicateCheckerSaveActor", new PerRequestLifetimeManager());

            InitializeContainerStarDuplicateCheckers(container);
        }

        private static void RegisterManagers(IUnityContainer container)
        {
            InitializeContainerStar(container);
            container.RegisterType<IUniqueNumberProvider, UniqueNumberProvider>(new ContainerControlledLifetimeManager());
        }
    }
}