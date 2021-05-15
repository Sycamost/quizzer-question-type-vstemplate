using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QuizzerQuestionTypeWizard
{
    class InputIssue
    {
        protected enum InputIssueType
        {
            ERROR,
            WARNING
        };
        private InputIssueType _type;
        public string Message { get; private set; }
        public bool IsError() { return _type == InputIssueType.ERROR; }
        public bool IsWarning() { return _type == InputIssueType.WARNING; }
        public void DisplayInControl(dynamic control)
        {
            control.ForeColor = IsError() ? System.Drawing.Color.Red : System.Drawing.Color.DarkOrange;
            control.Text = Message;
        }
        protected InputIssue(InputIssueType type, string message)
        {
            _type = type;
            Message = message;
        }
        public static bool operator ==(InputIssue lhs, InputIssue rhs)
        {
            if (lhs is null) return false;
            if (rhs is null) return false;
            return lhs.Message == rhs.Message && lhs._type == rhs._type;
        }
        public static bool operator !=(InputIssue lhs, InputIssue rhs)
        {
            return lhs.Message != rhs.Message || lhs._type != rhs._type;
        }
        public override bool Equals(object o)
        {
            if (!(o is InputIssue))
                return false;
            return (InputIssue)o == this;
        }
        public override int GetHashCode()
        {
            return _type.GetHashCode() + 2 * Message.GetHashCode();
        }
    }

    class Error : InputIssue
    {
        private Error(string message) : base(InputIssueType.ERROR, message) { }
        public static Error TooFewFields = new Error("The question type must have at least one field.");
        public static Error NonUniqueFieldName = new Error("Not all field names are unique.");
        public static Error NonUniqueFieldEnumCode = new Error("Not all field enum codes are unique.");
        public static Error InvalidCharsInName = new Error("Name contains invalid characters.");
        public static Error NameNotPascalCase = new Error("Name is not in pascal case (e.g. \"PascalCase\"");
        public static Error NameEmpty = new Error("Name is empty.");
        public static Error DispNotLowerCase = new Error("Display string is not lower-case.");
        public static Error InvalidCharsInEnumCode = new Error("Enum code contains invalid characters.");
        public static Error EnumCodeNotUpperCase = new Error("Enum code is not upper-case.");
        public static Error InvalidCharsInFieldName = new Error("Field name contains invalid characters.");
        public static Error FieldNameNotCamelCase = new Error("Field name is not in camel case (e.g. \"camelCase\"");
        public static Error FieldNameEmpty = new Error("Field name is empty.");
        public static Error FieldDispNotLowerCase = new Error("Display string is not lower-case.");
        public static Error InvalidCharsInFieldEnumCode = new Error("Field enum code contains invalid characters.");
        public static Error FieldEnumCodeNotUpperCase = new Error("Field enum code is not upper-case.");
    }

    class Warning : InputIssue
    {
        private Warning(string message) : base(InputIssueType.WARNING, message) { }
        public static Warning NonAlphaInName = new Warning("Name contains non-alphabetical characters.");
        public static Warning NonAlphaInDisp = new Warning("Display string contains non-alphabetical characters.");
        public static Warning InvalidCharsInDisp = new Warning("Display string probably contains invalid characters.");
        public static Warning InvalidCharsInFieldType = new Warning("One of the fields has a type containing what are probably invalid characters.");
        public static Warning NonAlphaInEnumCode = new Warning("Enum code contains non-alphabetical characters.");
        public static Warning NonAlphaInFieldName = new Warning("Field name contains non-alphabetical characters.");
        public static Warning NonAlphaInFieldDisp = new Warning("Field display string contains non-alphabetical characters.");
        public static Warning InvalidCharsInFieldDisp = new Warning("Field display string probably contains invalid characters.");
        public static Warning InvalidCharsInFieldDefaultValue = new Warning("One of the fields has a default value containing what are probably invalid characters.");
        public static Warning NonAlphaInFieldEnumCode = new Warning("Field enum code contains non-alphabetical characters.");
    }

    class InputIssueList : IEnumerable<InputIssue>
    {
        private List<InputIssue> _data;
        private Action<string> _post;
        public InputIssue FirstIssueOrNull
        {
            // Always get errors first. Otherwise, order is arbitrary.
            get
            {
                if (_data.Count == 0)
                    return null;
                if (ContainsErrors())
                    return _data.Find(issue => issue.IsError());
                return _data[0];
            }
        }

        public void Clear()
        {
            _data.Clear();
        }

        public IEnumerator<InputIssue> GetEnumerator()
        {
            foreach (InputIssue issue in _data) yield return issue;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public InputIssueList()
        {
            _data = new List<InputIssue>();
            _post = _ => { };
        }
        public InputIssueList(Action<string> post)
        {
            _data = new List<InputIssue>();
            _post = post;
        }
        private InputIssueList(List<InputIssue> data)
        {
            _data = data;
            _post = _ => { };
        }
        public bool Add(InputIssue issue)
        {
            if (_data.Contains(issue))
                return false;
            _data.Add(issue);
            if (_data.Count == 1)
                _post(issue.Message);
            return true;
        }
        public bool Remove(InputIssue issue)
        {
            int index = _data.IndexOf(issue);
            if (index == -1)
                return false;
            _data.RemoveAt(index);
            return true;
        }
        public bool IsEmpty()
        {
            return _data.Count == 0;
        }
        public bool ContainsErrors()
        {
            return _data.Exists(issue => issue.IsError());
        }
        public bool ContainsWarnings()
        {
            return _data.Exists(issue => issue.IsWarning());
        }
        public InputIssueList Errors
        {
            get
            {
                return new InputIssueList(_data.FindAll(issue => issue.IsError()));
            }
        }
        public InputIssueList Warnings
        {
            get
            {
                return new InputIssueList(_data.FindAll(issue => issue.IsWarning()));
            }
        }
        public static InputIssueList operator +(InputIssueList lhs, InputIssueList rhs)
        {
            List<InputIssue> data = lhs._data;
            data.AddRange(rhs._data);
            return new InputIssueList(data);
        }
    }
}
