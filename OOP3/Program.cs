using OOP3;

var dals = new List<IEntityDal>() {
    new EmployeeDal(),
    new CategoryDal()
};

var loggers = new List<ILoggerService>
{
    new DatabaseLoggerManager(),
    new FileLoggerManager()
};

EntityManager entityManager = new EntityManager(entityDals: dals, loggerServices: loggers);

entityManager.ActivateAll();