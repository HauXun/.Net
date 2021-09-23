using System;
using System.Data;
using Bunifu.UI.WinForms;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class TestFormBLL
    {
        private static TestFormBLL instance;

        public static TestFormBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TestFormBLL();
                return instance;
            }
            private set => instance = value;
        }

        private TestFormBLL() { }

        public void GetAllTestForm(BunifuDropdown box)
        {
            DataTable data = TestFormDAL.Instance.GetAllTestForm();
            if (data.Rows.Count > 0)
			{
                box.DisplayMember = "TestFormName";
                box.ValueMember = "TestFormID";
                box.DataSource = data;
            }
            DataRow dr = data.NewRow();
            dr["TestFormName"] = "(None)";
            dr["TestFormID"] = "None";// Some ID
            data.Rows.InsertAt(dr, 0);
        }
    }
}
