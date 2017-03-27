using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angular2ComponentTemplateWizard
{
    public class ComponentWizard : IWizard
    {
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        // This method is only called for item templates,  
        // not for project templates.  
        public void ProjectItemFinishedGenerating(ProjectItem
            projectItem)
        {
        }

        // This method is called after the project is created.  
        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            try
            {
                var name = replacementsDictionary["$rootname$"];
                var componentName = $"{char.ToUpper(name[0])}{name.Substring(1, name.Length - 1)}";
                var index = componentName.IndexOf("-");
                if (index > 0)
                {
                    var secondName = componentName.Substring(index + 1, componentName.Length - index - 1);
                    componentName = $"{componentName.Substring(0, index)}{char.ToUpper(secondName[0])}{secondName.Substring(1, secondName.Length - 1)}";
                }
                var componentFileName = $"{char.ToLower(name[0])}{name.Substring(1, name.Length - 1)}";
                replacementsDictionary.Add("$componentName$", componentName);
                replacementsDictionary.Add("$componentFileName$", componentFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // This method is only called for item templates,  
        // not for project templates.  
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
