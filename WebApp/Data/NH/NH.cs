using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using WebApp.Mapping;
using NHibernate.Proxy;
using System.Linq;

namespace WebApp.Data.NH
{
    public class NH
    {
        public static string SQLDatabase { get; set; }
        private static ISessionFactory SessionFactory;

        private static List<Type> typeMappings = new List<Type>()
        {
            typeof(RepairCostMap),
            typeof(MarkMap),
            typeof(AddressMap),
            typeof(DeviceTypeMap),
            typeof(StatusMap),
            typeof(RepairMap),
            typeof(UserMap)
        };


        public static void Init()
        {
            try
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                SQLDatabase = configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

                Init(SQLDatabase, typeMappings);
            }
            catch (Exception ex)
            {
                NLog.LogManager.GetCurrentClassLogger().Error($"Błąd połączenia z bazą danych NHibernate: {ex}");
            }
        }

        private static void Init(string connectionString, List<Type> customTypes = null)
        {
            if (SessionFactory != null)
                return;
            Configuration config = new Configuration().DataBaseIntegration(db =>
            {
                db.Timeout = byte.MaxValue;
                db.Dialect<MsSql2008Dialect>();
                db.Driver<SqlClientDriver>();
                db.ConnectionString = connectionString;
            });

            ModelMapper mapper = new ModelMapper();

            if (customTypes != null && customTypes.Any())
            {
                mapper.AddMappings(customTypes);
            }

            try
            {

                config.AddDeserializedMapping(mapper.CompileMappingForAllExplicitlyAddedEntities(), null);

                SessionFactory = config.BuildSessionFactory();
            }
            catch
            {
                throw; 
            }
        }

        public static NHibernate.ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
