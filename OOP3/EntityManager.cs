using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class EntityManager
    {
        private List<IEntityDal> _entityDals;
        private List<ILoggerService> _loggerServices;

        public EntityManager(List<IEntityDal> entityDals, List<ILoggerService> loggerServices)
        {
            _entityDals = entityDals;
            _loggerServices = loggerServices;
        }

        //public void Activate()
        //{
        //    _entityDal.DoSomething();
        //}

        public void ActivateAll()
        {
            foreach (IEntityDal entityDal in _entityDals)
                entityDal.DoSomething();

            foreach (ILoggerService loggerService in _loggerServices)
                loggerService.Log();
        }
    }
}
