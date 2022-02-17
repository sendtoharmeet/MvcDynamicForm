using MvcDynamicForm.Models;
using System.Collections.Generic;

namespace MvcDynamicForm.DataBase
{
    public static class MyData
    {
        public static List<FormFiedlsModel> MyFormData { get; set; }

        static MyData()
        {
            MyFormData = SetInitialdata();
        }

        public static List<FormFiedlsModel> SetInitialdata()
        {
            var checkBoxlist = new List<ListObject>();
            checkBoxlist.Add(new ListObject() { Value = "true", Text = "CheckBoxList-1", ControlId = "ChkList1" });
            checkBoxlist.Add(new ListObject() { Value = "false", Text = "CheckBoxList-2", ControlId = "ChkList2" });
            checkBoxlist.Add(new ListObject() { Value = "true", Text = "CheckBoxList-3", ControlId = "ChkList3" });
            checkBoxlist.Add(new ListObject() { Value = "false", Text = "CheckBoxList-4", ControlId = "ChkList4" });

            var comboList = new List<ListObject>();
            comboList.Add(new ListObject() { Value = "1", Text = "Combo-1" });
            comboList.Add(new ListObject() { Value = "2", Text = "Combo-2" });
            comboList.Add(new ListObject() { Value = "3", Text = "Combo-3" });
            comboList.Add(new ListObject() { Value = "4", Text = "Combo-4" });

            var radiolist = new List<ListObject>();
            radiolist.Add(new ListObject() { Value = "true", Text = "RadioList-1", ControlId = "RdList1" });
            radiolist.Add(new ListObject() { Value = "false", Text = "RadioList-2", ControlId = "RdList2" });
            radiolist.Add(new ListObject() { Value = "true", Text = "RadioList-3", ControlId = "RdList3" });
            radiolist.Add(new ListObject() { Value = "false", Text = "RadioList-4", ControlId = "RdList4" });

            var list = new List<FormFiedlsModel>();
            list.Add(new FormFiedlsModel() { DisplayTitle = "MyTextBox", UserValue = "MyTextBox value", Id = "MyTextBox1", FieldType = ControlType.Textbox, Required = "1" });

            list.Add(new FormFiedlsModel() { DisplayTitle = "MyTextArea", UserValue = "MyTextArea value", Id = "MyTextArea1", FieldType = ControlType.TextArea, Required = "1" });

            list.Add(new FormFiedlsModel() { DisplayTitle = "MyCheckbox", UserValue = "true", Id = "MyCheckbox1", FieldType = ControlType.Checkbox, Required = "1" });

            list.Add(new FormFiedlsModel() { DisplayTitle = "MyCheckboxList", UserValue = "true", Id = "MyCheckboxList1", FieldType = ControlType.CheckboxList, Required = "1", PreValues = checkBoxlist });

            list.Add(new FormFiedlsModel() { DisplayTitle = "MyDropdown", UserValue = "2", Id = "MyDropdown1", FieldType = ControlType.Dropdown, Required = "1", PreValues = comboList });

            list.Add(new FormFiedlsModel() { DisplayTitle = "MyRadiobutton", UserValue = "true", Id = "MyRadiobutton1", FieldType = ControlType.Radiobutton, Required = "1" });
            list.Add(new FormFiedlsModel() { DisplayTitle = "MyRadioButtonlist", UserValue = "true", Id = "MyRadioButtonlist1", FieldType = ControlType.RadioButtonlist, Required = "1", PreValues = radiolist });

            return list;
        }

        public static void SaveData(List<FormFiedlsModel> formFiedlsModels)
        {
            MyFormData = formFiedlsModels;
        }
    }
}
