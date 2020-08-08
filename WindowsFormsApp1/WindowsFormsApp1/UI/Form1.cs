using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActUtlTypeLib;
using WindowsFormsApp1.Entity;
using WindowsFormsApp1.Utils;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private string[] listmay = { "Bm", };// 22 MACHINE
        private string[] listdiachi = {"y0" }; // 22 dia chi
        public Form1()
        {
           
            InitializeComponent();
            lastestMachineState = new List<MachineState>();
            using (var db = new MyDbContext())
            {
                List<MachineState> listToInsert = new List<MachineState>();
                for (int i = 0; i < 22; i++)
                {
                    var machineId = listmay[i];
                    var machineInDb = db.MachineCollection.Find(x => x.Id.ToLower().Equals(machineId)).AsEnumerable().OrderByDescending(x =>x.Date).FirstOrDefault();
                    if (machineInDb != null)
                    {
                        if (!machineInDb.Address.Equals(listdiachi[i]))
                        {
                            machineInDb.Address = listdiachi[i];
                            db.MachineCollection.Update(machineInDb);
                        }
                        lastestMachineState.Add(machineInDb);
                    } else
                    {
                        var newMachine = new MachineState() { Id = machineId, Address = listdiachi[i], State = 1, Date = DateTime.Now };
                        listToInsert.Add(newMachine);
                        lastestMachineState.Add(newMachine);
                    }
                    db.MachineCollection.InsertBulk(listToInsert);
                }
            }
            //định thời export excel mỗi ngày lúc 23h 59p
            new Scheduler().Start();
        }
        public ActUtlType plc = new ActUtlType();
        
        int conectsystem;
        int BM0_MAINT;
        int BM0_PRO;
        int TIMER_MAINT;
        
        private void button1_Click(object sender, EventArgs e)
        {
            plc.ActLogicalStationNumber = 1;
            plc.Open();
            plc.Connect();
        
            plc.SetDevice("M2", 1);
            int readconnect;
            plc.GetDevice("M2", out readconnect);
            if (readconnect == 1) { MessageBox.Show("Connection Success", "Connect PLC"); }
            else
            {
                MessageBox.Show("Connection Success", "Connect PLC");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plc.SetDevice("M2", 0);
            // plc.Close();
            plc.Disconnect();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            //int readint;
            //plc.GetDevice(txtaddress.Text, out readint);
            //txtvalues.Text = readint.ToString();


        }
       
        private List<MachineState> lastestMachineState;
        private void button4_Click(object sender, EventArgs e)
        {
           // plc.SetDevice(txtaddress.Text, Convert.ToInt16(txtvalues.Text));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var listToAdd = new List<MachineState>();
            foreach (MachineState mc in lastestMachineState)
            {
                int plcState;
                plc.GetDevice(mc.Address,out plcState);

                if (mc.State != plcState)
                {
                    mc.State = plcState;
                    var now = DateTime.Now;
                    if(plcState == 1)
                    {
                        mc.FlagDown = true;
                        mc.Downtime = now.Ticks - mc.Date.Ticks;
                    }
                    mc.Date = now;
                    listToAdd.Add(mc);
                }
            }
            if(listToAdd.Count > 0)
            {
                Task.Run(() =>
                {
                    using(var db = new MyDbContext())
                    {
                        db.MachineCollection.InsertBulk(listToAdd);
                    }
                });
            }
            //plc.GetDevice("M2", out conectsystem);
            //plc.GetDevice("Y0", out BM0_MAINT);
            //plc.GetDevice("Y1", out BM0_PRO);
            //plc.GetDevice("d0", out TIMER_MAINT);
            //TIMER_MAINT = TIMER_MAINT / 10;
            //textBox1.Text = Convert.ToString(TIMER_MAINT);

            //textBox1.Text = TIMER_MAINT.ToString();
            //if (BM0_MAINT == 1)
            //{
            //    button3.BackColor = Color.Orange;
            //}
            //else { button3.BackColor = Color.White; };
            //if (BM0_PRO == 1)
            //{
            //    button4.BackColor = Color.Green;
            //}
            //else { button4.BackColor = Color.White; };

            //if (conectsystem == 1) { button1.BackColor = Color.Green;
            //    button2.BackColor = Color.Red;
            //};
            //if (conectsystem == 0) { button1.BackColor = Color.Red;
            //    button2.BackColor = Color.Green;
            //};
            //if (capture)
            //{
            //    // write file 
            //}
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 FM1 = new Form1();
            FM1.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}
