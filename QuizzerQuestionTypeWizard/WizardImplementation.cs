using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TemplateWizard;
using System.Windows.Forms;
using EnvDTE;
using EnvDTE80;
using System.IO;
using Microsoft.VisualStudio.VCProjectEngine;

namespace QuizzerQuestionTypeWizard
{
    public class WizardImplementation : IWizard
    {
        private static readonly string REPLACE_PARAM_NAME = "$question_type_name$";
        private static readonly string REPLACE_PARAM_DISP_SINGULAR = "$question_type_disp$";
        private static readonly string REPLACE_PARAM_DISP_PLURAL = "$question_type_disps$";
        private static readonly string REPLACE_PARAM_ENUM_CODE = "$question_type_enum$";
        private static readonly string REPLACE_PARAM_FIRST_FIELD_NAME_CAPITALISED = "$first_field_name_capitalised$";
        private static readonly string REPLACE_PARAM_FIELD_BEGIN = "$field_begin$";
        private static readonly string REPLACE_PARAM_FIELD_TYPE = "$field_type$";
        private static readonly string REPLACE_PARAM_FIELD_NAME = "$field_name$";
        private static readonly string REPLACE_PARAM_FIELD_NAME_CAPITALISED = "$field_name_capitalised$";
        private static readonly string REPLACE_PARAM_FIELD_DISPLAY_CAPITALISED = "$field_display_capitalised$";
        private static readonly string REPLACE_PARAM_FIELD_ENUM_CODE = "$field_enum$";
        private static readonly string REPLACE_PARAM_NEXT_FIELD_ENUM_CODE = "$next_field_enum$";
        private static readonly string REPLACE_PARAM_FIELD_DEFAULT_VALUE = "$field_default$";
        private static readonly string REPLACE_PARAM_CALL_NEXT_ASKING_FUNCTION = "$call_next_asking_function$";
        private static readonly string REPLACE_PARAM_FIELD_END = "$field_end$";
        static string replaceFieldParams(string str, int index)
        {
            QuestionTypeField qtf = WizardForm.QuestionTypeFields[index];
            str = str.Replace(REPLACE_PARAM_FIELD_TYPE, qtf.Type);
            str = str.Replace(REPLACE_PARAM_FIELD_NAME, qtf.Name);
            str = str.Replace(REPLACE_PARAM_FIELD_NAME_CAPITALISED, qtf.NameCapitalised);
            str = str.Replace(REPLACE_PARAM_FIELD_DISPLAY_CAPITALISED, qtf.DispCapitalised);
            str = str.Replace(REPLACE_PARAM_FIELD_ENUM_CODE, qtf.EnumCode);
            str = str.Replace(REPLACE_PARAM_FIELD_DEFAULT_VALUE, qtf.DefaultValue);

            if (index < WizardForm.QuestionTypeFields.Count - 1)
            {
                QuestionTypeField nextQtf = WizardForm.QuestionTypeFields[index + 1];
                str = str.Replace(
                    REPLACE_PARAM_CALL_NEXT_ASKING_FUNCTION,
                    "ask" + nextQtf.NameCapitalised + "();"
                );
                str = str.Replace(
                    REPLACE_PARAM_NEXT_FIELD_ENUM_CODE,
                    nextQtf.EnumCode
                );
            }
            else
            {
                while (str.Contains(REPLACE_PARAM_CALL_NEXT_ASKING_FUNCTION))
                {
                    int paramIndex = str.IndexOf(REPLACE_PARAM_CALL_NEXT_ASKING_FUNCTION);
                    string tab = "";
                    for (int i = paramIndex; i >= 0; i--)
                    {
                        if (str[i] == '\t' || str[i] == ' ')
                            tab = str[i] + tab;
                        else
                            break;
                    }
                    str = str.Remove(paramIndex, REPLACE_PARAM_CALL_NEXT_ASKING_FUNCTION.Length);
                    str = str.Insert(
                        paramIndex,
                        "QuestionWriter::writeTags();\r\n" +
                        tab + "stage = Stage::" + REPLACE_PARAM_NEXT_FIELD_ENUM_CODE
                    );
                }
                str = str.Replace(
                    REPLACE_PARAM_NEXT_FIELD_ENUM_CODE,
                    "TAGS"
                );
            }

            return str;
        }
        static string replaceFieldParamsForAllFields(string str)
        {
            string result = "";
            int count = WizardForm.QuestionTypeFields.Count;
            for (int i = 0; i < count; i++)
                result += replaceFieldParams(str, i);
            return result;
        }


        // This method is called before opening any item that   
        // has the OpenInEditor attribute.  
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        private VCFilter _filterHeaderQuestion;
        private VCFilter _filterHeaderRead;
        private VCFilter _filterHeaderWrite;
        private VCFilter _filterSourceQuestion;
        private VCFilter _filterSourceRead;
        private VCFilter _filterSourceWrite;
        private readonly string _filterStringHeaderQuestion = "Header Files\\Question";
        private readonly string _filterStringHeaderRead = "Header Files\\Read";
        private readonly string _filterStringHeaderWrite = "Header Files\\Write";
        private readonly string _filterStringSourceQuestion = "Source Files\\Question";
        private readonly string _filterStringSourceRead = "Source Files\\Read";
        private readonly string _filterStringSourceWrite = "Source Files\\Write";
        private string _mainSourceFilePath;
        private string _readSourceFilePath;
        private string _writeSourceFilePath;
        private string _mainHeaderFilePath;
        private string _readHeaderFilePath;
        private string _writeHeaderFilePath;

        public void ProjectFinishedGenerating(Project project)
        {
            // --- FILTERS --- //

            VCProject vcproject = project as VCProject;

            // Retrieve filters

            _filterHeaderQuestion = null;
            _filterHeaderRead = null;
            _filterHeaderWrite = null;
            _filterSourceQuestion = null;
            _filterSourceRead = null;
            _filterSourceWrite = null;

            foreach (VCFilter filter in vcproject.Filters)
            {
                if (filter.Name == _filterStringHeaderQuestion)
                    _filterHeaderQuestion = filter;
                else if (filter.Name == _filterStringHeaderRead)
                    _filterHeaderRead = filter;
                else if (filter.Name == _filterStringHeaderWrite)
                    _filterHeaderWrite = filter;
                else if (filter.Name == _filterStringSourceQuestion)
                    _filterSourceQuestion = filter;
                else if (filter.Name == _filterStringSourceRead)
                    _filterSourceRead = filter;
                else if (filter.Name == _filterStringSourceWrite)
                    _filterSourceWrite = filter;
            }

            // If any filters didn't already exist, make them!

            if (_filterHeaderQuestion == null)
                _filterHeaderQuestion = vcproject.AddFilter(_filterStringHeaderQuestion);
            if (_filterHeaderRead == null)
                _filterHeaderRead = vcproject.AddFilter(_filterStringHeaderRead);
            if (_filterHeaderWrite == null)
                _filterHeaderWrite = vcproject.AddFilter(_filterStringHeaderWrite);
            if (_filterSourceQuestion == null)
                _filterSourceQuestion = vcproject.AddFilter(_filterStringSourceQuestion);
            if (_filterSourceRead == null)
                _filterSourceRead = vcproject.AddFilter(_filterStringSourceRead);
            if (_filterSourceWrite == null)
                _filterSourceWrite = vcproject.AddFilter(_filterStringSourceWrite);

            // Add files to filters

            _filterHeaderQuestion.AddFile(_mainHeaderFilePath);
            _filterHeaderRead.AddFile(_readHeaderFilePath);
            _filterHeaderWrite.AddFile(_writeHeaderFilePath);
            _filterSourceQuestion.AddFile(_mainSourceFilePath);
            _filterSourceRead.AddFile(_readSourceFilePath);
            _filterSourceWrite.AddFile(_writeSourceFilePath);
        }

        // This method is only called for item templates,  
        // not for project templates.  
        public void ProjectItemFinishedGenerating(ProjectItem
            projectItem)
        {
            // Else VS complains about accessing projectItem...
            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread("QuizzerQuestionTypeWizard.WizardImplementation.ProjectItemFinishedGenerating");

            string fileName = projectItem.FileNames[0];
            string projectItemData = File.ReadAllText(fileName);

            // Replace all field parameters
            // A field replacement block starts with REPLACE_PARAM_FIELD_BEGIN,
            // contains occurrences of REPLACE_PARAM_FIELD_* and finally,
            // ends with REPLACE_PARAM_FIELD_END.
            int replaceParamLength = REPLACE_PARAM_FIELD_BEGIN.Length;
            while(true)
            {
                // Find index of strings - both the "outer" indexes (including the parameters) and "inner" (excluding the parameters).
                int indexStartOuter = projectItemData.IndexOf(REPLACE_PARAM_FIELD_BEGIN);
                if (indexStartOuter == -1)
                    break;
                int indexStartInner = indexStartOuter + replaceParamLength;
                int indexEndInner = projectItemData.IndexOf(REPLACE_PARAM_FIELD_END, indexStartInner);
                if (indexEndInner == -1)
                    break;
                int indexEndOuter = indexEndInner + replaceParamLength - 1;

                string replacement = replaceFieldParamsForAllFields(projectItemData.Substring(indexStartInner, indexEndInner - indexStartInner));
                projectItemData = projectItemData.Remove(indexStartOuter, indexEndOuter - (1 + indexStartOuter));
                projectItemData = projectItemData.Insert(indexStartOuter, replacement);
            }

            // Output back to the file
            File.WriteAllText(projectItem.FileNames[0], projectItemData);

            // Make note of file names to add to filters later!
            if (projectItem.Name.Contains(".h"))
            {
                if (projectItem.Name.Contains("Read"))
                    _readHeaderFilePath = fileName;
                else if (projectItem.Name.Contains("Write"))
                    _writeHeaderFilePath = fileName;
                else
                    _mainHeaderFilePath = fileName;
            }
            else // if (projectItem.Name.Contains(".cpp"))
            {
                if (projectItem.Name.Contains("Read"))
                    _readSourceFilePath = fileName;
                else if (projectItem.Name.Contains("Write"))
                    _writeSourceFilePath = fileName;
                else
                    _mainSourceFilePath = fileName;
            }
        }

        // This method is called after the project is created.  
        public void RunFinished()
        {
        }


        public void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();

            try
            {
                // Display a form to the user. The form collects   
                // input for the custom message.  
                string itemName = "";
                if (!replacementsDictionary.TryGetValue("$safeitemname$", out itemName))
                    itemName = "NewQuestionType";
                WizardForm.ItemName = itemName;
                WizardForm wizardForm = new WizardForm();
                wizardForm.ShowDialog();

                if (!WizardForm.Cancel)
                {
                    replacementsDictionary.Add(REPLACE_PARAM_NAME, WizardForm.QuestionTypeName);
                    replacementsDictionary.Add(REPLACE_PARAM_DISP_SINGULAR, WizardForm.QuestionTypeDispSingular);
                    replacementsDictionary.Add(REPLACE_PARAM_DISP_PLURAL, WizardForm.QuestionTypeDispPlural);
                    replacementsDictionary.Add(REPLACE_PARAM_ENUM_CODE, WizardForm.QuestionTypeEnumCode);
                    replacementsDictionary.Add(REPLACE_PARAM_FIRST_FIELD_NAME_CAPITALISED, WizardForm.QuestionTypeFields[0].NameCapitalised);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (WizardForm.Cancel)
                throw new WizardCancelledException();
        }

        // This method is only called for item templates,  
        // not for project templates.  
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}