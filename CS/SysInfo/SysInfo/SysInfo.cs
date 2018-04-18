#region Includes
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;
#endregion

namespace ASquigglyTwist
{
    namespace SysInfo
    {
        #region System Information
        public partial class SysInfo : Form
        {
            #region Skeleton
            int ms, s, m, h;
            string tmpp, temp;
            StringBuilder tmp = null;
            const string sep = " : ", nl = "\r\n", unitm = " MB", pge = "%";
            Drive[] drv;
            List<Label> labels;

            public SysInfo()
            {
                InitializeComponent();
                labels = new List<Label>();
                labels.Add(lblMName);
                labels.Add(lblOSVer);
                labels.Add(lblPCount);
                labels.Add(lblSysDir);
                labels.Add(lblUName);
                labels.Add(lblUpTime);
                labels.Add(lblNetwork);
                labels.Add(lblBootMode);
                labels.Add(lblPowerStatus);
                labels.Add(lblMonitorSize);
                Basicity();
                Advancement();
                Partitioner();
            }

            #region Basic Info
            /// <summary>
            /// Collect and display Basic Information about the System
            /// </summary>
            internal void Basicity()
            {
                lblMName.Text = System.Environment.MachineName;
                lblOSVer.Text = System.Environment.OSVersion.VersionString;
                lblPCount.Text = System.Environment.ProcessorCount.ToString();
                lblSysDir.Text = System.Environment.SystemDirectory;
                lblUName.Text = System.Environment.UserName;
                lblUpTime.Text = ((System.Environment.TickCount / 1000) / 60).ToString() + "  Minute(s)";
                lblNetwork.Text = SystemInformation.Network.ToString();
                lblBootMode.Text = SystemInformation.BootMode.ToString();
                lblPowerStatus.Text = (SystemInformation.PowerStatus.PowerLineStatus).ToString();
                lblMonitorSize.Text = SystemInformation.PrimaryMonitorSize.ToString();
            }
            #endregion

            #region Advanced Info
            /// <summary>
            /// Collect and display Advanced Information about the System
            /// </summary>
            internal void Advancement()
            {
                ManagementObjectSearcher mosDisks = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                int i = 0;
                i = mosDisks.Get().Count;
                drv = new Drive[i];
                for (int j = 0; j < i; j++)
                {
                    drv[j] = new Drive();
                }
                i = 0;
                {
                    foreach (ManagementObject moDisk in mosDisks.Get())
                    {
                        drv[i].bpsector = moDisk["BytesPerSector"].ToString();
                        drv[i].capacity = moDisk["Size"].ToString() + " bytes (" + Math.Round(((((double)Convert.ToDouble(moDisk["Size"]) / 1024) / 1024) / 1024), 2) + " GB)";
                        drv[i].cylinders = moDisk["TotalCylinders"].ToString();
                        drv[i].heads = moDisk["TotalHeads"].ToString();
                        drv[i].interfacetyp = moDisk["InterfaceType"].ToString();
                        drv[i].model = moDisk["Model"].ToString();
                        cmbDrive.Items.Add(drv[i].model);
                        drv[i].partitions = moDisk["Partitions"].ToString();
                        drv[i].sectors = moDisk["TotalSectors"].ToString();
                        drv[i].signature = moDisk["Signature"].ToString();
                        drv[i].sptrack = moDisk["SectorsPerTrack"].ToString();
                        drv[i].tpcylinder = moDisk["TracksPerCylinder"].ToString();
                        drv[i].tracks = moDisk["TotalTracks"].ToString();
                        drv[i].type = moDisk["MediaType"].ToString();
                        i++;
                    }
                }
                i = 0;
                {
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
                    foreach (ManagementObject wmi_HD in searcher.Get())
                    {
                        if (wmi_HD["SerialNumber"] == null)
                            drv[i].serialNo = "None";
                        else
                            drv[i].serialNo = wmi_HD["SerialNumber"].ToString();
                        i++;
                    }
                }
            }
            #endregion

            #region Partitions Info
            private void Partitioner()
            {
                long mb = 1048576;

                ConnectionOptions oConn = new ConnectionOptions();
                System.Management.ManagementScope oMs = new System.Management.ManagementScope("\\\\localhost", oConn);
                System.Management.ObjectQuery oQuery = new System.Management.ObjectQuery("select FreeSpace,Size,Name from Win32_LogicalDisk where DriveType=3");
                ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
                ManagementObjectCollection oReturnCollection = oSearcher.Get();

                double fs = 0;
                double us = 0;
                double tot = 0;
                double up = 0;
                double fp = 0;

                WritLin("*******************************************");
                WritLin("Hard Disks");
                WritLin("*******************************************");

                foreach (ManagementObject oReturn in oReturnCollection)
                {
                    WritLin("Name : " + oReturn["Name"].ToString());
                    fs = Convert.ToInt64(oReturn["FreeSpace"]) / mb;
                    us = (Convert.ToInt64(oReturn["Size"]) - Convert.ToInt64(oReturn["FreeSpace"])) / mb;
                    tot = Convert.ToInt64(oReturn["Size"]) / mb;
                    up = us / tot * 100;
                    fp = fs / tot * 100;
                    WritLin(nl);
                    tmpp = String.Format("{0:0,0.##}", tot);
                    WritLin("TotalSpace : " + tmpp + unitm);
                    tmpp = String.Format("{0:0,0.##}", fs);
                    WritLin("FreeSpace : " + tmpp + unitm);
                    tmpp = String.Format("{0:0,0.##}", us);
                    WritLin("UsedSpace : " + tmpp + unitm);
                    WritLin(nl);
                    WritLin("Percentages :");
                    tmpp = String.Format("{0:0,0.##}", up);
                    WritLin("Used : " + tmpp + pge);
                    tmpp = String.Format("{0:0,0.##}", fp);
                    WritLin("Free : " + tmpp + pge);
                    WritLin("*******************************************");
                }
            }

            StringBuilder tmps;
            private void WritLin(string p)
            {
                tmps = new StringBuilder(txtDriveInfo.Text);
                tmps.Append("\r\n").Append(p);
                txtDriveInfo.Text = tmps.ToString();
            }
            #endregion
            #endregion

            #region EventHandling
            private void tabby1_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (tabby1.SelectedIndex == 0)
                {
                    this.AcceptButton = btnBSave;
                    this.CancelButton = btnBExit;
                    btnBSave.Select();
                }
                else if (tabby1.SelectedIndex == 1)
                {
                    this.AcceptButton = btnSave;
                    this.CancelButton = btnExit;
                    cmbDrive.Select();
                }
                else if (tabby1.SelectedIndex == 2)
                {
                    this.AcceptButton = btnPSave;
                    this.CancelButton = btnPExit;
                    btnPSave.Select();
                }
            }

            private void btnBSave_Click(object sender, EventArgs e)
            {
                tmrUpTime.Enabled = false;
                StreamWriter writ = new StreamWriter(lblMName.Text + "_Report.txt");
                foreach (Label label in labels)
                {
                    writ.WriteLine(label.Text);
                }
                writ.Flush();
                writ.Close();
                tmrUpTime.Enabled = true;
            }

            private void tmrUpTime_Tick(object sender, EventArgs e)
            {
                ms = System.Environment.TickCount;
                s = ms / 1000;
                ms %= 1000;
                m = s / 60;
                s %= 60;
                h = m / 60;
                m %= 60;
                tmp = new StringBuilder();
                tmp.Append(h).Append(sep).Append(m).Append(sep);
                tmp.Append(s).Append(sep).Append(ms);
                lblUpTime.Text = tmp.ToString();
                GC.GetTotalMemory(true);
                GC.Collect();
                if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online)
                    temp = "Online: Battery = " + SystemInformation.PowerStatus.BatteryLifePercent + " %; Time = " + SystemInformation.PowerStatus.BatteryLifeRemaining + " seconds";
                else if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline)
                    temp = "Offline: Battery = " + SystemInformation.PowerStatus.BatteryLifePercent + " %; Time = " + SystemInformation.PowerStatus.BatteryLifeRemaining + " seconds";
                else
                    temp = "Unknown";
                lblPowerStatus.Text = temp;
            }

            private void btnBExit_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void cmbDrive_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cmbDrive.SelectedIndex > -1)
                    btnSave.Enabled = true;
                lblBytesPerSect.Text = "BytesPerSector          " + drv[cmbDrive.SelectedIndex].bpsector;
                lblCapacity.Text = "Capacity      " + drv[cmbDrive.SelectedIndex].capacity;
                lblCylinders.Text = "Cylinders     " + drv[cmbDrive.SelectedIndex].cylinders;
                lblHeads.Text = "Heads         " + drv[cmbDrive.SelectedIndex].heads;
                lblInterface.Text = "InterfaceType      " + drv[cmbDrive.SelectedIndex].interfacetyp;
                lblModel.Text = "Model      " + drv[cmbDrive.SelectedIndex].model;
                lblPartitions.Text = "Partitions      " + drv[cmbDrive.SelectedIndex].partitions;
                lblSectors.Text = "Sectors        " + drv[cmbDrive.SelectedIndex].sectors;
                lblSectorsPerTrack.Text = "SectorsPerTrack        " + drv[cmbDrive.SelectedIndex].sptrack;
                lblSerial.Text = "Serial       " + drv[cmbDrive.SelectedIndex].serialNo;
                lblSignature.Text = "Signature    " + drv[cmbDrive.SelectedIndex].signature;
                lblTracks.Text = "Tracks        " + drv[cmbDrive.SelectedIndex].tracks;
                lblTracksPerCyl.Text = "TracksPerCylinder     " + drv[cmbDrive.SelectedIndex].tpcylinder;
                lblType.Text = "Type        " + drv[cmbDrive.SelectedIndex].type;
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                StreamWriter writ = new StreamWriter(lblModel.Text + "_Report.txt");
                foreach (Control ctl in tbpAdvanced.Controls)
                {
                    if (ctl is Label)
                    {
                        writ.WriteLine(((Label)ctl).Text);
                    }
                }
                writ.Flush();
                writ.Close();
                cmbDrive.Select();
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void btnPSave_Click(object sender, EventArgs e)
            {
                StreamWriter writ = new StreamWriter("Partitions_Report.txt");
                writ.WriteLine(txtDriveInfo.Text);
                writ.Flush();
                writ.Close();
            }

            private void btnPExit_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
            #endregion
        }
        #endregion

        #region DriveObject
        public class Drive
        {
            public string model = null;
            public string type = null;
            public string serialNo = null;
            public string interfacetyp = null;
            public string capacity = null;
            public string partitions = null;
            public string signature = null;
            public string cylinders = null;
            public string heads = null;
            public string sectors = null;
            public string tracks = null;
            public string bpsector = null;
            public string sptrack = null;
            public string tpcylinder = null;
        }
        #endregion
    }
}