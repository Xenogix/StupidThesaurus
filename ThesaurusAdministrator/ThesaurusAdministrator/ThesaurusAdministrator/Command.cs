using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesaurusAdministrator
{
    abstract class ICommand<T>
    {
        public ICommand(AdminConsole console);

        public abstract void Call();
    }
}
