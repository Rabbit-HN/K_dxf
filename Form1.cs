using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Alter_Flat_Parameter
{
    public partial class Form1 : Form
    {
        public int trigger; 
        public List<string> list_ipt_dir=new List<string>();//original place ipt document
        //public List<string> list_ipt_dir_2=new List<string>();
        public List<string> list_ipt_dir_new=new List<string>();// new place and alter name ipt document
        public List<string> list_ipt_num=new List<string>();
        public List<string> list_dxf_dir=new List<string>();
        public int count_ipt,count_ipt_2;
        public int select_index;
        public string dxf_path;
        public string alter_k_value;
        public string dxf_dir;
        public string new_ipt_dir;
        public string Metal_thickness;
        public string Date;
        public int Click_times;
        public int Dxf_counts;
        public string Enclosure_NO;

        public string Userdomain_name = Environment.UserDomainName;
        public string LoginName = Environment.UserName;
        public string MachineName = Environment.MachineName;
        public string IPv4_address;
        public IPAddress oIPAdress;

        public static int percentComplete;
        public BackgroundWorker bgWorker=new BackgroundWorker();

        Dxf_convert_run dxf_convert = new Dxf_convert_run();


        public Form1()
        {
            InitializeComponent();
            InitalizeBackgroundWorker();

        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            dxf_convert.End_Inventor();
            Close();
            
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void cmd_selection_Click(object sender, EventArgs e)
        {
            trigger += 1;
            openFileDialog1.Title = "请选择ipt文件";
            openFileDialog1.Filter = "Autodesk Inventor 钣金件(*.ipt)|*.ipt";
            openFileDialog1.InitialDirectory = "D:\\";
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowHelp = true;
            openFileDialog1.RestoreDirectory = false;
            if(openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                trigger -= 1;
            }
            else
            {
                listBox1.BackColor = Color.LightPink;
                if(trigger == 1)
                {
                    count_ipt = openFileDialog1.FileNames.Count();
                    for(int i=0; i < count_ipt; i++)
                    {
                        list_ipt_dir.Add(openFileDialog1.FileNames[i]);
                        list_ipt_num.Add(System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileNames[i]));
                        if (txt_outpath.Text != "")
                        {
                            new_ipt_dir = System.IO.Path.Combine(dxf_path, System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileNames[i]) + "_PGSD.ipt");
                            list_ipt_dir_new.Add(new_ipt_dir);

                        }
                        else
                        {
                            MessageBox.Show("dxf文件存储路径不为空");
                            return;
                        }
                    }
                }
                else if(trigger > 1)
                {
                    count_ipt_2 = openFileDialog1.FileNames.Count();
                    for (int i = 0; i < count_ipt_2; i++)
                    {
                        list_ipt_dir.Add(openFileDialog1.FileNames[i]);
                        list_ipt_num.Add(System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileNames[i]));
                        if (txt_outpath.Text != "")
                        {
                            new_ipt_dir = System.IO.Path.Combine(dxf_path, System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileNames[i]) + "_PGSD.ipt");
                            list_ipt_dir_new.Add(new_ipt_dir);

                        }
                        else
                        {
                            MessageBox.Show("dxf文件存储路径不为空");
                            return;
                        }
                        
                        
                    }
                }
                for(int i = 0; i < list_ipt_num.Count; i++)
                {
                    listBox1.Items.Add(list_ipt_num[i]);
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trigger = 0;
            comb_thickness.Text=comb_thickness.Items[3].ToString();
            txt_outpath.Text = "D:\\";
            label_prog.Text = "0%";
            progressBar1.Maximum = 100;
            comb_thickness.Text = comb_thickness.Items[3].ToString();
            Metal_thickness = comb_thickness.Text;
            txt_Kvalue.Text = "0.4855";
            alter_k_value=txt_Kvalue.Text;
            oIPAdress=Get_IPv4_Address();
            IPv4_address= oIPAdress.ToString();

        }

        private void txt_outpath_TextChanged(object sender, EventArgs e)
        {
            if(txt_outpath.Text == "")
            {
                MessageBox.Show("DXF展开图导出路径不为空！");
                txt_outpath.BackColor = Color.Red;
            }
            else
            {
                txt_outpath.BackColor = Color.LightGreen;
                dxf_path = txt_outpath.Text;
            }
          
        }

        private void cmd_clear_Click(object sender, EventArgs e)
        {
            trigger = 0;
            list_ipt_dir.Clear();
            list_ipt_num.Clear();
            count_ipt = 0;
            count_ipt_2 = 0;
            listBox1.SelectedIndex = 0;
            listBox1.Items.Clear();
            if (list_dxf_dir.Count != 0)
            {
                list_dxf_dir.Clear();
            }
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count == 0)
            {
                MessageBox.Show("没有删除项！");
                return;
            }
            else
            {

                select_index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.Update();
                list_ipt_dir.RemoveAt(select_index);
                list_ipt_num.RemoveAt(select_index);
                list_ipt_dir_new.RemoveAt(select_index);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select_index = listBox1.SelectedIndex;
        }

        private void cmd_confirm_Click(object sender, EventArgs e)
        {
            if (txt_en_NO.Text == "")
            {
                txt_en_NO.BackColor = Color.Red;
                MessageBox.Show("外壳图号不为空！");
                return;
            }

            if (txt_Kvalue.Text == "0" || txt_Kvalue.Text=="")
            {
                MessageBox.Show("K系数值不能为0或不能为空！");
                txt_Kvalue.BackColor = Color.Red;
                return;
            }
            if(txt_outpath.Text == "")
            {
                MessageBox.Show("DXF展开图导出路径不为空！");
                txt_outpath.BackColor = Color.Red;
                return;
            }
            if (listBox1.Items.Count==0)
            {
                MessageBox.Show("未选择ipt文件！");
                listBox1.BackColor = Color.Red;
                return;
            }
            if(txt_Kvalue.Text != "0" && txt_Kvalue.Text != "" && txt_outpath.Text != "" && listBox1.Items.Count!=0 && txt_en_NO.Text!="")
            {
                cmd_confirm.Enabled = false;
                cmd_selection.Enabled=false;
                cmd_delete.Enabled=false;
                cmd_clear.Enabled=false;
                cmd_path.Enabled=false;
                comb_thickness.Enabled=false;
                txt_en_NO.Enabled=false;
                txt_outpath.Enabled=false;
                txt_Kvalue.Enabled=false;
                if (dataGridView1.Rows.Count != 0)
                {
                    dataGridView1.Rows.Clear();
                }
                ++Click_times;


                //Start program running
                for (int i = 0; i < list_ipt_num.Count; i++)
                {
                    dxf_dir = System.IO.Path.Combine(dxf_path, list_ipt_num[i] + ".dxf");
                  
                    list_dxf_dir.Add(dxf_dir);
                    //list_ipt_dir_new.Add(new_ipt_dir);
                    
                }

                Connect_Server_State();
                if (!bgWorker.IsBusy)
                {
                    bgWorker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("程序已经在运行，请不要重复点击确定！");
                }
               
                
                //恢复初始设置值

            }

        }

        private void txt_Kvalue_TextChanged(object sender, EventArgs e)
        {
            if (txt_Kvalue.Text == "")
            {
                MessageBox.Show("K系数值不能为空！");
                txt_Kvalue.BackColor = Color.Red;
            }
            //else if (txt_Kvalue.Text == "0")
            //{
            //    MessageBox.Show("K系数值不能为0");
            //    txt_Kvalue.BackColor = Color.Red;
            //}
            if(txt_Kvalue.Text!=""&& txt_Kvalue.Text != "0")
            {
                txt_Kvalue.BackColor = Color.LightGreen;
                alter_k_value=txt_Kvalue.Text;
            }
        }
        private void comb_thickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            Metal_thickness = comb_thickness.Text;
        }

        private void InitalizeBackgroundWorker()
        {
            bgWorker.WorkerReportsProgress = true;
            bgWorker.WorkerSupportsCancellation = true;
            bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
            bgWorker.ProgressChanged += new ProgressChangedEventHandler(bgWorker_ProgressChanged);
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
        }
        private void bgWorker_ProgressChanged(object sender,ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label_prog.Text= e.ProgressPercentage.ToString()+"%";
        }
        private void bgWorker_RunWorkerCompleted(object sender,RunWorkerCompletedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("DXF图纸转换完毕，请到保存的路径下获取图纸！", "提示", MessageBoxButtons.OK);
        }

        private void cmd_path_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txt_outpath.Text = folderBrowserDialog1.SelectedPath;
            dxf_path = txt_outpath.Text;

        }

        private void cmd_clear_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            list_ipt_dir.Clear();
            list_ipt_dir_new.Clear();
            list_ipt_num.Clear();
            listBox1.Update();
        }

        private void txt_en_NO_TextChanged(object sender, EventArgs e)
        {
            if (txt_en_NO.Text == "")
            {
                MessageBox.Show("外壳图号不为空值！");
                txt_en_NO.BackColor = Color.Red;
            }
            else
            {
                Enclosure_NO = txt_en_NO.Text;
                txt_en_NO.BackColor = Color.LightGreen;
            }

        }

        private void bgWorker_DoWork(object sender,DoWorkEventArgs e)
        {
            bgWorker.WorkerReportsProgress= true;
            
            dxf_convert.Start_Inventor();
            for(int i=0;i<list_ipt_num.Count;i++)
            {
                dxf_convert.copy_file(list_ipt_dir[i], list_ipt_dir_new[i]);
            }
            dxf_convert.ToggleEventTriggerDisabled();
            
            List<string> list_bool_delete=new List<string>();
            int i_count = 0;

            for(int i= 0; i <list_dxf_dir.Count; i++)
            {
                dxf_convert.alter_K_value(list_dxf_dir[i], list_ipt_dir_new[i],Metal_thickness, alter_k_value);


                list_bool_delete.Add(Dxf_convert_run.success);

                if (Dxf_convert_run.success == "是")
                {
                    //dataGridView1.Rows.Add();
                    dataGridView1.Invoke(new Action(() => dataGridView1.Rows.Add()));
                    dataGridView1.Rows[i_count].Cells[0].Value = i_count + 1;
                    //dataGridView1.Rows[i_count].Cells[0].ReadOnly = true;

                    dataGridView1.Rows[i_count].Cells[1].Value = list_ipt_num[i];
                    //dataGridView1.Rows[i_count].Cells[1].ReadOnly=true;

                    dataGridView1.Rows[i_count].Cells[2].Value = Dxf_convert_run.Material;
                    //dataGridView1.Rows[i_count].Cells[2].ReadOnly = true;

                    dataGridView1.Rows[i_count].Cells[3].Value = Dxf_convert_run.unchange_kfactor;
                    dataGridView1.Rows[i_count].Cells[3].Style.BackColor = Color.LightSkyBlue;
                    //dataGridView1.Rows[i_count].Cells[3].ReadOnly = true;

                    dataGridView1.Rows[i_count].Cells[4].Value = Dxf_convert_run.unchange_flat_l + "*" + Dxf_convert_run.unchange_flat_w;
                    dataGridView1.Rows[i_count].Cells[4].Style.BackColor = Color.LightSkyBlue;
                    //dataGridView1.Rows[i_count].Cells[4].ReadOnly = true;

                    dataGridView1.Rows[i_count].Cells[5].Value = alter_k_value;
                    dataGridView1.Rows[i_count].Cells[5].Style.BackColor = Color.LightGreen;
                    //dataGridView1.Rows[i_count].Cells[5].ReadOnly = true;

                    dataGridView1.Rows[i_count].Cells[6].Value = Dxf_convert_run.change_flat_l + "*" + Dxf_convert_run.change_flat_w;
                    dataGridView1.Rows[i_count].Cells[6].Style.BackColor = Color.LightGreen;
                    //dataGridView1.Rows[i_count].Cells[6].ReadOnly = true;


                    dataGridView1.Rows[i_count].Cells[7].Value = Dxf_convert_run.success;
                    //dataGridView1.Rows[i_count].Cells[7].ReadOnly = true;
                    i_count++;
                }
                percentComplete = (i + 1) * 100 / list_dxf_dir.Count;


                bgWorker.ReportProgress(percentComplete);

            }
            for (int i = 0; i < list_bool_delete.Count; i++)
            {
                if (list_bool_delete[i] == "否")
                {
                    System.IO.File.Delete(list_ipt_dir_new[i]);
                }
            }

            dxf_convert.data_output_excel(dataGridView1, dxf_path,Enclosure_NO);

           
            
            Date=System.DateTime.Now.ToString();
            Dxf_counts = i_count;
            list_dxf_dir.Clear();
            list_bool_delete.Clear();
            i_count = 0;
            //data write to server
            SqlServers new_SqlServers=new SqlServers();
            new_SqlServers.common_SQL = new_SqlServers.str_Sql_connection("DXF_Kfactor", "172.21.114.175", "sa", "jst123456");
            new_SqlServers.common_SQL.Open();   
            new_SqlServers.str_Sql_insert("Table_dxf", "Enclosure_NO", "Date", "Click_times", "DXF_count", "DomainName", "LoginName", "MachineName","IPAddress");
            new_SqlServers.Date_Insert<string,string,int,int,string,string,string,string>
                (new_SqlServers.common_SQL, Enclosure_NO,Date,Click_times,Dxf_counts, Userdomain_name, LoginName, MachineName,IPv4_address);
            cmd_confirm.Invoke(new Action(() => cmd_confirm.Enabled = true));
            cmd_selection.Invoke(new Action(() => cmd_selection.Enabled = true));
            cmd_delete.Invoke(new Action(() => cmd_delete.Enabled = true));
            cmd_clear.Invoke(new Action(() => cmd_clear.Enabled = true));
            cmd_path.Invoke(new Action(() => cmd_path.Enabled = true));
            txt_en_NO.Invoke(new Action(() => txt_en_NO.Enabled = true));
            txt_Kvalue.Invoke(new Action(() => txt_Kvalue.Enabled = true));
            txt_outpath.Invoke(new Action(() => txt_outpath.Enabled = true));
            comb_thickness.Invoke(new Action(() => comb_thickness.Enabled = true));
        }


        private IPAddress Get_IPv4_Address()
        {
            IPAddress localIP = null;
            System.Net.IPAddress[] List_address=Dns.GetHostAddresses(Dns.GetHostName());
            foreach(IPAddress ip in List_address)
            {
                if(ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    localIP = ip;
                    break;
                }
                else
                {
                    continue;
                }
                
            }
            return localIP;
        }

        private void Connect_Server_State()
        {
            string ServerIP = "172.21.114.175";
            int port = 1433;
            using (TcpClient tcpClient = new TcpClient())
            {
                try
                {
                    tcpClient.Connect(ServerIP, port);
                    //MessageBox.Show("服务器连接成功！");
                }
                catch
                {
                    MessageBox.Show("服务器连接失败！");
                    return;
                }
            }

        }

    }
}
