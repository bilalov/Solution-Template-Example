using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionTemplateExample.Interfaces
{
    public interface IFileHelper
    {
        bool Exists(string filename);

        void WriteData(string filename, string value);

        string ReadData(string filename);

        void Delete(string filename);
    }
}
