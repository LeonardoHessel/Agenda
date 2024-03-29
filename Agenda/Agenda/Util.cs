﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Util
    {
        public enum Sex
        {
            Female,
            Male
        }

        public enum ActionMode
        {
            New,
            Edit
        }

        public enum AccessMode
        {
            Login,
            CheckAccess
        }

        public enum ActiveStatus
        {
            All,
            Active,
            Disabled
        }

        public enum DatabaseAction
        {
            Insert,
            Read,
            Update,
            Delete
        }

        public static string NoMask(System.Windows.Forms.MaskedTextBox mtb)
        {
            mtb.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            string rtn = mtb.Text;
            mtb.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            return rtn;
        }
    }
}
