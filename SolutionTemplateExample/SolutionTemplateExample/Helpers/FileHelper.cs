using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionTemplateExample.Interfaces;
using Xamarin.Forms;

namespace SolutionTemplateExample.Helpers
{
    public class FileHelper : IFileHelper
    {
        IFileHelper fileHelper = DependencyService.Get<IFileHelper>();

        public bool Exists(string filename)
        {
            return fileHelper.Exists(filename);
        }

        public void WriteData(string filename, string value)
        {
            fileHelper.WriteData(filename, value);
        }

        public string ReadData(string filename)
        {
            return fileHelper.ReadData(filename);
        }

        public void Delete(string filename)
        {
            fileHelper.Delete(filename);
        }


    }
}
