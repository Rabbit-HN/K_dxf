using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventor;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Net;
using System.Data.SqlClient;




namespace Alter_Flat_Parameter
{
    public class Dxf_convert_run
    {
        public static string unchange_kfactor;
        public static string original_kfactor;
        public static string unchange_flat_l;
        public static string unchange_flat_w;
        public static string change_flat_l;
        public static string change_flat_w;
        public static string Material;
        public static string success;



        private Inventor.Application _invApp;
        private bool _started;
        public void Start_Inventor()
        {
            bool inv_open_state = false;
            Process[] Procs = Process.GetProcesses();
            foreach(Process Proc in Procs)
            {
                if(Proc.ProcessName == "Inventor")
                {
                    inv_open_state = true;
                    try
                    {
                       _invApp = (Inventor.Application)Marshal.GetActiveObject("Inventor.Application");
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("Inventor未能打开，请打开任务管理器将后台的Inventor删除！");
                    }
                    break;
                }
                if (inv_open_state == false)
                {
                    try
                    {
                        _invApp = (Inventor.Application)Marshal.GetActiveObject("Inventor.Application");

                    }
                    catch
                    {
                        try
                        {
                            Type invAppType = Type.GetTypeFromProgID("Inventor.Application");
                            _invApp = (Inventor.Application)Activator.CreateInstance(invAppType);
                           _invApp.Visible = true;
                           _started = true;
                        }
                        catch
                        {
                            System.Windows.Forms.MessageBox.Show("Inventor未能直接打开,请检查后台进程！");
                        }
                    }


                }
            }

        }

        public void End_Inventor()
        {
            if( _started==true)
            {
                _invApp.Quit();
                Marshal.ReleaseComObject(_invApp);
                _invApp=null;
            }
            //shutdown Inventor application in background
            Process[] Procs = Process.GetProcesses();
            foreach(Process Proc in Procs)
            {
                if(Proc.ProcessName == "Inventor")
                {
                    Proc.Kill();
                }
            }
        }

        public void alter_K_value(string _dxf_dir,string _ipt_new_dir,string thickness, string K_value)
        {
            _invApp.SilentOperation = true;
            PartDocument oPartdoc = (PartDocument)_invApp.Documents.Open(_ipt_new_dir);
            PartFeatures oFeatrues=oPartdoc.ComponentDefinition.Features;
            bool _IsDerivePart = false;

            if (oPartdoc.SubType== "{9C464203-9BAE-11D3-8BAD-0060B0CE6BB4}")
            {
                if (oFeatrues.Count == 1)
                {
                    if (oFeatrues[1].Name.Contains("实体") == true || oFeatrues[1].Name.Contains("Solid") == true)
                    {
                        _IsDerivePart = true;
                    }
                }
                success = "否";
                if (_IsDerivePart == false)
                {
                    SheetMetalComponentDefinition oSheetCompDef = (SheetMetalComponentDefinition)oPartdoc.ComponentDefinition;
                    Inventor.Parameters oParameters = oPartdoc.ComponentDefinition.Parameters;
                    UserParameters oUserParams = oParameters.UserParameters;
                    UnfoldMethod oUnfoldMethod = oSheetCompDef.UnfoldMethod;
                    FlatPattern oFlatPattern = oSheetCompDef.FlatPattern;
                    if (oSheetCompDef.HasFlatPattern == true)
                    {
                        //Access flatpattern length & width value before altering k factor value
                        unchange_flat_l = Convert.ToString(Math.Round(oFlatPattern.Length * 10, 1));
                        unchange_flat_w = Convert.ToString(Math.Round(oFlatPattern.Width * 10, 1));
                        string _material = oPartdoc.ComponentDefinition.Material.Name;
                        if (_material.Contains("板") == true)
                        {
                            string[] _material_split = _material.Split(' ');
                            if (_material_split[2] == thickness)
                            {
                                Material = _material;
                                original_kfactor = oUnfoldMethod.kFactor;
                                if (original_kfactor == "kfactor")
                                {
                                    unchange_kfactor = Convert.ToString(oUserParams["kfactor"].Value);
                                    oUserParams["kfactor"].Value = Convert.ToDouble(K_value);
                                }
                                else
                                {
                                    if (original_kfactor.Contains("ul") == true)
                                    {
                                        unchange_kfactor = original_kfactor.Substring(0, original_kfactor.Length - 2);
                                    }
                                    else
                                    {
                                        unchange_kfactor = original_kfactor;
                                    }
                                    oUnfoldMethod.kFactor = K_value;
                                }




                                oPartdoc.Update();
                                oPartdoc.Save();


                                change_flat_l = Convert.ToString(Math.Round(oFlatPattern.Length * 10, 1));


                                change_flat_w = Convert.ToString(Math.Round(oFlatPattern.Width * 10, 1));

                                success = "是";
                                //after altering k factor value then generating dxf document
                                DataIO oDataIO = oPartdoc.ComponentDefinition.DataIO;
                                string sOut = "FLAT PATTERN DXF?AcadVersion=2000&OuterProfileLayer=IV_OUTER_PROFILE&InvisibleLayers=IV_BEND;IV_BEND_DOWN;IV_TANGENT;IV_ARC_CENTERS;IV_TOOL_CENTER;IV_TOOL_CENTER_DOWN";
                                oDataIO.WriteDataToFile(sOut, _dxf_dir);
                            }
                        }
                    }
                }
               
             
              
               
            }


            oPartdoc.Close();
            System.Threading.Thread.Sleep(300);
                
        }

        public void copy_file(string _ipt_dir,string _ipt_new_dir)
        {
            ApprenticeServerComponent oApprentice= new ApprenticeServerComponent();
            ApprenticeServerDocument oApprentice_PartDoc = oApprentice.Open(_ipt_dir);
            FileSaveAs oFileSaveAs = oApprentice.FileSaveAs;
            oFileSaveAs.AddFileToSave(oApprentice_PartDoc, _ipt_new_dir);
            oFileSaveAs.ExecuteSaveCopyAs();
            oApprentice_PartDoc.Close(); 

            oApprentice = new ApprenticeServerComponent();
            oApprentice_PartDoc=(ApprenticeServerDocument)oApprentice.Open(_ipt_new_dir);
            PropertySet oPropSet = oApprentice_PartDoc.PropertySets["Design Tracking Properties"];
            Property oProp_Partnumber = oPropSet["Part Number"];
            oProp_Partnumber.Value = System.IO.Path.GetFileNameWithoutExtension(_ipt_new_dir);
            oApprentice_PartDoc.PropertySets.FlushToFile();
            oApprentice_PartDoc.Close ();   
        }

        public void ToggleEventTriggerDisabled()
        {
            ApplicationAddIn oiLogic = _invApp.ApplicationAddIns.ItemById["{3BDD8D79-2179-4B11-8A5A-257B1C0263AC}"];
            oiLogic.Activate();
            dynamic oAuto = oiLogic.Automation;
            oAuto.RulesOnEventsEnabled = false;
        }

        public void data_output_excel(DataGridView _datagridview,string _outpath,string _enclosure_number)
        {
            Excel.Application xlsx_App = new Excel.Application();
            Excel.Workbook WB;
            Excel.Worksheet WS;
            xlsx_App.Visible = false;
            string excel_dir = System.IO.Path.Combine(_outpath, _enclosure_number+"钣金展开系数修改明细表.xlsx");
            if (!System.IO.File.Exists(excel_dir))
            {
                WB = xlsx_App.Workbooks.Add(true);
                WS = WB.Worksheets[1];
                WS.Activate();
                int maxrow=WS.UsedRange.EntireRow.Count;
                if (maxrow >= 1)
                {
                    WS.Range["A2:A" + maxrow.ToString()].EntireRow.Delete();
                }
                for(int i=0;i<_datagridview.ColumnCount;i++)
                {
                    WS.Cells[1, i + 1].Value = _datagridview.Columns[i].HeaderText;
                }
                for(int i=0;i<_datagridview.Rows.Count;i++)
                {
                    for(int j=0;j<_datagridview.Columns.Count;j++)
                    {
                        WS.Cells[i + 2, j + 1].Value = _datagridview.Rows[i].Cells[j].Value;    
                    }
                }
                Excel.Range oRange = WS.UsedRange;
                oRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;
                oRange.Borders.Weight = Excel.XlBorderWeight.xlThin;
                WS.Columns.AutoFit();
                WS.Range["E:E"].EntireColumn.Delete();
                WS.Range["D:D"].EntireColumn.Delete();

                WB.SaveAs(excel_dir);
                WB.Close();
            }
            


            
          
        }

    }
}
