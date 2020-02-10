﻿using Bit.Core.Enums;
using Bit.Core.Models.View;

namespace Bit.Core.Models.Export
{
    public class Field
    {
        public Field() { }

        public Field(FieldView obj)
        {
            if(obj == null)
            {
                return;
            }

            Name = obj.Name;
            Value = obj.Value;
            Type = obj.Type;
        }

        public string Name { get; set; }
        public string Value { get; set; }
        public FieldType Type { get; set; }

        public static FieldView ToView(Field req, FieldView view = null)
        {
            if(view == null)
            {
                view = new FieldView();
            }

            view.Type = req.Type;
            view.Value = req.Value;
            view.Name = req.Name;
            return view;
        }
    }
}
