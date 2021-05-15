using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.TemplateWizard;
using static System.Windows.Forms.ListViewItem;

namespace QuizzerQuestionTypeWizard
{
    public partial class WizardForm : Form
    {
        private static readonly string _defaultFieldType = "std::wstring";
        private static readonly string _defaultFieldName = "question";
        private static readonly string _defaultFieldDisp = GenerateDefaultFieldDisp(_defaultFieldName);
        private static readonly string _defaultFieldDefaultValue = GenerateDefaultFieldDefaultValue(_defaultFieldType);
        private static readonly string _defaultFieldEnumCode = GenerateDefaultFieldEnumCode(_defaultFieldName);

        public static string ItemName { private get; set; } = "";
        public static bool Cancel { get; private set; } = false;
        public static string QuestionTypeName { get; private set; } = "";
        public static string QuestionTypeDispSingular { get; private set; } = "";
        public static string QuestionTypeDispPlural { get; private set; } = "";
        public static string QuestionTypeEnumCode { get; private set; } = "";
        public static List<QuestionTypeField> QuestionTypeFields { get; private set; } = new List<QuestionTypeField>();

        private static InputIssueList _inputIssuesName = new InputIssueList();
        private static InputIssueList _inputIssuesDispSingular = new InputIssueList();
        private static InputIssueList _inputIssuesDispPlural = new InputIssueList();
        private static InputIssueList _inputIssuesEnumCode = new InputIssueList();
        private static InputIssueList _inputIssuesEditFieldType = new InputIssueList();
        private static InputIssueList _inputIssuesEditFieldName = new InputIssueList();
        private static InputIssueList _inputIssuesEditFieldDisp = new InputIssueList();
        private static InputIssueList _inputIssuesEditFieldDefaultValue = new InputIssueList();
        private static InputIssueList _inputIssuesEditFieldEnumCode = new InputIssueList();
        private static InputIssueList _inputIssuesFields = new InputIssueList();

        private static readonly string _alphabetLower = "abcdefghijklmnopqrstuvwxyz";
        private static readonly string _alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly string _alphabet = _alphabetLower + _alphabetUpper;
        private static readonly string _digits = "0123456789";
        private static readonly string _validNameChars = _alphabet + _digits;
        private static readonly string _validDispChars = _alphabet + _digits + " ";
        private static readonly string _validEnumCodeChars = _alphabet + _digits + "_";
        private static readonly string _validTypeChars = _alphabet + _digits + " _()&*:.->";
        private static readonly string _validDefaultValueChars = _validTypeChars + "{}[]\"'`+-*/%<>|&!?:";

        private static Timer _nameTimer = new Timer();
        private static Timer _dispSingularTimer = new Timer();
        private static Timer _dispPluralTimer = new Timer();
        private static Timer _enumCodeTimer = new Timer();
        private static Timer _editFieldTypeTimer = new Timer();
        private static Timer _editFieldNameTimer = new Timer();
        private static Timer _editFieldDispTimer = new Timer();
        private static Timer _editFieldDefaultValueTimer = new Timer();
        private static Timer _editFieldEnumCodeTimer = new Timer();
        private static Timer _editFieldTypeSelectTimer = new Timer();
        private static Timer _editFieldNameSelectTimer = new Timer();
        private static Timer _editFieldDispSelectTimer = new Timer();
        private static Timer _editFieldDefaultValueSelectTimer = new Timer();
        private static Timer _editFieldEnumCodeSelectTimer = new Timer();

        private static bool IsComposedOf(string str, string pallette)
        {
            foreach (char ch in str) if (!pallette.Contains(ch)) return false;
            return true;
        }

        private static bool IsAlpha(string str)
        {
            return IsComposedOf(str, _alphabet);
        }

        void DisplayFirstIssue(InputIssueList issueList, Label label)
        {
            InputIssue issue = issueList.FirstIssueOrNull;
            if (issue is null)
                label.Text = "";
            else
                issue.DisplayInControl(label);
        }

        InputIssueList ValidateInputName()
        {
            string text = txtName.Text;
            _inputIssuesName.Clear();

            if (!IsAlpha(text))
            {
                _inputIssuesName.Add(Warning.NonAlphaInName);
                if (!IsComposedOf(text, _validNameChars))
                    _inputIssuesName.Add(Error.InvalidCharsInName);
            }

            if (text.Length == 0)
            {
                _inputIssuesName.Add(Error.NameEmpty);
            }
            else
            {
                if (!text.ToUpper().StartsWith(text.Substring(0, 1)))
                    _inputIssuesName.Add(Error.NameNotPascalCase);
            }

            DisplayFirstIssue(_inputIssuesName, lblIssueName);
            return _inputIssuesName;
        }

        InputIssueList ValidateInputDispSingular()
        {
            string text = txtDispSingular.Text;
            _inputIssuesDispSingular.Clear();

            if (!IsComposedOf(text, _alphabet + " "))
            {
                _inputIssuesDispSingular.Add(Warning.NonAlphaInDisp);
                if (!IsComposedOf(text, _validDispChars))
                    _inputIssuesDispSingular.Add(Warning.InvalidCharsInDisp);
            }

            if (!text.Equals(text.ToLower()))
                _inputIssuesDispSingular.Add(Error.DispNotLowerCase);

            DisplayFirstIssue(_inputIssuesDispSingular, lblIssueDispSingular);
            return _inputIssuesDispSingular;
        }

        InputIssueList ValidateInputDispPlural()
        {
            string text = txtDispPlural.Text;
            _inputIssuesDispPlural.Clear();

            if (!IsComposedOf(text, _alphabet + " "))
            {
                _inputIssuesDispPlural.Add(Warning.NonAlphaInDisp);
                if (!IsComposedOf(text, _validDispChars))
                    _inputIssuesDispPlural.Add(Warning.InvalidCharsInDisp);
            }

            if (!text.Equals(text.ToLower()))
                _inputIssuesDispPlural.Add(Error.DispNotLowerCase);

            DisplayFirstIssue(_inputIssuesDispPlural, lblIssueDispPlural);
            return _inputIssuesDispPlural;
        }

        InputIssueList ValidateInputEnumCode()
        {
            string text = txtEnumCode.Text;
            _inputIssuesEnumCode.Clear();

            if (!IsComposedOf(text, _alphabet + "_"))
            {
                _inputIssuesEnumCode.Add(Warning.NonAlphaInEnumCode);
                if (!IsComposedOf(text, _validEnumCodeChars))
                    _inputIssuesEnumCode.Add(Error.InvalidCharsInEnumCode);
            }

            if (!text.Equals(text.ToUpper()))
                _inputIssuesEnumCode.Add(Error.EnumCodeNotUpperCase);

            DisplayFirstIssue(_inputIssuesEnumCode, lblIssueEnumCode);
            return _inputIssuesEnumCode;
        }

        InputIssueList GetIssuesInFieldType(string fieldType)
        {
            InputIssueList issues = new InputIssueList();
            if (!IsComposedOf(fieldType, _validTypeChars))
                issues.Add(Warning.InvalidCharsInFieldType);
            return issues;
        }

        InputIssueList GetIssuesInFieldName(string fieldName)
        {
            InputIssueList issues = new InputIssueList();
            if (!IsAlpha(fieldName))
            {
                issues.Add(Warning.NonAlphaInFieldName);
                if (!IsComposedOf(fieldName, _validNameChars))
                    issues.Add(Error.InvalidCharsInFieldName);
            }
            if (fieldName.Length == 0)
            {
                issues.Add(Error.FieldNameEmpty);
            }
            else
            {
                if (!fieldName.ToLower().StartsWith(fieldName.Substring(0, 1)))
                    issues.Add(Error.FieldNameNotCamelCase);
            }
            return issues;
        }

        InputIssueList GetIssuesInFieldDisp(string fieldDisp)
        {
            InputIssueList issues = new InputIssueList();
            if (!IsComposedOf(fieldDisp, _alphabet + " "))
            {
                issues.Add(Warning.NonAlphaInFieldDisp);
                if (!IsComposedOf(fieldDisp, _validDispChars))
                    issues.Add(Warning.InvalidCharsInFieldDisp);
            }
            if (!fieldDisp.Equals(fieldDisp.ToLower()))
                issues.Add(Error.FieldDispNotLowerCase);
            return issues;
        }

        InputIssueList GetIssuesInFieldDefaultValue(string fieldDefaultValue)
        {
            InputIssueList issues = new InputIssueList();
            if (!IsComposedOf(fieldDefaultValue, _validDefaultValueChars))
                issues.Add(Warning.InvalidCharsInFieldDefaultValue);
            return issues;
        }

        InputIssueList GetIssuesInFieldEnumCode(string fieldEnumCode)
        {
            InputIssueList issues = new InputIssueList();
            if (!IsComposedOf(fieldEnumCode, _alphabet + "_"))
            {
                issues.Add(Warning.NonAlphaInFieldEnumCode);
                if (!IsComposedOf(fieldEnumCode, _validEnumCodeChars))
                    issues.Add(Error.InvalidCharsInFieldEnumCode);
            }
            if (!fieldEnumCode.Equals(fieldEnumCode.ToUpper()))
                issues.Add(Error.FieldEnumCodeNotUpperCase);
            return issues;
        }

        InputIssueList ValidateInputFieldType()
        {
            if (listViewFields.SelectedItems.Count != 0)
                _inputIssuesEditFieldType = GetIssuesInFieldType(GetColumn(listViewFields.SelectedItems[0], colFieldType).Text);
            else
                _inputIssuesEditFieldType.Clear();
            DisplayFirstIssue(_inputIssuesEditFieldType, lblIssueEditFieldType);
            return _inputIssuesEditFieldType;
        }

        InputIssueList ValidateInputFieldName()
        {
            if (listViewFields.SelectedItems.Count != 0)
                _inputIssuesEditFieldName = GetIssuesInFieldName(GetColumn(listViewFields.SelectedItems[0], colFieldName).Text);
            else
                _inputIssuesEditFieldName.Clear();
            DisplayFirstIssue(_inputIssuesEditFieldName, lblIssueEditFieldName);
            return _inputIssuesEditFieldName;
        }

        InputIssueList ValidateInputFieldDisp()
        {
            if (listViewFields.SelectedItems.Count != 0)
                _inputIssuesEditFieldDisp = GetIssuesInFieldDisp(GetColumn(listViewFields.SelectedItems[0], colFieldDisp).Text);
            else
                _inputIssuesEditFieldDisp.Clear();
            DisplayFirstIssue(_inputIssuesEditFieldDisp, lblIssueEditFieldDisp);
            return _inputIssuesEditFieldDisp;
        }

        InputIssueList ValidateInputFieldDefaultValue()
        {
            if (listViewFields.SelectedItems.Count != 0)
                _inputIssuesEditFieldDefaultValue = GetIssuesInFieldDefaultValue(GetColumn(listViewFields.SelectedItems[0], colFieldDefaultValue).Text);
            else
                _inputIssuesEditFieldDefaultValue.Clear();
            DisplayFirstIssue(_inputIssuesEditFieldDefaultValue, lblIssueEditFieldDefaultValue);
            return _inputIssuesEditFieldDefaultValue;
        }

        InputIssueList ValidateInputFieldEnumCode()
        {
            if (listViewFields.SelectedItems.Count != 0)
                _inputIssuesEditFieldEnumCode = GetIssuesInFieldEnumCode(GetColumn(listViewFields.SelectedItems[0], colFieldEnumCode).Text);
            else
                _inputIssuesEditFieldEnumCode.Clear();
            DisplayFirstIssue(_inputIssuesEditFieldEnumCode, lblIssueEditFieldEnumCode);
            return _inputIssuesEditFieldEnumCode;
        }

        InputIssueList ValidateInputFields()
        {
            _inputIssuesFields.Clear();

            // Must be at least one field
            if (listViewFields.Items.Count == 0)
                _inputIssuesFields.Add(Error.TooFewFields);

            // Every field name and enum code must be unique
            for (int i = 0; i < listViewFields.Items.Count; i++)
            {
                for (int j = i + 1; j < listViewFields.Items.Count; j++)
                {
                    if (GetColumn(listViewFields.Items[i], colFieldName).Text.Equals(GetColumn(listViewFields.Items[j], colFieldName)))
                        _inputIssuesFields.Add(Error.NonUniqueFieldName);
                    if (GetColumn(listViewFields.Items[i], colFieldEnumCode).Text.Equals(GetColumn(listViewFields.Items[j], colFieldEnumCode)))
                        _inputIssuesFields.Add(Error.NonUniqueFieldEnumCode);
                }
            }

            // There must be no issues with any of the particular fields
            foreach (ListViewItem lvi in listViewFields.Items)
            {
                _inputIssuesFields += GetIssuesInFieldType(GetColumn(lvi, colFieldType).Text);
                _inputIssuesFields += GetIssuesInFieldName(GetColumn(lvi, colFieldName).Text);
                _inputIssuesFields += GetIssuesInFieldDisp(GetColumn(lvi, colFieldDisp).Text);
                _inputIssuesFields += GetIssuesInFieldDefaultValue(GetColumn(lvi, colFieldDefaultValue).Text);
                _inputIssuesFields += GetIssuesInFieldEnumCode(GetColumn(lvi, colFieldEnumCode).Text);
            }

            DisplayFirstIssue(_inputIssuesFields, lblIssueFields);

            return _inputIssuesFields;
        }

        public static string Capitalise(string str)
        {
            if (str.Length == 0)
                return str;
            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }

        public static string PascalCaseToDisp(string str)
        {
            str = str.Replace(" ", "");

            for (int i = 0; i < str.Length; i++)
            {
                string subStr = str.Substring(i, 1);
                if (subStr.Equals(subStr.ToUpper()))
                {
                    str = str.Remove(i, 1);
                    str = str.Insert(i, " " + subStr.ToLower());
                    i++;
                }
            }

            // The algorithm above will add a space on the front - chop it off!
            return str.TrimStart(' ');
        }

        public static string CamelCaseToDisp(string str)
        {
            return PascalCaseToDisp(Capitalise(str));
        }

        public static string PascalCaseToEnumCode(string str)
        {
            return PascalCaseToDisp(str).Replace(' ', '_').ToUpper();
        }

        public static string CamelCaseToEnumCode(string str)
        {
            return PascalCaseToEnumCode(Capitalise(str));
        }

        public static bool IsCapitalised(string str)
        {
            if (str.Length == 0)
                return false;
            string first = str.Substring(0, 1);
            return first.ToUpper() == first;
        }

        public static bool IsCapitalisedCamelCase(string str)
        {
            return IsCapitalised(str) && IsAlpha(str);
        }

        public WizardForm()
        {
            InitializeComponent();
            this.CancelButton = btnCancel;
            this.AcceptButton = btnAdd;
            txtName.Text = ItemName;
            _nameTimer.Interval = 1000;
            _dispSingularTimer.Interval = 1000;
            _dispPluralTimer.Interval = 1000;
            _enumCodeTimer.Interval = 1000;
            _editFieldTypeTimer.Interval = 1000;
            _editFieldNameTimer.Interval = 1000;
            _editFieldDispTimer.Interval = 1000;
            _editFieldDefaultValueTimer.Interval = 1000;
            _editFieldEnumCodeTimer.Interval = 1000;
            _editFieldTypeSelectTimer.Interval = 10;
            _editFieldNameSelectTimer.Interval = 10;
            _editFieldDispSelectTimer.Interval = 10;
            _editFieldDefaultValueSelectTimer.Interval = 10;
            _editFieldEnumCodeSelectTimer.Interval = 10;
            _nameTimer.Tick += new EventHandler((s, e) => OnTxtNameChanged());
            _dispSingularTimer.Tick += new EventHandler((s, e) => OnTxtDispSingularChanged());
            _dispPluralTimer.Tick += new EventHandler((s, e) => OnTxtDispPluralChanged());
            _enumCodeTimer.Tick += new EventHandler((s, e) => OnTxtEnumCodeChanged());
            _editFieldTypeTimer.Tick += new EventHandler((s, e) => OnTxtEditFieldTypeChanged());
            _editFieldNameTimer.Tick += new EventHandler((s, e) => OnTxtEditFieldNameChanged());
            _editFieldDispTimer.Tick += new EventHandler((s, e) => OnTxtEditFieldDispChanged());
            _editFieldDefaultValueTimer.Tick += new EventHandler((s, e) => OnTxtEditFieldDefaultValueChanged());
            _editFieldEnumCodeTimer.Tick += new EventHandler((s, e) => OnTxtEditFieldEnumCodeChanged());
            _editFieldTypeSelectTimer.Tick += new EventHandler((s, e) => { txtEditFieldType.SelectAll(); _editFieldTypeSelectTimer.Stop(); });
            _editFieldNameSelectTimer.Tick += new EventHandler((s, e) => { txtEditFieldName.SelectAll(); _editFieldNameSelectTimer.Stop(); });
            _editFieldDispSelectTimer.Tick += new EventHandler((s, e) => { txtEditFieldDisp.SelectAll(); _editFieldDispSelectTimer.Stop(); });
            _editFieldDefaultValueSelectTimer.Tick += new EventHandler((s, e) => { txtEditFieldDefaultValue.SelectAll(); _editFieldDefaultValueSelectTimer.Stop(); });
            _editFieldEnumCodeSelectTimer.Tick += new EventHandler((s, e) => { txtEditFieldEnumCode.SelectAll(); _editFieldEnumCodeSelectTimer.Stop(); });
            _nameTimer.Enabled = false;
            _dispSingularTimer.Enabled = false;
            _dispPluralTimer.Enabled = false;
            _enumCodeTimer.Enabled = false;
            _editFieldTypeTimer.Enabled = false;
            _editFieldNameTimer.Enabled = false;
            _editFieldDispTimer.Enabled = false;
            _editFieldDefaultValueTimer.Enabled = false;
            _editFieldEnumCodeTimer.Enabled = false;
            _editFieldTypeSelectTimer.Enabled = false;
            _editFieldNameSelectTimer.Enabled = false;
            _editFieldDispSelectTimer.Enabled = false;
            _editFieldDefaultValueSelectTimer.Enabled = false;
            _editFieldEnumCodeSelectTimer.Enabled = false;
            OnTxtNameChanged();
            OnTxtDispSingularChanged();
            OnTxtDispPluralChanged();
            OnTxtEnumCodeChanged();
            OnFieldsChanged();
            OnTxtEditFieldTypeChanged();
            OnTxtEditFieldNameChanged();
            OnTxtEditFieldDispChanged();
            OnTxtEditFieldDefaultValueChanged();
            OnTxtEditFieldEnumCodeChanged();
        }

        private void listViewFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = listViewFields.SelectedItems.Count;

            // If exactly one row is selected, load it for editing. Otherwise, disable editing.
            if (count == 1)
                StartEditingField(listViewFields.SelectedItems[0]);
            else
                StopEditingField();

            // If any rows are selected, enable deleting. Otherwise, disable deleting.
            if (count > 0)
                EnableDeleteFieldButton();
            else
                DisableDeleteFieldButton();
        }

        private void DeleteSelectedFields()
        {
            foreach (ListViewItem lvi in listViewFields.SelectedItems)
                listViewFields.Items.Remove(lvi);
        }

        private void listViewFields_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                DeleteSelectedFields();
        }

        private void chkbxDefaultDispSingular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxDefaultDispSingular.Checked)
            {
                txtDispSingular.Enabled = false;
                ((WindowsTextObject)txtDispSingular).GreyOut();
                ((WindowsTextObject)lblDispSingular).GreyOut();
            }
            else
            {
                txtDispSingular.Enabled = true;
                txtDispSingular.ForeColor = System.Drawing.SystemColors.WindowText;
                lblDispSingular.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void chkbxDefaultDispPlural_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxDefaultDispPlural.Checked)
            {
                txtDispPlural.Enabled = false;
                ((WindowsTextObject)txtDispPlural).GreyOut();
                ((WindowsTextObject)lblDispPlural).GreyOut();
            }
            else
            {
                txtDispPlural.Enabled = true;
                ((WindowsTextObject)txtDispPlural).UnGreyOut();
                ((WindowsTextObject)lblDispPlural).UnGreyOut();
            }
        }

        private void chkbxDefaultEnumCode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxDefaultEnumCode.Checked)
            {
                txtEnumCode.Enabled = false;
                ((WindowsTextObject)txtEnumCode).GreyOut();
                ((WindowsTextObject)lblEnumCode).GreyOut();
            }
            else
            {
                txtEnumCode.Enabled = true;
                ((WindowsTextObject)txtEnumCode).UnGreyOut();
                ((WindowsTextObject)lblEnumCode).UnGreyOut();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel = true;
            this.Close();
        }

        private void UpdateAndClose()
        {
            Cancel = false;
            QuestionTypeName = txtName.Text;
            QuestionTypeDispSingular = txtDispSingular.Text;
            QuestionTypeDispPlural = txtDispPlural.Text;
            QuestionTypeEnumCode = txtEnumCode.Text;
            QuestionTypeFields = new List<QuestionTypeField>(listViewFields.Items.Count);
            foreach (ListViewItem item in listViewFields.Items)
            {
                QuestionTypeFields.Add(new QuestionTypeField(
                    GetColumn(item, colFieldType).Text,
                    GetColumn(item, colFieldName).Text,
                    GetColumn(item, colFieldDisp).Text,
                    GetColumn(item, colFieldEnumCode).Text,
                    GetColumn(item, colFieldDefaultValue).Text
                ));
            }
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InputIssueList issueList = new InputIssueList();
            issueList += ValidateInputName();
            issueList += ValidateInputDispSingular();
            issueList += ValidateInputDispPlural();
            issueList += ValidateInputEnumCode();
            issueList += ValidateInputFields();

            if (issueList.ContainsErrors())
            {
                string message = "Your input generated the following errors. You must fix all these errors before you can create a new question type.";
                foreach (InputIssue error in issueList.Errors)
                    message += "\n\n" + error.Message;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK);
                return;
            }

            if (issueList.ContainsWarnings())
            {
                string message = "Your input generated the following warnings:";
                foreach (InputIssue warning in issueList.Warnings)
                    message += "\n\n" + warning.Message;
                message += "\n\n\nIt is strongly advised you go back and fix these warnings before proceeding.";
                if (MessageBox.Show(message, "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    UpdateAndClose();
                return;
            }

            UpdateAndClose();
        }

        void DisableEditingFieldColumn(TextBox txtBox, Label label)
        {
            txtBox.Enabled = false;
            ((WindowsTextObject)label).GreyOut();
        }

        private void DisableUpdateFieldButton()
        {
            ((WindowsTextObject)btnUpdateField).GreyOut();
            btnUpdateField.Enabled = false;
        }

        private void DisableDeleteFieldButton()
        {
            ((WindowsTextObject)btnDeleteField).GreyOut();
            btnDeleteField.Enabled = false;
        }

        private void StopEditingField()
        {
            txtEditFieldType.Text = "";
            txtEditFieldName.Text = "";
            txtEditFieldDisp.Text = "";
            txtEditFieldDefaultValue.Text = "";
            txtEditFieldEnumCode.Text = "";
            _inputIssuesEditFieldType.Clear();
            _inputIssuesEditFieldName.Clear();
            _inputIssuesEditFieldDisp.Clear();
            _inputIssuesEditFieldDefaultValue.Clear();
            _inputIssuesEditFieldEnumCode.Clear();
            DisableEditingFieldColumn(txtEditFieldType, lblEditFieldType);
            DisableEditingFieldColumn(txtEditFieldName, lblEditFieldName);
            DisableEditingFieldColumn(txtEditFieldDisp, lblEditFieldDisp);
            DisableEditingFieldColumn(txtEditFieldDefaultValue, lblEditFieldDefaultValue);
            DisableEditingFieldColumn(txtEditFieldEnumCode, lblEditFieldEnumCode);
            DisableUpdateFieldButton();
        }

        void EnableEditingFieldColumn(TextBox txtBox, Label label)
        {
            ((WindowsTextObject)txtBox).UnBold();
            txtBox.Enabled = true;
            ((WindowsTextObject)label).UnGreyOut();
        }

        private void EnableUpdateFieldButton()
        {
            ((WindowsTextObject)btnUpdateField).UnGreyOut();
            btnUpdateField.Enabled = true;
        }

        private void EnableDeleteFieldButton()
        {
            ((WindowsTextObject)btnDeleteField).UnGreyOut();
            btnDeleteField.Enabled = true;
        }

        private void StartEditingField(ListViewItem lviToEdit)
        {
            // Update text box contents
            txtEditFieldType.Text = GetColumn(lviToEdit, colFieldType).Text;
            txtEditFieldName.Text = GetColumn(lviToEdit, colFieldName).Text;
            txtEditFieldDisp.Text = GetColumn(lviToEdit, colFieldDisp).Text;
            txtEditFieldDefaultValue.Text = GetColumn(lviToEdit, colFieldDefaultValue).Text;
            txtEditFieldEnumCode.Text = GetColumn(lviToEdit, colFieldEnumCode).Text;

            // Enable editing type and name
            EnableEditingFieldColumn(txtEditFieldType, lblEditFieldType);
            EnableEditingFieldColumn(txtEditFieldName, lblEditFieldName);

            // If other fields are default, check the box and make sure they're disabled. Otherwise, enable editing.

            if (txtEditFieldDisp.Text.Equals(GenerateDefaultFieldDisp(txtEditFieldName.Text)))
            {
                chkbxDefaultFieldDisp.Checked = true;
                DisableEditingFieldColumn(txtEditFieldDisp, lblEditFieldDisp);
            }
            else
            {
                chkbxDefaultFieldDisp.Checked = false;
                EnableEditingFieldColumn(txtEditFieldDisp, lblEditFieldDisp);
            }

            if (txtEditFieldDefaultValue.Text.Equals(GenerateDefaultFieldDefaultValue(txtEditFieldType.Text)))
            {
                chkbxDefaultFieldDefaultValue.Checked = true;
                DisableEditingFieldColumn(txtEditFieldDefaultValue, lblEditFieldDefaultValue);
            }
            else
            {
                chkbxDefaultFieldDefaultValue.Checked = false;
                EnableEditingFieldColumn(txtEditFieldDefaultValue, lblEditFieldDefaultValue);
            }

            if (txtEditFieldEnumCode.Text.Equals(GenerateDefaultFieldEnumCode(txtEditFieldName.Text)))
            {
                chkbxDefaultFieldEnumCode.Checked = true;
                DisableEditingFieldColumn(txtEditFieldEnumCode, lblEditFieldEnumCode);
            }
            else
            {
                chkbxDefaultFieldEnumCode.Checked = false;
                EnableEditingFieldColumn(txtEditFieldEnumCode, lblEditFieldEnumCode);
            }

            OnTxtEditFieldTypeChanged();
            OnTxtEditFieldNameChanged();
            OnTxtEditFieldDispChanged();
            OnTxtEditFieldDefaultValueChanged();
            OnTxtEditFieldEnumCodeChanged();
        }

        private void OnFieldsChanged()
        {
            ValidateInputFields();
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            string[] subItems = { _defaultFieldType, _defaultFieldName, _defaultFieldDisp, _defaultFieldDefaultValue, _defaultFieldEnumCode };
            ListViewItem newLvi = new ListViewItem(subItems);
            newLvi = listViewFields.Items.Add(newLvi);
            listViewFields.SelectedIndices.Clear();
            listViewFields.SelectedIndices.Add(listViewFields.Items.IndexOf(newLvi));
            StartEditingField(newLvi);
            OnFieldsChanged();
        }

        private void UpdateFieldColumn(WindowsTextObject column, string input)
        {
            column.Text = input;
        }

        private void btnUpdateField_Click(object sender, EventArgs e)
        {
            // We should only be enabled if exactly one row is selected. Best to double-check anyway.
            if (listViewFields.SelectedItems.Count != 1)
                return;

            ListViewItem lvi = listViewFields.SelectedItems[0];
            UpdateFieldColumn(GetColumn(lvi, colFieldType), txtEditFieldType.Text);
            UpdateFieldColumn(GetColumn(lvi, colFieldName), txtEditFieldName.Text);
            UpdateFieldColumn(GetColumn(lvi, colFieldDisp), txtEditFieldDisp.Text);
            UpdateFieldColumn(GetColumn(lvi, colFieldDefaultValue), txtEditFieldDefaultValue.Text);
            UpdateFieldColumn(GetColumn(lvi, colFieldEnumCode), txtEditFieldEnumCode.Text);
        }

        private void btnDeleteField_Click(object sender, EventArgs e)
        {
            DeleteSelectedFields();
        }

        private WindowsTextObject GetColumn(ListViewItem lvi, ColumnHeader col)
        {
            if (col.DisplayIndex == 0)
                return lvi;
            return lvi.SubItems[col.DisplayIndex];
        }

        private bool IsEditTypeDifferent(ListViewItem lvi)
        {
            return !txtEditFieldType.Text.Equals(GetColumn(lvi, colFieldType).Text);
        }

        private bool IsEditNameDifferent(ListViewItem lvi)
        {
            return !txtEditFieldName.Text.Equals(GetColumn(lvi, colFieldName).Text);
        }

        private bool IsEditDispDifferent(ListViewItem lvi)
        {
            return !txtEditFieldDisp.Text.Equals(GetColumn(lvi, colFieldDisp).Text);
        }

        private bool IsEditDefaultValueDifferent(ListViewItem lvi)
        {
            return !txtEditFieldDefaultValue.Text.Equals(GetColumn(lvi, colFieldDefaultValue).Text);
        }

        private bool IsEditEnumCodeDifferent(ListViewItem lvi)
        {
            return !txtEditFieldEnumCode.Text.Equals(GetColumn(lvi, colFieldEnumCode).Text);
        }

        private void AfterEditFieldChanged()
        {

            // Bolden text iff it differs from current value.

            bool isAnyDifferent = false;

            if (listViewFields.SelectedItems.Count != 1)
                return;
            ListViewItem lvi = listViewFields.SelectedItems[0];

            if (IsEditTypeDifferent(lvi))
            {
                isAnyDifferent = true;
                ((WindowsTextObject)txtEditFieldType).Bold();
            }
            else
            {
                ((WindowsTextObject)txtEditFieldType).UnBold();
            }

            if (IsEditNameDifferent(lvi))
            {
                isAnyDifferent = true;
                ((WindowsTextObject)txtEditFieldName).Bold();
            }
            else
            {
                ((WindowsTextObject)txtEditFieldName).UnBold();
            }

            if (IsEditDispDifferent(lvi))
            {
                isAnyDifferent = true;
                ((WindowsTextObject)txtEditFieldDisp).Bold();
            }
            else
            {
                ((WindowsTextObject)txtEditFieldDisp).UnBold();
            }

            if (IsEditDefaultValueDifferent(lvi))
            {
                isAnyDifferent = true;
                ((WindowsTextObject)txtEditFieldDefaultValue).Bold();
            }
            else
            {
                ((WindowsTextObject)txtEditFieldDefaultValue).UnBold();
            }

            if (IsEditEnumCodeDifferent(lvi))
            {
                isAnyDifferent = true;
                ((WindowsTextObject)txtEditFieldEnumCode).Bold();
            }
            else
            {
                ((WindowsTextObject)txtEditFieldEnumCode).UnBold();
            }

            // Grey out text iff using default value.
            
            if (chkbxDefaultFieldDisp.Checked)
                ((WindowsTextObject)txtEditFieldDisp).GreyOut();
            else
                ((WindowsTextObject)txtEditFieldDisp).UnGreyOut();

            if (chkbxDefaultFieldDefaultValue.Checked)
                ((WindowsTextObject)txtEditFieldDefaultValue).GreyOut();
            else
                ((WindowsTextObject)txtEditFieldDefaultValue).UnGreyOut();

            if (chkbxDefaultFieldEnumCode.Checked)
                ((WindowsTextObject)txtEditFieldEnumCode).GreyOut();
            else
                ((WindowsTextObject)txtEditFieldEnumCode).UnGreyOut();

            // Enable update button iff at least one field differs from currently stored value

            if (isAnyDifferent)
                EnableUpdateFieldButton();
            else
                DisableUpdateFieldButton();
        }

        private void OnTxtNameChanged()
        {
            ValidateInputName();

            // Update automatic fields
            if (chkbxDefaultDispSingular.Checked)
            {
                txtDispSingular.Text = PascalCaseToDisp(txtName.Text);
                if (chkbxDefaultDispPlural.Checked)
                    txtDispPlural.Text = txtDispSingular.Text + "s";
            }
            if (chkbxDefaultEnumCode.Checked)
                txtEnumCode.Text = PascalCaseToEnumCode(txtName.Text);
        }

        private void OnTxtDispSingularChanged()
        {
            ValidateInputDispSingular();

            // Auto-update plural
            if (chkbxDefaultDispPlural.Checked)
                txtDispPlural.Text = txtDispSingular.Text + "s";
        }

        private void OnTxtDispPluralChanged()
        {
            ValidateInputDispPlural();
        }

        private void OnTxtEnumCodeChanged()
        {
            ValidateInputEnumCode();
        }

        private static string GenerateDefaultFieldDefaultValue(string fieldType)
        {
            string defaultValue = "new " + fieldType + "()";
            if (fieldType == "std::string")
                defaultValue = "\"\"";
            else if (fieldType == "std::wstring")
                defaultValue = "L\"\"";
            else if (fieldType == "std::byte")
                defaultValue = "std::byte{ 0 }";
            else if (fieldType == "char" || fieldType == "short" || fieldType == "int")
                defaultValue = "0";
            else if (fieldType == "unsigned char" || fieldType == "unsigned short" || fieldType == "unsigned int")
                defaultValue = "0u";
            else if (fieldType == "long int")
                defaultValue = "0l";
            else if (fieldType == "unsigned long int")
                defaultValue = "0ul";
            else if (fieldType == "long long int")
                defaultValue = "0ll";
            else if (fieldType == "unsigned long long int")
                defaultValue = "0ull";
            else if (fieldType == "size_t" || fieldType == "std::size_t")
                defaultValue = "0uz";
            else if (fieldType == "float")
                defaultValue = "0.f";
            else if (fieldType == "double")
                defaultValue = "0.d";
            else if (fieldType == "long double")
                defaultValue = "0.l";
            else if (fieldType.EndsWith("*"))
                defaultValue = "nullptr";
            return defaultValue;
        }

        private static string GenerateDefaultFieldDisp(string fieldName)
        {
            return CamelCaseToDisp(fieldName);
        }

        private static string GenerateDefaultFieldEnumCode(string fieldName)
        {
            return CamelCaseToEnumCode(fieldName);
        }

        private void OnTxtEditFieldTypeChanged()
        {
            if (listViewFields.SelectedItems.Count == 0)
            {
                txtEditFieldType.Text = "";
                ValidateInputFieldType();
                return;
            }

            txtEditFieldType.Text = txtEditFieldType.Text.Trim();
            ValidateInputFieldType();

            // Auto-update default value as appropriate
            if (chkbxDefaultFieldDefaultValue.Checked)
                txtEditFieldDefaultValue.Text = GenerateDefaultFieldDefaultValue(txtEditFieldType.Text);

            AfterEditFieldChanged();
        }

        private void OnTxtEditFieldNameChanged()
        {
            if (listViewFields.SelectedItems.Count == 0)
            {
                txtEditFieldName.Text = "";
                ValidateInputFieldName();
                return;
            }

            txtEditFieldName.Text = txtEditFieldName.Text.Trim();
            ValidateInputFieldName();

            // Auto-update disp and enum code as appropriate
            string text = txtEditFieldName.Text;
            if (chkbxDefaultFieldDisp.Checked)
                txtEditFieldDisp.Text = GenerateDefaultFieldDisp(text);
            if (chkbxDefaultEnumCode.Checked)
                txtEditFieldEnumCode.Text = GenerateDefaultFieldEnumCode(text);

            AfterEditFieldChanged();
        }

        private void OnTxtEditFieldDispChanged()
        {
            if (listViewFields.SelectedItems.Count == 0)
            {
                txtEditFieldDisp.Text = "";
                ValidateInputFieldDisp();
                return;
            }

            txtEditFieldDisp.Text = txtEditFieldDisp.Text.Trim();
            ValidateInputFieldDisp();
            AfterEditFieldChanged();
        }

        private void OnTxtEditFieldDefaultValueChanged()
        {
            if (listViewFields.SelectedItems.Count == 0)
            {
                txtEditFieldDefaultValue.Text = "";
                ValidateInputFieldDefaultValue();
                return;
            }

            txtEditFieldDefaultValue.Text = txtEditFieldDefaultValue.Text.Trim();
            ValidateInputFieldDefaultValue();
            AfterEditFieldChanged();
        }

        private void OnTxtEditFieldEnumCodeChanged()
        {
            if (listViewFields.SelectedItems.Count == 0)
            {
                txtEditFieldEnumCode.Text = "";
                ValidateInputFieldEnumCode();
                return;
            }

            txtEditFieldEnumCode.Text = txtEditFieldEnumCode.Text.Trim();
            ValidateInputFieldEnumCode();
            AfterEditFieldChanged();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            OnTxtNameChanged();                    
        }

        private void txtDispSingular_Leave(object sender, EventArgs e)
        {
            OnTxtDispSingularChanged();
        }

        private void txtDispPlural_Leave(object sender, EventArgs e)
        {
            OnTxtDispPluralChanged();
        }

        private void txtEnumCode_Leave(object sender, EventArgs e)
        {
            OnTxtEnumCodeChanged();
        }

        private void txtEditType_Leave(object sender, EventArgs e)
        {
            txtEditFieldType.DeselectAll();
            OnTxtEditFieldTypeChanged();
        }

        private void txtEditFieldName_Leave(object sender, EventArgs e)
        {
            txtEditFieldName.DeselectAll();
            OnTxtEditFieldNameChanged();
        }

        private void txtEditFieldDisp_Leave(object sender, EventArgs e)
        {
            txtEditFieldDisp.DeselectAll();
            OnTxtEditFieldDispChanged();
        }

        private void txtEditFieldDefaultValue_Leave(object sender, EventArgs e)
        {
            txtEditFieldDefaultValue.DeselectAll();
            OnTxtEditFieldDefaultValueChanged();
        }

        private void txtEditFieldEnumCode_Leave(object sender, EventArgs e)
        {
            txtEditFieldEnumCode.DeselectAll();
            OnTxtEditFieldEnumCodeChanged();
        }

        private void txtEditFieldType_TextChanged(object sender, EventArgs e)
        {
            ((WindowsTextObject)txtEditFieldType).Bold();
            _editFieldTypeTimer.Stop();
            _editFieldTypeTimer.Start();
        }

        private void txtEditFieldName_TextChanged(object sender, EventArgs e)
        {
            ((WindowsTextObject)txtEditFieldName).Bold();
            _editFieldNameTimer.Stop();
            _editFieldNameTimer.Start();
        }

        private void txtEditFieldDisp_TextChanged(object sender, EventArgs e)
        {
            ((WindowsTextObject)txtEditFieldDisp).Bold();
            _editFieldDispTimer.Stop();
            _editFieldDispTimer.Start();
        }

        private void txtEditFieldDefaultValue_TextChanged(object sender, EventArgs e)
        {
            ((WindowsTextObject)txtEditFieldDefaultValue).Bold();
            _editFieldDefaultValueTimer.Stop();
            _editFieldDefaultValueTimer.Start();
        }

        private void txtEditFieldEnumCode_TextChanged(object sender, EventArgs e)
        {
            ((WindowsTextObject)txtEditFieldEnumCode).Bold();
            _editFieldEnumCodeTimer.Stop();
            _editFieldEnumCodeTimer.Start();
        }

        private void chkbxDefaultFieldDisp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxDefaultFieldDisp.Checked)
            {
                OnTxtEditFieldNameChanged();
                DisableEditingFieldColumn(txtEditFieldDisp, lblEditFieldDisp);
            }
            else
            {
                EnableEditingFieldColumn(txtEditFieldDisp, lblEditFieldDisp);
            }
        }

        private void chkbxDefaultFieldDefaultValue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxDefaultFieldDefaultValue.Checked)
            {
                OnTxtEditFieldTypeChanged();
                DisableEditingFieldColumn(txtEditFieldDefaultValue, lblEditFieldDefaultValue);
            }
            else
            {
                EnableEditingFieldColumn(txtEditFieldDefaultValue, lblEditFieldDefaultValue);
            }
        }

        private void chkbxDefaultFieldEnumCode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxDefaultFieldEnumCode.Checked)
            {
                OnTxtEditFieldEnumCodeChanged();
                DisableEditingFieldColumn(txtEditFieldEnumCode, lblEditFieldEnumCode);
            }
            else
            {
                EnableEditingFieldColumn(txtEditFieldEnumCode, lblEditFieldEnumCode);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            _nameTimer.Stop();
            _nameTimer.Start();
        }

        private void txtDispSingular_TextChanged(object sender, EventArgs e)
        {
            _dispSingularTimer.Stop();
            _dispSingularTimer.Start();
        }

        private void txtDispPlural_TextChanged(object sender, EventArgs e)
        {
            _dispPluralTimer.Stop();
            _dispPluralTimer.Start();
        }

        private void txtEnumCode_TextChanged(object sender, EventArgs e)
        {
            _enumCodeTimer.Stop();
            _enumCodeTimer.Start();
        }

        private void txtEditFieldType_Enter(object sender, EventArgs e)
        {
            _editFieldTypeSelectTimer.Start();
        }

        private void txtEditFieldName_Enter(object sender, EventArgs e)
        {
            _editFieldNameSelectTimer.Start();
        }

        private void txtEditFieldDisp_Enter(object sender, EventArgs e)
        {
            _editFieldDispSelectTimer.Start();
        }

        private void txtEditFieldDefaultValue_Enter(object sender, EventArgs e)
        {
            _editFieldDefaultValueSelectTimer.Start();
        }

        private void txtEditFieldEnumCode_Enter(object sender, EventArgs e)
        {
            _editFieldEnumCodeSelectTimer.Start();
        }
    }

    public class QuestionTypeField
    {
        public string Type { get; private set; }
        public string Name { get; private set; }
        public string NameCapitalised { get { return WizardForm.Capitalise(Name); } }
        public string Disp { get; private set; }
        public string DispCapitalised { get { return WizardForm.Capitalise(Disp); } }
        public string EnumCode { get; private set; }
        public string DefaultValue { get; private set; }
        public QuestionTypeField(string type, string name, string disp, string enumCode, string defaultValue)
        {
            Type = type;
            Name = name;
            Disp = disp;
            EnumCode = enumCode;
            DefaultValue = defaultValue;
        }
    }
}
