using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using Autofac;
using CsvParser.Web.Core;
using CsvParser.Contracts;
using log4net;

namespace CsvParser.Web.App_Start
{
    public class DependencyConfig
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();

            // Register MVC Controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();

            builder.RegisterInstance(LogManager.GetLogger("MvcApplication"));
            //builder.RegisterModule<Log4NetModule>();

            builder.RegisterType<ParsingService>().As<IParsingService>();
            builder.RegisterType<ValidationService>().As<IValidationService>();
            builder.RegisterType<FileService>().As<IFileService>();

            builder.RegisterType<CsvFileHandler>().As<ICsvFileHandler>();

            //_csvFileHandler = new CsvFileHandler(new ParsingService(), new ValidationService(), new FileService());
            //_logger = LogManager.GetLogger("MvcApplication");

            #region Repository configuration

            //builder.RegisterType<BaseRepository>().As<IBaseRepository>();

            #endregion Repository configuration

            #region Service configuration

            //builder.RegisterType<CareerService>().As<ICareerService>();

            #endregion Service configuration

            #region Serializer

            //builder.RegisterType<SerializerService>().As<ISerializerService>();

            //builder.RegisterType<Serializer>().As<ISerializer>();

            #endregion Serializer

            return builder.Build();
        }

        public static void Register()
        {
            var container = Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}