using System;
using System.Collections.Generic;

namespace MvcDynamicForm.Models
{
    public class FormFiedlsModel
    {
        public string Id { get; set; }
        public ControlType FieldType { get; set; }
        public string DisplayTitle { get; set; }
        public string Required { get; set; }
        public string Weight { get; set; }
        public string Size { get; set; }
        public string Group { get; set; }
        public List<ListObject> PreValues { get; set; }
        public string UserValue { get; set; }
    }

    public enum ControlType
    {
        Textbox, 
        TextArea, 
        Checkbox, 
        CheckboxList, 
        Dropdown, 
        Radiobutton, 
        RadioButtonlist
    }
    public class ListObject
    {
        public string ControlId { get; set; }
        public string Value { get; set; }
        public string Text { get; set; }
    }
}
