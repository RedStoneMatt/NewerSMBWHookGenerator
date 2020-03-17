using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using Newtonsoft;
using Newtonsoft.Json;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace NewerSMBWHookGenerator
{
    public partial class MultiKamek : Form
    {
        public MultiKamek()
        {
            InitializeComponent();
        }

        bool isLLVMGrey = true;
        bool isdevkitPPCGrey = true;
        bool isYAMLGrey = true;
        bool isPythonGrey = true;

        private void LLVMPath_Enter(object sender, EventArgs e)
        {
            if (LLVMPath.ReadOnly == false)
            {
                if (LLVMPath.Text == "tools/NewerSMBW-LLVM/bin" && isLLVMGrey == true)
                {
                    LLVMPath.Text = "";
                    LLVMPath.ForeColor = Color.Black;
                }
            }
        }

        private void LLVMPath_Leave(object sender, EventArgs e)
        {
            if (LLVMPath.ReadOnly == false)
            {
                if (LLVMPath.Text == "" && isLLVMGrey == false)
                {
                    LLVMPath.Text = "tools/NewerSMBW-LLVM/bin";
                    LLVMPath.ForeColor = Color.Gray;
                    isLLVMGrey = true;
                }
            }
        }

        private void LLVMPath_TextChanged(object sender, EventArgs e)
        {
            if (LLVMPath.ReadOnly == false)
            {
                if (LLVMPath.Text == "")
                {
                    isLLVMGrey = false;
                }
            }
        }

        private void YAMLName_Enter(object sender, EventArgs e)
        {
            if (YAMLName.Text == "NewerProjectKP.yaml" && isYAMLGrey == true)
            {
                YAMLName.Text = "";
                YAMLName.ForeColor = Color.Black;
            }
        }

        private void YAMLName_Leave(object sender, EventArgs e)
        {
            if (YAMLName.Text == "" && isYAMLGrey == false)
            {
                YAMLName.Text = "NewerProjectKP.yaml";
                YAMLName.ForeColor = Color.Gray;
                isYAMLGrey = true;
            }
        }

        private void YAMLName_TextChanged(object sender, EventArgs e)
        {
            if (YAMLName.Text == "")
            {
                isYAMLGrey = false;
            }
        }

        private void devkitPPCPath_Enter(object sender, EventArgs e)
        {
            if (devkitPPCPath.Text == "tools/devkitPPC/bin/powerpc-eabi" && isdevkitPPCGrey == true)
            {
                devkitPPCPath.Text = "";
                devkitPPCPath.ForeColor = Color.Black;
            }
        }

        private void devkitPPCPath_Leave(object sender, EventArgs e)
        {
            if (devkitPPCPath.Text == "" && isdevkitPPCGrey == false)
            {
                devkitPPCPath.Text = "tools/devkitPPC/bin/powerpc-eabi";
                devkitPPCPath.ForeColor = Color.Gray;
                isdevkitPPCGrey = true;
            }
        }

        private void devkitPPCPath_TextChanged(object sender, EventArgs e)
        {
            if (devkitPPCPath.Text == "")
            {
                isdevkitPPCGrey = false;
            }
        }

        private void pythonPath_Enter(object sender, EventArgs e)
        {
            if (pythonPath.ReadOnly == false)
            {
                if (pythonPath.Text == "C:\\Python27\\python.exe" && isPythonGrey == true)
                {
                    pythonPath.Text = "";
                    pythonPath.ForeColor = Color.Black;
                }
            }
        }

        private void pythonPath_Leave(object sender, EventArgs e)
        {
            if (pythonPath.ReadOnly == false)
            {
                if (pythonPath.Text == "" && isPythonGrey == false)
                {
                    pythonPath.Text = "C:\\Python27\\python.exe";
                    pythonPath.ForeColor = Color.Gray;
                    isPythonGrey = true;
                }
            }
        }

        private void pythonPath_TextChanged(object sender, EventArgs e)
        {
            if (pythonPath.ReadOnly == false)
            {
                if (pythonPath.Text == "")
                {
                    isPythonGrey = false;
                }
            }
        }

        private void useBetterKamek_CheckedChanged(object sender, EventArgs e)
        {
            if (useBetterKamek.Checked)
            {
                pythonPath.Text = "";
                pythonPath.ReadOnly = true;
                getFilePython.Enabled = false;
            }
            else
            {
                pythonPath.Text = "C:\\Python27\\python.exe";
                isPythonGrey = true;
                pythonPath.ReadOnly = false;
                getFilePython.Enabled = true;
            }
        }

        private void useClang_CheckedChanged(object sender, EventArgs e)
        {
            if(useClang.Checked)
            {
                LLVMPath.Text = "tools/NewerSMBW-LLVM/bin";
                isLLVMGrey = true;
                LLVMPath.ReadOnly = false;
                getLLVMFolder.Enabled = true;
            }
            else
            {
                LLVMPath.Text = "";
                LLVMPath.ReadOnly = true;
                getLLVMFolder.Enabled = false;
            }
        }

        private void moveNewerASMtoNewerRes_CheckedChanged(object sender, EventArgs e)
        {
            if (moveNewerASMtoNewerRes.Checked)
            {
                NewerResPath.ReadOnly = false;
                getNewerResFolder.Enabled = true;
            }
            else
            {
                NewerResPath.Text = "";
                NewerResPath.ReadOnly = true;
                getNewerResFolder.Enabled = false;
            }
        }

        private void CompileButton_Click(object sender, EventArgs e)
        {
            String text = "cd \"" + SourcePath.Text + "\"\n@echo OFF\nSET mypath=%~dp0\necho adding paths ''%mypath:~0,-1%\\tools\\devkitPPC\\bin'' and ''%mypath:~0,-1%\\tools\\NewerSMBW-LLVM\\bin''\nset PATH=%PATH%;%mypath:~0,-1%\\tools\\devkitPPC\\bin;%mypath:~0,-1%\\tools\\NewerSMBW-LLVM\\bin\necho path set.\nrmdir /s /q Build\nrmdir /s /q NewerASM\nmkdir Build\nmkdir NewerASM\n";
            if(useBetterKamek.Checked)
            {
                if (SourcePath.Text == "")
                {
                    MessageBox.Show("Please enter a valid Source Code Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                text += "tools/BetterKamek.exe ";
            }
            if(!useBetterKamek.Checked)
            {
                if (pythonPath.Text == "" || pythonPath.ForeColor == Color.Gray || !pythonPath.Text.Contains("python.exe"))
                {
                    MessageBox.Show("Please enter a valid Python 2.7 Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                text += pythonPath.Text + " tools/mapfile_tool.py\n" + pythonPath.Text + " tools/kamek.py ";
            }
            if (YAMLName.Text == "" || YAMLName.ForeColor == Color.Gray || !YAMLName.Text.Contains(".yaml"))
            {
                MessageBox.Show("Please enter a Project YAML File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            text += YAMLName.Text + " ";
            if(noRels.Checked)
            {
                text += "--no-rels ";
            }
            if(useClang.Checked)
            {
                text += "--use-clang ";
            }
            if(showCMD.Checked)
            {
                text += "--show-cmd ";
            }
            if(keepTemp.Checked)
            {
                text += "--keep-temp ";
            }
            if (devkitPPCPath.Text == "" || devkitPPCPath.ForeColor == Color.Gray || !devkitPPCPath.Text.Contains("powerpc-eabi"))
            {
                MessageBox.Show("Please enter a valid devkitPPC Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            text += "--gcc-type=\"" + devkitPPCPath.Text + "\" ";
            if (useClang.Checked)
            {
                if (LLVMPath.Text == "" || LLVMPath.ForeColor == Color.Gray)
                {
                    MessageBox.Show("Please enter a valid LLVM Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                text += "--llvm-path=" + LLVMPath.Text;
            }
            if(moveNewerASMtoNewerRes.Checked)
            {
                if (NewerResPath.Text == "")
                {
                    MessageBox.Show("Please enter a valid NewerRes Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!useBetterKamek.Checked) 
                {
                    text += "\n" + pythonPath.Text + " tools/renameNewer.py --output=\"" + NewerResPath.Text + "\"";
                }
                if (useBetterKamek.Checked)
                {
                    text += " --do-rename=\"" + NewerResPath.Text + "\"";
                }
            }
            generatedCommand.Text = text;
            CompileButton.Text = "Compiling...";
            CompileButton.Enabled = false;
            text += "\npause";

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(SourcePath.Text, "makeNewerKPTemp.bat")))
            {
                outputFile.Write(text);
            }
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = SourcePath.Text + "\\makeNewerKPTemp.bat";
            proc.StartInfo.RedirectStandardError = false;
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.WorkingDirectory = SourcePath.Text;
            proc.Start();
            proc.WaitForExit();
            CompileButton.Text = "Compile";
            CompileButton.Enabled = true;
        }

        private void generatedCommand_TextChanged(object sender, EventArgs e)
        {

        }

        private void Example_Click(object sender, EventArgs e)
        {
            pythonPath.Text = "C:\\Python27\\python.exe";
            pythonPath.ForeColor = Color.Black;
            isPythonGrey = false;
            SourcePath.Text = "G:\\_IsoBuilder\\NewerGEM\\Kamek_2020-02-11";
            YAMLName.Text = "NewerProjectKP.yaml";
            YAMLName.ForeColor = Color.Black;
            isYAMLGrey = false;
            devkitPPCPath.Text = "tools/devkitPPC/bin/powerpc-eabi";
            devkitPPCPath.ForeColor = Color.Black;
            isdevkitPPCGrey = false;
            LLVMPath.Text = "tools/NewerSMBW-LLVM/bin";
            LLVMPath.ForeColor = Color.Black;
            isLLVMGrey = false;
            useClang.Checked = true;
            useBetterKamek.Checked = false;
            moveNewerASMtoNewerRes.Checked = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            NewerProj newersave = new NewerProj()
            {
                useBetterKamek = useBetterKamek.Checked,
                moveNewerASMtoNewerRes = moveNewerASMtoNewerRes.Checked,
                useClang = useClang.Checked,
                noRels = noRels.Checked,
                showCMD = showCMD.Checked,
                keepTemp = keepTemp.Checked,
                pythonPath = pythonPath.Text,
                SourcePath = SourcePath.Text,
                NewerResPath = NewerResPath.Text,
                YAMLName = YAMLName.Text,
                devkitPPCPath = devkitPPCPath.Text,
                LLVMPath = LLVMPath.Text
            };
            using (StreamWriter outputJson = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, saveName.Text + ".json")))
            {
                outputJson.Write(JsonConvert.SerializeObject(newersave));
            }
            logs.Text = "Saved current settings as " + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, saveName.Text + ".json");
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, loadName.Text + ".json")))
            {
                TextReader tr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, loadName.Text + ".json"));
                string json = tr.ReadToEnd();
                NewerProj newersave = JsonConvert.DeserializeObject<NewerProj>(json);
                useBetterKamek.Checked = newersave.useBetterKamek;
                moveNewerASMtoNewerRes.Checked = newersave.moveNewerASMtoNewerRes;
                useClang.Checked = newersave.useClang;
                noRels.Checked = newersave.noRels;
                showCMD.Checked = newersave.showCMD;
                keepTemp.Checked = newersave.keepTemp;
                pythonPath.Text = newersave.pythonPath;
                SourcePath.Text = newersave.SourcePath;
                NewerResPath.Text = newersave.NewerResPath;
                YAMLName.Text = newersave.YAMLName;
                devkitPPCPath.Text = newersave.devkitPPCPath;
                LLVMPath.Text = newersave.LLVMPath;
                if (LLVMPath.Text != "" && LLVMPath.Text != null)
                {
                    isLLVMGrey = false;
                    LLVMPath.ForeColor = Color.Black;
                }
                if (devkitPPCPath.Text != "" && devkitPPCPath.Text != null)
                {
                    isdevkitPPCGrey = false;
                    devkitPPCPath.ForeColor = Color.Black;
                }
                if (YAMLName.Text != "" && YAMLName.Text != null)
                {
                    isYAMLGrey = false;
                    YAMLName.ForeColor = Color.Black;
                }
                if (pythonPath.Text != "" && pythonPath.Text != null)
                {
                    isPythonGrey = false;
                    pythonPath.ForeColor = Color.Black;
                    getFilePython.Enabled = true;
                }
                if (newersave.moveNewerASMtoNewerRes)
                {
                    getNewerResFolder.Enabled = true;
                }
                if (newersave.useClang)
                {
                    getLLVMFolder.Enabled = true;
                }
                logs.Text = "Loaded " + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, loadName.Text + ".json");
                tr.Close();
            }
            else
            {
                logs.Text = "Unable to load " + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, loadName.Text + ".json") + ": File doesn't exist";
            }
        }

        private void getFilePython_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = (pythonPath.ForeColor == Color.Gray || pythonPath.Text == "") ? "C:\\" : pythonPath.Text;
                dialog.Filter = "Python Executable|python.exe|All files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    isPythonGrey = false;
                    pythonPath.ForeColor = Color.Black;
                    pythonPath.Text = dialog.FileName;
                }
            }
        }

        private void getSourceFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = (SourcePath.ForeColor == Color.Gray || SourcePath.Text == "") ? "C:\\" : SourcePath.Text;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                SourcePath.Text = dialog.FileName;
            }
        }

        private void getNewerResFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = (NewerResPath.ForeColor == Color.Gray || NewerResPath.Text == "") ? "C:\\" : NewerResPath.Text;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                NewerResPath.Text = dialog.FileName;
            }
        }

        private void getDevkitFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = (devkitPPCPath.ForeColor == Color.Gray || devkitPPCPath.Text == "") ? "C:\\" : devkitPPCPath.Text;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                isPythonGrey = false;
                devkitPPCPath.ForeColor = Color.Black;
                devkitPPCPath.Text = dialog.FileName + "\\powerpc-eabi";
            }
        }

        private void getLLVMFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = (LLVMPath.ForeColor == Color.Gray || LLVMPath.Text == "") ? "C:\\" : LLVMPath.Text;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                isLLVMGrey = false;
                LLVMPath.ForeColor = Color.Black;
                LLVMPath.Text = dialog.FileName;
            }
        }
    }
    public class NewerProj
    {
        public bool useBetterKamek { get; set; }
        public string pythonPath { get; set; }
        public string SourcePath { get; set; }
        public bool moveNewerASMtoNewerRes { get; set; }
        public string NewerResPath { get; set; }
        public string YAMLName { get; set; }
        public string devkitPPCPath { get; set; }
        public bool useClang { get; set; }
        public string LLVMPath { get; set; }
        public bool noRels { get; set; }
        public bool showCMD { get; set; }
        public bool keepTemp { get; set; }
    }
}
