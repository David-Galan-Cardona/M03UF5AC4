using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03UF5AC3.Persistence.DAO
{
    public interface IRegistreDAO
    {
        Registre GetComarcaById(int id);
        public IEnumerable<Registre> GetAllComarques();
        void AddComarca(Registre comarca);
        void UpdateComarca(Registre comarca);
        void DeleteComarca(int id);
    }
}
