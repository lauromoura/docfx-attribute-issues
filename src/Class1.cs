using System;
using System.ComponentModel;

namespace src
{

    [AttributeUsage(AttributeTargets.Method)]
    public class MyAttribute : Attribute
    {
        public MyAttribute(MyWhen when)
        {
            this.When = when;
        }

        public MyWhen When { get; set; }
    }

    public enum MyWhen
    {
        Always,
        Advanced,
        Never,
    }

    public class Class1
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Shortened()
        {
        }

        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public void Complete()
        {
        }

        [MyAttribute(When.Never)]
        public void WithCustom()
        {
        }
    }
}
