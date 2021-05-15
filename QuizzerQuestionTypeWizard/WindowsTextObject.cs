using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace QuizzerQuestionTypeWizard
{
    class WindowsTextObject
    {
        private dynamic _base;
        private Type _baseType;
        public string Text { get { return _base.Text; } set { _base.Text = value; } }
        public Color ForeColor { get { return _base.ForeColor; } set { _base.ForeColor = value; } }
        public Font Font { get { return _base.Font; } set { _base.Font = value; } }

        private WindowsTextObject(dynamic obj)
        {
            _base = obj;
            _baseType = obj.GetType();
        }
        
        public void GreyOut()
        {
            ForeColor = SystemColors.GrayText;
        }


        public void UnGreyOut()
        {
            ForeColor = SystemColors.ControlText;
        }

        public void StyleText(FontStyle fontStyle)
        {
            Font = new Font(Font, fontStyle);
        }

        public void Italicise()
        {
            StyleText(FontStyle.Italic);
        }

        public void Bold()
        {
            StyleText(FontStyle.Bold);
        }

        public void UnBold()
        {
            StyleText(Font.Style & ~FontStyle.Bold);
        }

        public void Deitalicise()
        {
            StyleText(Font.Style & ~FontStyle.Italic);
        }

        public void GreyOutAndItalicise()
        {
            GreyOut();
            Italicise();
        }

        public void UnGreyOutAndDeitalicise()
        {
            UnGreyOut();
            Deitalicise();
        }

        public static implicit operator TextBox(WindowsTextObject wto)
        {
            if (wto._baseType != typeof(TextBox))
                throw new InvalidCastException();
            return wto._base;
        }

        public static implicit operator WindowsTextObject(TextBox txt)
        {
            return new WindowsTextObject(txt);
        }

        public static implicit operator Label(WindowsTextObject wto)
        {
            if (wto._baseType != typeof(Label))
                throw new InvalidCastException();
            return wto._base;
        }

        public static implicit operator WindowsTextObject(Label lbl)
        {
            return new WindowsTextObject(lbl);
        }

        public static implicit operator ListViewItem(WindowsTextObject wto)
        {
            if (wto._baseType != typeof(ListViewItem))
                throw new InvalidCastException();
            return wto._base;
        }

        public static implicit operator WindowsTextObject(ListViewItem lvi)
        {
            return new WindowsTextObject(lvi);
        }

        public static implicit operator ListViewItem.ListViewSubItem(WindowsTextObject wto)
        {
            if (wto._baseType != typeof(ListViewItem.ListViewSubItem))
                throw new InvalidCastException();
            return wto._base;
        }

        public static implicit operator WindowsTextObject(ListViewItem.ListViewSubItem lvsi)
        {
            return new WindowsTextObject(lvsi);
        }

        public static implicit operator Button(WindowsTextObject wto)
        {
            if (wto._baseType != typeof(Button))
                throw new InvalidCastException();
            return wto._base;
        }

        public static implicit operator WindowsTextObject(Button btn)
        {
            return new WindowsTextObject(btn);
        }
    }
}
