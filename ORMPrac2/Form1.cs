using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORMPrac2 {
    public partial class Form1 : Form {
        public List<Model.AGENTS> oAgents;
        public List<Model.CUSTOMER> oCx;
        public List<Model.ORDER> oOrders;
        public int index = 0;

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            using (Model.DB2EntityContainer db = new Model.DB2EntityContainer()) {
                var oAgents = db.AGENTS.ToList();
                if (oAgents.Count > 0) {
                    MessageBox.Show("Database has information now", "Successful operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else { // fill db
                    using (var dbTransaction = db.Database.BeginTransaction()) {
                        try {
                            List<Model.AGENTS> agents = new List<Model.AGENTS>();
                            List<Model.CUSTOMER> cx = new List<Model.CUSTOMER>();
                            List<Model.ORDER> orders = new List<Model.ORDER>();

                            agents.Add(new Model.AGENTS { AGENT_CODE = 001, AGENT_NAME = "Ramasundar", WORKING_AREA = "Bangalore", COMISSION = 0, COUNTRY = "", PHONE_NO = "077-25814763" });
                            agents.Add(new Model.AGENTS { AGENT_CODE = 002, AGENT_NAME = "Alex", WORKING_AREA = "Londo", COMISSION = 0.13m, COUNTRY = "", PHONE_NO = "077-43323" });
                            agents.Add(new Model.AGENTS { AGENT_CODE = 003, AGENT_NAME = "Alford", WORKING_AREA = "New York", COMISSION = 0.12m, COUNTRY = "", PHONE_NO = "077-3441314" });
                            agents.Add(new Model.AGENTS { AGENT_CODE = 004, AGENT_NAME = "Satakumar", WORKING_AREA = "chennai", COMISSION = 0.23m, COUNTRY = "", PHONE_NO = "077-84444675" });
                            agents.Add(new Model.AGENTS { AGENT_CODE = 005, AGENT_NAME = "lucida", WORKING_AREA = "San Jose", COMISSION = 0.27m, COUNTRY = "", PHONE_NO = "077-5411684" });
                            agents.Add(new Model.AGENTS { AGENT_CODE = 006, AGENT_NAME = "Anderson", WORKING_AREA = "Brisban", COMISSION = 0.232m, COUNTRY = "", PHONE_NO = "077-544646354" });
                            agents.Add(new Model.AGENTS { AGENT_CODE = 007, AGENT_NAME = "Ivan", WORKING_AREA = "Toronto", COMISSION = 0.56m, COUNTRY = "", PHONE_NO = "077-644546" });

                            cx.Add(new Model.CUSTOMER { CUST_CODE = 0001, CUST_NAME = "Holmes", CUST_CITY = "Londo", WORKING_AREA = "Tokio", CUST_COUNTRY = "USD", GRADE = 2, OPENING_AMT = 6000, RECEIVE_AMT = 7000, PAYMENT_AMT = 6000, OUTSTANDING_AMT = 8000, PHONE_NO = "05-4149941", AGENT_CODE = 001 });
                            cx.Add(new Model.CUSTOMER { CUST_CODE = 0002, CUST_NAME = "Michael", CUST_CITY = "new York", WORKING_AREA = "venezuela", CUST_COUNTRY = "UK", GRADE = 3, OPENING_AMT = 400, RECEIVE_AMT = 5000, PAYMENT_AMT = 60641694, OUTSTANDING_AMT = 40000, PHONE_NO = "05-4199494", AGENT_CODE = 002 });
                            cx.Add(new Model.CUSTOMER { CUST_CODE = 0003, CUST_NAME = "Albert", CUST_CITY = "New York", WORKING_AREA = "London", CUST_COUNTRY = "JP", GRADE = 4, OPENING_AMT = 20000, RECEIVE_AMT = 62222, PAYMENT_AMT = 6500000, OUTSTANDING_AMT = 60000, PHONE_NO = "06-5426941", AGENT_CODE = 003 });
                            cx.Add(new Model.CUSTOMER { CUST_CODE = 0004, CUST_NAME = "Stuard", CUST_CITY = "London", WORKING_AREA = "Canada", CUST_COUNTRY = "NGL", GRADE = 5, OPENING_AMT = 52000, RECEIVE_AMT = 6000, PAYMENT_AMT = 50000, OUTSTANDING_AMT = 44222, PHONE_NO = "0-555", AGENT_CODE = 004 });
                            cx.Add(new Model.CUSTOMER { CUST_CODE = 0005, CUST_NAME = "Bolt", CUST_CITY = "Singapur", WORKING_AREA = "Toronto", CUST_COUNTRY = "COL", GRADE = 6, OPENING_AMT = 620000, RECEIVE_AMT = 4000, PAYMENT_AMT = 60000, OUTSTANDING_AMT = 852858, PHONE_NO = "075-20757", AGENT_CODE = 005 });
                            cx.Add(new Model.CUSTOMER { CUST_CODE = 0006, CUST_NAME = "fleming", CUST_CITY = "Tokio", WORKING_AREA = "Estambul", CUST_COUNTRY = "URG", GRADE = 7, OPENING_AMT = 5450000, RECEIVE_AMT = 9000, PAYMENT_AMT = 70000, OUTSTANDING_AMT = 58585, PHONE_NO = "5757572", AGENT_CODE = 006 });
                            cx.Add(new Model.CUSTOMER { CUST_CODE = 0007, CUST_NAME = "Jacks", CUST_CITY = "London", WORKING_AREA = "San francisco", CUST_COUNTRY = "PJ", GRADE = 8, OPENING_AMT = 520000, RECEIVE_AMT = 7000, PAYMENT_AMT = 9000, OUTSTANDING_AMT = 78585, PHONE_NO = "5757275", AGENT_CODE = 007 });
                            cx.Add(new Model.CUSTOMER { CUST_CODE = 0008, CUST_NAME = "Yearannaidu", CUST_CITY = "Bogota", WORKING_AREA = "Tokio", CUST_COUNTRY = "UK", GRADE = 0, OPENING_AMT = 45000, RECEIVE_AMT = 6000, PAYMENT_AMT = 1000, OUTSTANDING_AMT = 585858, PHONE_NO = "6996986986", AGENT_CODE = 001 });
                            cx.Add(new Model.CUSTOMER { CUST_CODE = 0009, CUST_NAME = "Yearannaidu", CUST_CITY = "Bogota", WORKING_AREA = "Tokio", CUST_COUNTRY = "UK", GRADE = 0, OPENING_AMT = 45000, RECEIVE_AMT = 6000, PAYMENT_AMT = 1000, OUTSTANDING_AMT = 585858, PHONE_NO = "6996986986", AGENT_CODE = 002 });
                            cx.Add(new Model.CUSTOMER { CUST_CODE = 00010, CUST_NAME = "Yearannaidu", CUST_CITY = "Bogota", WORKING_AREA = "Tokio", CUST_COUNTRY = "UK", GRADE = 0, OPENING_AMT = 45000, RECEIVE_AMT = 6000, PAYMENT_AMT = 1000, OUTSTANDING_AMT = 585858, PHONE_NO = "6996986986", AGENT_CODE = 003 });

                            orders.Add(new Model.ORDER { ORD_NUM = 100, ORD_AMOUNT = 15085550, ADVANCE_AMOUNT = "6000", ORD_DATE = new DateTime(2008, 08, 01), CUST_CODE = 00010, AGENT_CODE = 001, ORD_DESCRIPTION = "sod" });
                            orders.Add(new Model.ORDER { ORD_NUM = 100, ORD_AMOUNT = 150226222, ADVANCE_AMOUNT = "7000", ORD_DATE = new DateTime(2009, 08, 018), CUST_CODE = 0001, AGENT_CODE = 001, ORD_DESCRIPTION = "sod" });
                            orders.Add(new Model.ORDER { ORD_NUM = 200, ORD_AMOUNT = 1502626262, ADVANCE_AMOUNT = "68000", ORD_DATE = new DateTime(2007, 06, 08), CUST_CODE = 0002, AGENT_CODE = 002, ORD_DESCRIPTION = "sod" });
                            orders.Add(new Model.ORDER { ORD_NUM = 300, ORD_AMOUNT = 55029592, ADVANCE_AMOUNT = "9000", ORD_DATE = new DateTime(2004, 05, 07), CUST_CODE = 0003, AGENT_CODE = 003, ORD_DESCRIPTION = "sod" });
                            orders.Add(new Model.ORDER { ORD_NUM = 400, ORD_AMOUNT = 9508952959, ADVANCE_AMOUNT = "1000", ORD_DATE = new DateTime(2003, 03, 06), CUST_CODE = 0004, AGENT_CODE = 004, ORD_DESCRIPTION = "sod" });
                            orders.Add(new Model.ORDER { ORD_NUM = 500, ORD_AMOUNT = 3508599529, ADVANCE_AMOUNT = "6000", ORD_DATE = new DateTime(2002, 04, 05), CUST_CODE = 0005, AGENT_CODE = 005, ORD_DESCRIPTION = "sod" });
                            orders.Add(new Model.ORDER { ORD_NUM = 600, ORD_AMOUNT = 15049959, ADVANCE_AMOUNT = "6000", ORD_DATE = new DateTime(2001, 07, 04), CUST_CODE = 0006, AGENT_CODE = 006, ORD_DESCRIPTION = "sod" });
                            orders.Add(new Model.ORDER { ORD_NUM = 700, ORD_AMOUNT = 984426294, ADVANCE_AMOUNT = "6000", ORD_DATE = new DateTime(2009, 09, 03), CUST_CODE = 0007, AGENT_CODE = 007, ORD_DESCRIPTION = "sod" });
                            orders.Add(new Model.ORDER { ORD_NUM = 800, ORD_AMOUNT = 219494, ADVANCE_AMOUNT = "6000", ORD_DATE = new DateTime(2000, 08, 01), CUST_CODE = 0008, AGENT_CODE = 001, ORD_DESCRIPTION = "sod" });
                            orders.Add(new Model.ORDER { ORD_NUM = 900, ORD_AMOUNT = 4995585, ADVANCE_AMOUNT = "6000", ORD_DATE = new DateTime(2008, 01, 02), CUST_CODE = 0009, AGENT_CODE = 002, ORD_DESCRIPTION = "sod" });

                            db.AGENTS.AddRange(agents);
                            db.CUSTOMERS.AddRange(cx);
                            db.ORDER.AddRange(orders);
                            db.SaveChanges();
                            dbTransaction.Commit();

                            MessageBox.Show("Database has been populated successfully", "Successful operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } catch (Exception ex) {
                            dbTransaction.Rollback();
                            MessageBox.Show("An unexpected error occured, database could not be filled. \n\nApplication will be closed.", "Error found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();

                            return;
                        }
                    }
                    
                    MessageBox.Show("Database has been populated successfully", "Successful operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                button1.Enabled = false;
                oAgents = db.AGENTS.ToList();
                oCx = db.CUSTOMERS.ToList();
                oOrders = db.ORDER.ToList();
                index = 0;
                fill();
            }
        }

        public void fill() {
            if (index < 0) { 
                index = 0;
            }

            if (index >= oAgents.Count) {
                index = oAgents.Count - 1;
            }

            string str1 = "";
            string str2 = "";

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            str1 = oAgents[index].AGENT_CODE.ToString() + "  -  " + oAgents[index].AGENT_NAME + ", en " + oAgents[index].WORKING_AREA;
            textBox1.Text = str1;

            List<Model.CUSTOMER> iCustomer = new List<Model.CUSTOMER>();
            iCustomer = oCx.Where(a => a.AGENT_CODE == (int)oAgents[index].AGENT_CODE).ToList();
            if (iCustomer != null) {
                str1 = "";
                str2 = "";

                for (int i = 0; i < iCustomer.Count; i++) {
                    str1 = str1 + iCustomer[i].CUST_CODE.ToString() + " - " + iCustomer[i].CUST_NAME + ",";

                    List<Model.ORDER> jOrder = new List<Model.ORDER>();

                    jOrder = oOrders.Where(a => a.AGENT_CODE == (int)oAgents[index].AGENT_CODE && a.CUST_CODE == (int)iCustomer[i].CUST_CODE).ToList();
                    if (jOrder != null) {
                        for (int j = 0; j < jOrder.Count; j++) {
                            str2 = str2 + jOrder[j].ORD_NUM.ToString() + ",";
                        }
                    }
                }
                textBox2.Text = str1;
                textBox3.Text = str2;
            }
        }
    }
}
